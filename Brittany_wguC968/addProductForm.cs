using System;
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
    public partial class addProductForm : Form
    {
        private Main mainForm;
        private BindingList<Part> associatedPartsBindingList = new BindingList<Part>();
        public addProductForm(Main mainForm, Inventory inventory)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            
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
                    //product.AddAssociatedPart(selectedPart);
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
