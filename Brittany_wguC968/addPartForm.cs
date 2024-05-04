using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Brittany_wguC968.Main;

namespace Brittany_wguC968
{
    public partial class addPartForm : Form
    {
        public addPartForm()
        {
            InitializeComponent();
            saveBtn.Click += btnSave_Click;
         
        }
        private Main main;

        public addPartForm(Main main)
        {
            InitializeComponent();
            this.main = main;
        }
        private int ParseInt(string x)
        {
            return int.Parse(x);
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPartName.Text))
            {
                MessageBox.Show("Please enter a Part Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Part newPart = new Part
            {
                Name = txtPartName.Text,
                Inventory = ParseInt(numInventory.Text),
                Price = decimal.Parse(numPrice.Text),
                Min = ParseInt(numMin.Text),
                Max = ParseInt(numMax.Text)
            };

            main.AddPartToList(newPart);

            this.Close();
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!inHouseRadioBtn.Checked)
            {
                label8.Text = "Machine ID";
            }
        }

        private void outSourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (outSourcedRadioBtn.Checked)
            {
                label8.Text = "Company Name";
            }
        }
    }
   
}
