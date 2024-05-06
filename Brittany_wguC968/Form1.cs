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
            
            exitBtn.Click += exitBtn_Click;
       
           // addPartBtn.Click += AddPartBtn_Click;
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
      /*  private void AddPartForm_PartAdded(object sender, AddPartForm.PartAddedEventArgs e)
        {
            inventory.AddPart(e.NewPart, dataGridView1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = parts;
            //dataGridView1.Rows.Add(e.NewPart.PartID, e.NewPart.Name, e.NewPart.InStock, e.NewPart.Price, e.NewPart.Min, e.NewPart.Max);
        }*/
 

        private void label2_Click(object sender, EventArgs e)
        {

        }

        internal void AddPart(Brittany_wguC968.Part newPart)
        {
            throw new NotImplementedException();
        }
    }
}
