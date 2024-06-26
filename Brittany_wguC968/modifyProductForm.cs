﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Brittany_wguC968
{
    public partial class modifyProductForm : Form
    {
        private Product currProduct;
        private Main mainForm;
        private BindingList<Part> associatedPartsBindingList = new BindingList<Part>();
        public modifyProductForm(Main mainForm, Product product)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.currProduct = product;

          
            //current values
            IDtextBox.Text = currProduct.ProductID.ToString();
            productNameTxt.Text = currProduct.Name;
            numInventory.Text = currProduct.InStock.ToString();
            numPrice.Text = currProduct.Price.ToString();
            numMin.Text = currProduct.Min.ToString();
            numMax.Text = currProduct.Max.ToString();

            //this is to add the current parts associated
            foreach (Part part in currProduct.LookupAssociatedParts())
            {
                associatedPartsBindingList.Add(part);
            }
            
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = associatedPartsBindingList;
            CustomizeDataGridView(dataGridView1);
            CustomizeDataGridView(dataGridView2);

            //validation
            saveProductBtn.Enabled = false;

            ValidateFields();

        }
        private void CustomizeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Columns["InStock"].HeaderText = "Inventory";
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }
        private void ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(productNameTxt.Text))
            {
                SetError(productNameTxt, "Please enter a Part Name");
                isValid = false;
            }
            else
            {
                ClearError(productNameTxt);

            }
            //validating Min
            int min;
            if (!int.TryParse(numMin.Text, out min) || min < 0)
            {
                SetError(numMin, "Please enter a valid integer for Min");
                isValid = false;
            }
            else
            {
                ClearError(numMin);
            }

            int max;
            if (!int.TryParse(numMax.Text, out max) || max < 0)
            {
                SetError(numMax, "Please enter a valid integer for max");
                isValid = false;
            }
            else
            {
                ClearError(numMax);
            }
            //validating instock
            int inStock;
            if (!int.TryParse(numInventory.Text, out inStock) || inStock < 0)
            {
                SetError(numInventory, "Please enter valid interger for Inventory");
                isValid = false;
            }
            else if (inStock < min || inStock > max)
            {
                SetError(numInventory, "Inventory must be between Min and Max");
                isValid = false;
            }
            else
            {
                ClearError(numInventory);

            }
            //Validating Price
            decimal price;
            if (!decimal.TryParse(numPrice.Text, out price) || price < 0)
            {
                SetError(numPrice, "Please enter a valid decimal for price");
                isValid = false;
            }
            else
            {
                ClearError(numPrice);

            }

            //validate max <= min
            if (max <= min)
            {
                SetError(numMax, "Max must be greater than Min");
                SetError(numMin, "Min must be less than Max");
                isValid = false;
            }
            else
            {
                ClearError(numMax);
                ClearError(numMin);
            }
            saveProductBtn.Enabled = isValid;
           
        }

        private void SetError(Control control, string msg)
        {
            toolTip1.SetToolTip(control, msg);
            control.BackColor = Color.Salmon;

        }
        private void ClearError(Control control)
        {
            toolTip1.SetToolTip(control, "");
            control.BackColor = Color.White;
        }
        private void Control_TxtChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Part selectedPart = dataGridView1.SelectedRows[0].DataBoundItem as Part;
                if (!associatedPartsBindingList.Contains(selectedPart))
                {
                    currProduct.AddAssociatedPart(selectedPart);
                    associatedPartsBindingList.Add(selectedPart);
                }
                else
                {
                    MessageBox.Show("This part is already associated with the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this part from this product?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part selectedPart = dataGridView1.SelectedRows[0].DataBoundItem as Part;
                currProduct.RemoveAssociatedPart(selectedPart);
                associatedPartsBindingList.Remove(selectedPart);
            }
            else return;

        }
        private void SearchPartBtn_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            string keyword = searchPartTextBox.Text.Trim().ToLower();
            bool foundMatch = false;
            var parts = Inventory.PartsList;
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a search keyword.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = parts;
                return;
            }


            for (int i = 0; i < parts.Count; i++)
            {
                if (parts[i].Name.ToLower().Contains(keyword))
                {
                    TempList.Add(parts[i]);
                    foundMatch = true;
                }
            }
            dataGridView1.DataSource = TempList;

            if (!foundMatch)
            {
                MessageBox.Show("No matching part found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = parts;
            }
        }
        private int ParseInt(string x)
        {
            return int.Parse(x);
        }
        private void SaveProductBtn_Click(object sender, EventArgs e)
        {
            int productID = ParseInt(IDtextBox.Text);
            string productName = productNameTxt.Text;
            int InStock = ParseInt(numInventory.Text);
            decimal price = decimal.Parse(numPrice.Text);
            int min = ParseInt(numMin.Text);
            int max = ParseInt(numMax.Text);

            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("At least one part must be associated with the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //creating new product
            Product newProduct = new Product( productID, productName, InStock, price, min, max);

            Product oldProductID = Inventory.LookupProduct(productID);
            Inventory.UpdateProduct(oldProductID, newProduct);
            mainForm.PopulateDataGridViews();
            newProduct.AssociatedParts.Clear();
            foreach (Part part in associatedPartsBindingList)
            {
                newProduct.AddAssociatedPart(part);
            }

            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
