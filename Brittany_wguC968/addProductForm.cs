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
    public partial class addProductForm : Form
    {
      
        private BindingList<Part> selectedParts = new BindingList<Part>();
        public addProductForm()
        {
            InitializeComponent();
            

            dataGridView1.DataSource = Inventory.AllParts;
            dataGridView2.DataSource = selectedParts;
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
