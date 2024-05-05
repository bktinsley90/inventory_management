using System.Security.Cryptography.X509Certificates;

namespace Brittany_wguC968
{
   
    public partial class Main : Form
    {
       
        private List<Part> parts;
        private List<Product> products;
        private Inventory inventory;
        public Main()
        {
            InitializeComponent();
           
            PopulateDataGridViews();
            inventory = new Inventory();
            exitBtn.Click += exitBtn_Click;
       
            addPartBtn.Click += AddPartBtn_Click;
        }
     
        
   
       /* public void AddPartToList(Part newPart)
        {
           parts.Add(newPart);
        }*/

        private void PopulateDataGridViews()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            var parts = inventory.GetParts();
            var products = inventory.GetProducts();

            dataGridView1.DataSource = parts;
            dataGridView2.DataSource = products;

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
            addPartForm.PartAdded += AddPartForm_PartAdded;
            addPartForm.Show();
        }
        private void AddPartForm_PartAdded(object sender, AddPartForm.PartAddedEventArgs e)
        {
            inventory.AddPart(e.NewPart, dataGridView1);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = parts;
            //dataGridView1.Rows.Add(e.NewPart.PartID, e.NewPart.Name, e.NewPart.InStock, e.NewPart.Price, e.NewPart.Min, e.NewPart.Max);
        }
      /*  public class Part
        {
            public int PartID { get; set; }
            public string Name { get; set; }
            public int Inventory { get; set; }
            public decimal Price { get; set; }
            public int Min { get; set; }
            public int Max { get; set; }
        }
        public class Product
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public int Inventory { get; set; }
            public decimal Price { get; set; }
            public int Min { get; set; }
            public int Max { get; set; }
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
