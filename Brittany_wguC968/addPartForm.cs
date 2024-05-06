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


namespace Brittany_wguC968
{
    public partial class AddPartForm : Form
    {
        private Main mainForm;
        private Inventory inventory;
        

        public AddPartForm(Main mainForm, Inventory inventory)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            this.inventory = mainForm.Inventory;
            
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
                newPart = new InHouse
                {
                    Name = txtPartName.Text,
                    InStock = ParseInt(numInventory.Text),
                    Price = decimal.Parse(numPrice.Text),
                    Min = ParseInt(numMin.Text),
                    Max = ParseInt(numMax.Text),
                    MachineID = ParseInt(numMachineID.Text)
                };
                inventory.AddPart(newPart);

            }
            else if (outSourcedRadioBtn.Checked)
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
                inventory.AddPart(newPart);
            }
            
            
            this.Close();
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioBtn.Checked)
            {
                label8.Text= "Machine ID";
                numMachineID.Visible = true;
                txtCompanyName.Visible = false;
            }
        }

        private void outSourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (outSourcedRadioBtn.Checked)
            {
                label8.Text = "Company Name";
                txtCompanyName.Visible = true;

                numMachineID.Visible = false;
            }
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
   
}
