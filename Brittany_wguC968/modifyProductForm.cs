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
    public partial class modifyProductForm : Form
    {
        private Product product;
        private Main mainForm;
        private Product product = new Product();
        private BindingList<Part> associatedPartsBindingList;
        public modifyProductForm(Main mainForm, Product Product)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.product = product;

            //current values
            IDtextBox.Text = product.ProductID.ToString();
            productNameTxt.Text = product.Name;
            numInventory.Text = product.InStock.ToString();
            numPrice.Text = product.Price.ToString();
            numMin.Text = product.Min.ToString();
            numMax.Text = product.Max.ToString();

            associatedPartsBindingList = new BindingList<Part>(product.AssociatedParts.ToList());
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
                product.AddAssociatedPart(selectedPart);
                associatedPartsBindingList.Add(selectedPart);
            }
        }
        private void DeleteAssociatedPart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this part from this product? This Cannot be undone!", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Part selectedPart = dataGridView1.SelectedRows[0].DataBoundItem as Part;
                product.RemoveAssociatedPart(selectedPart);
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
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
