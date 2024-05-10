﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brittany_wguC968
{
    public partial class addProductForm : Form
    {
        private Main mainForm;
       // private Product product = new Product();
        private BindingList<Part> associatedPartsBindingList = new BindingList<Part>();
        public addProductForm(Main mainForm, Inventory inventory)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            //associatedPartsBindingList = new BindingList<Part>(product.AssociatedParts.ToList());
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = associatedPartsBindingList;
            CustomizeDataGridView(dataGridView1);
            CustomizeDataGridView(dataGridView2);
        }


        private void CustomizeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Part selectedPart = dataGridView1.SelectedRows[0].DataBoundItem as Part;
               // product.AddAssociatedPart(selectedPart);
                associatedPartsBindingList.Add(selectedPart);
            }
        }
        private void DeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this part from this product? This Cannot be undone!", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part selectedPart = dataGridView1.SelectedRows[0].DataBoundItem as Part;
                //product.RemoveAssociatedPart(selectedPart);
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

            Product newProduct = new Product
            {
                Name = productNameTxt.Text,
                InStock = ParseInt(numInventory.Text),
                Price = decimal.Parse(numPrice.Text),
                Min = ParseInt(numMin.Text),
                Max = ParseInt(numMax.Text)
            };
            

            if(dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("At least one part must be associated with the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //creating new product
            //Product newProduct = new Product(productName, InStock, price, min, max);

            //adding the new product to inventory
            Inventory.AddProduct(newProduct);
            //this is to copy associated parts from associatedPartsBindingList
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
