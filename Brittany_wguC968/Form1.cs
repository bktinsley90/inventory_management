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
            InitializeData();
            PopulateDataGridViews();
            inventory = new Inventory();
            exitBtn.Click += exitBtn_Click;
       
            addPartBtn.Click += AddPartBtn_Click;
        }
        private void InitializeData()
        {
            inventory = new Inventory();

            inventory.AllParts.Add(new InHouse { PartID = 1, Name = "Wheel", InStock = 15, Price = 12.11m, Min = 5, Max = 25 });

            inventory.AllParts.Add(new InHouse { PartID = 2, Name = "Pedal", InStock = 11, Price = 8.22m, Min = 5, Max = 25 });

            inventory.AllParts.Add(new InHouse { PartID = 3, Name = "Chain", InStock = 12, Price = 8.33m, Min = 5, Max = 25 });

            inventory.AllParts.Add(new InHouse { PartID = 4, Name = "Seat", InStock = 8, Price = 4.55m, Min = 2, Max = 15 });


            inventory.AddProduct(new Product { ProductID = 1, Name = "Red Bicycle", InStock = 15, Price = 11.44m, Min = 1, Max = 25 });
            inventory.AddProduct(new Product { ProductID = 2, Name = "Yellow Bicycle", InStock = 19, Price = 9.66m, Min = 1, Max = 20 });
            inventory.AddProduct(new Product { ProductID = 3, Name = "Blue Bicycle", InStock = 5, Price = 12.77m, Min = 1, Max = 25 });
           
        }
        
   
        public void AddPartToList(Part newPart)
        {
           parts.Add(newPart);
        }

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
            inventory.AddPart(e.NewPart);
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
