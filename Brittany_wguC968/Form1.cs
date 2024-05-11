using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Brittany_wguC968
{

    public partial class Main : Form
    {
        

        public Inventory? Inventory { get; internal set; }

        public Main()
        {
            InitializeComponent();
            Inventory = new Inventory();
            Inventory.sampleParts();
            Inventory.sampleProducts();
            PopulateDataGridViews();
        }

        public void PopulateDataGridViews()
        {
            var partsTable = new BindingSource();
            var productTable = new BindingSource();

            partsTable.DataSource = Inventory.AllParts;
            productTable.DataSource = Inventory.Products;

            dataGridView1.DataSource = partsTable;
            dataGridView2.DataSource = productTable;

            //creating a seperate function to customize
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
        private void exitBtn_Click(object send, EventArgs e)
        {
            Application.Exit();
        }
       
        private void AddPartBtn_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm(this, Inventory);
            addPartForm.Show();
        }
        private void ModPartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow.DataBoundItem is InHouse inHouse)
                {
                    new modifyPartForm(this, inHouse).Show();
                }
                else if (dataGridView1.CurrentRow.DataBoundItem is Outsourced outsourced)
                {
                    new modifyPartForm(this, outsourced).Show();
                }
                else
                {
                    MessageBox.Show("Unexpected part type selected");
                }
            }
            else
            {
                MessageBox.Show("Must select a Part!");
            }
        }
        private void AddProdBtn_CLick(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm(this, Inventory);
            addProductForm.Show();
        }
        private void ModProdBtn_Click(object sender, EventArgs e)
        {
           if (dataGridView2.CurrentRow != null)
            {
                if (dataGridView2.CurrentRow.DataBoundItem is Product selectedProduct)
                {
                    new modifyProductForm(this, selectedProduct).Show();
                }
                else
                {
                    MessageBox.Show("Unexpected product type selected");
                }
            }
            else
            {
                MessageBox.Show("Must select a Product!");
            }
        }
        private void DeletePartBtn_CLick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really Want to delete Part?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DeleteProdBtn_Click(object sender, EventArgs e)
        {
            Product selectedProduct = dataGridView2.SelectedRows[0].DataBoundItem as Product;
            if (selectedProduct.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Cannot delete product with associated parts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really Want to delete Product?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    dataGridView2.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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


            for(int i=0; i < parts.Count; i++)
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
        private void SearchProductBtn_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            string keyword = searchProdTextBox.Text.Trim().ToLower();
            bool foundMatch = false;
            var products = Inventory.ProductList;
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a search keyword.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.ToLower().Contains(keyword))
                {
                    TempList.Add(products[i]);
                    foundMatch = true;
                }
            }
            dataGridView2.DataSource = TempList;

            if (!foundMatch)
            {
                MessageBox.Show("No matching part found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView2.DataSource = products;
            }
        }
      
    }
}
