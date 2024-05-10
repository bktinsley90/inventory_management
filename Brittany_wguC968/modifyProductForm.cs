using System;
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
        private Product currProduct;
        private Main mainForm;
        private BindingList<Part> associatedPartsBindingList;
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

            associatedPartsBindingList = new BindingList<Part>(currProduct.AssociatedParts.ToList());
            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = associatedPartsBindingList;
            CustomizeDataGridView(dataGridView1);
            CustomizeDataGridView(dataGridView2);


            PopulateAssociatedPartsDataGridView();
        }
        private void CustomizeDataGridView(DataGridView dataGridView)
        {
            dataGridView.AutoGenerateColumns = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowHeadersVisible = false;
            dataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
        }
        private void PopulateAssociatedPartsDataGridView()
        {
            
            System.Collections.IList list = currProduct.AssociatedParts;
            for (int i = 0; i < list.Count; i++)
            {
                int partId = (int)list[i];
                Part associatedPart = currProduct.LookupAssociatedPart(partId);
                if (associatedPart != null)
                {
                    dataGridView2.Rows.Add(associatedPart.PartID,  associatedPart.Name, associatedPart.InStock, associatedPart.Max, associatedPart.Min);
                }
            }
        }
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Part selectedPart = dataGridView1.SelectedRows[0].DataBoundItem as Part;
                currProduct.AddAssociatedPart(selectedPart);
                associatedPartsBindingList.Add(selectedPart);
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
