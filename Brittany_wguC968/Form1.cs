using System.Security.Cryptography.X509Certificates;

namespace Brittany_wguC968
{
   
    public partial class Main : Form
    {
        private Inventory inventory;
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
           productTable.DataSource =Inventory.Products;

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
      
    }
}
