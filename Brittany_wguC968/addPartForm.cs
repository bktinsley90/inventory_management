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

namespace AddPartForm
{
    public partial class AddPartForm : Form
    {
        private Main mainForm;
        private Inventory inventory;
        public event EventHandler<PartAddedEventArgs> PartAdded;

        public AddPartForm(Main mainForm)
        {
            InitializeComponent();
            saveBtn.Click += btnSave_Click;
            inventory = new Inventory();
            this.mainForm = mainForm;
        }
        private Main main;

      
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
            //creating a new part
            Part newPart;
            if (inHouseRadioBtn.Checked)
            {
                newPart = new Inhouse
                {
                    Name = txtPartName.Text,
                    InStock = ParseInt(numInventory.Text),
                    Price = decimal.Parse(numPrice.Text),
                    Min = ParseInt(numMin.Text),
                    Max = ParseInt(numMax.Text),
                    MachineID = ParseInt(numMachineID.Text)
                };
            }
            else
            {
                newPart = new Outsourced
                {
                    Name = txtPartName.Text,
                    InStock = ParseInt(numInventory.Text),
                    Price = decimal.Parse(numPrice.Text),
                    Min = ParseInt(numMin.Text),
                    Max = ParseInt(numMax.Text),
                    CompanyName = txtCompanyName.Text
                };
            }
            
            inventory.AddPart(newPart);
            //Raise the PartAdded event
            PartAdded?.Invoke(this, new PartAddedEventArgs(newPart));

            this.Close();
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioBtn.Checked)
            {
                label8.Text= "Machine ID";
                label8.Visible = true;
                numMachineID.Visible = true;


            }
        }

        private void outSourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (outSourcedRadioBtn.Checked)
            {
                label8.Text = "Company Name";
                label8.Visible = true;
                txtCompanyName.Visible = true;
            }
        }
        public class PartAddedEventArgs : EventArgs
        {
            public Part NewPart { get; }
            public PartAddedEventArgs(Part newPart)
            {
                NewPart = newPart;
            }
        }
    }
   
}
