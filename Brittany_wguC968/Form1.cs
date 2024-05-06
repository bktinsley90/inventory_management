using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Brittany_wguC968
{

    public partial class Main : Form
    {
        private Inventory inventory;
        private BindingList<Part> parts = new BindingList<Part> ();
        public Main()
        {
            InitializeComponent();
            Inventory.sampleParts();
            Inventory.sampleProducts();
            PopulateDataGridViews();
        }




        private void PopulateDataGridViews()
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
            dataGridView2.AutoGenerateColumns = true;
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
            AddPartForm addPartForm = new AddPartForm(this);
            //addPartForm.PartAdded += AddPartForm_PartAdded;
            addPartForm.Show();
        }
        private void ModPartBtn_Click(object sender, EventArgs e)
        {
            modifyPartForm modifyPartForm = new modifyPartForm();
            modifyPartForm.Show();
        }
        private void AddProdBtn_CLick(object sender, EventArgs e)
        {
            addProductForm addProductForm = new addProductForm();
            addProductForm.Show();
        }
        private void ModProdBtn_Click(object sender, EventArgs e)
        {
            modifyProductForm modifyProductForm = new modifyProductForm();
            modifyProductForm.Show();
        }
        private void DeletePartBtn_CLick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really Want to delete Part? This cannot be Undone", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Do you really Want to delete Product? This cannot be Undone", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
           
            string keyword = searchPartTextBox.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a search keyword.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BindingList<Part> filteredParts = new BindingList<Part>();

            foreach(var part in parts)
            {
                if(part.Name.ToLower().Contains(keyword))
                {
                    filteredParts.Add(part);
                }
            }
            dataGridView1.DataSource = filteredParts;
           
            if (filteredParts.Count == 0)
            {
                MessageBox.Show("No matching part found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        } 
      
    }
}
