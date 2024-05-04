namespace Brittany_wguC968
{
   
    public partial class Main : Form
    {
        private List<Part> parts;
        private List<Product> products;
        public Main()
        {
            InitializeComponent();
            InitializeData();
            PopulateDataGridViews();
            exitBtn.Click += exitBtn_Click;
            addPartBtn.Click += addPartBtn_Click;
        }
        private void InitializeData()
        {
            parts = new List<Part> {
                 new Part { PartID=1, Name="Wheel", Inventory=15, Price=12.11m, Min=5, Max=25 },
                 new Part { PartID=2, Name="Pedal", Inventory=11, Price=8.22m, Min=5, Max=25},
                 new Part { PartID=3, Name="Chain", Inventory=12, Price=8.33m, Min=5, Max=25},
                 new Part { PartID=4, Name="Seat", Inventory=8, Price=4.55m, Min=2, Max=15}
            };
            products = new List<Product> {
                new Product {ProductID=1, Name="Red Bicycle", Inventory=15, Price=11.44m, Min=1, Max=25},
                new Product {ProductID=2, Name="Yellow Bicycle", Inventory=19, Price=9.66m, Min=1, Max=20},
                new Product {ProductID=3, Name="Blue Bicycle", Inventory=5, Price=12.77m, Min=1, Max=25}
            };
           
        }
        public void AddPartToList(Part newPart)
        {
            parts.Add(newPart);
        }
        private void PopulateDataGridViews()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = parts;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = products;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridView2.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
           

        }
        private void exitBtn_Click(object send, EventArgs e)
        {
            Application.Exit();
        }

        private void addPartBtn_Click(object sender, EventArgs e) 
        {
            addPartForm addPartForm = new addPartForm();
            addPartForm.ShowDialog();
        }
        public class Part
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
