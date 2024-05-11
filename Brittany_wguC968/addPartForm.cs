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

        public AddPartForm(Main mainForm, Inventory inventory)
        {
            InitializeComponent();

            this.mainForm = mainForm;
            saveBtn.Enabled = false;

            ValidateFields();

        }

        private int ParseInt(string x)
        {
            return int.Parse(x);
        }
        public void btnSave_Click(object sender, EventArgs e)
        {
        
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

            }
            else
            {
                MessageBox.Show("Please select whether the part is In-House or Outsourced.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Inventory.AddPart(newPart);
            this.Close();
        }

        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioBtn.Checked)
            {
                label8.Text = "Machine ID";
                numMachineID.Visible = true;
                txtCompanyName.Visible = false;
            }
        }
        private void ValidateFields()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(txtPartName.Text))
            {
                SetError(txtPartName, "Please enter a Part Name");
                isValid = false;
            }
            else
            {
                ClearError(txtPartName);
                
            }
            //validating instock
            int inStock;
            if (string.IsNullOrWhiteSpace(numInventory.Text) || !int.TryParse(numInventory.Text, out inStock) || inStock <0)
            {
                SetError(numInventory, "Please enter valid interger for Inventory");
                isValid = false;
            }
            else
            {
                ClearError(numInventory);

            }
            //Validating Price
            decimal price;
            if (!decimal.TryParse(numPrice.Text, out price) || price < 0)
            {
                SetError(numPrice, "Please enter a valid decimal for price");
                isValid = false;
            }
            else
            {
                ClearError(numPrice);

            }
            //validating Min
            int min;
            if(!int.TryParse(numMin.Text, out min)|| min < 0)
            {
                SetError(numMin, "Please enter a valid integer for Min");
                isValid = false;
            }
            else
            {
                ClearError(numMin);
            }

            int max;
            if (!int.TryParse(numMax.Text, out max) || max < 0)
            {
                SetError(numMax, "Please enter a valid integer for max");
                isValid = false;
            }
            else
            {
                ClearError(numMax);
            }
            //validate max <= min
            if (max <= min)
            {
                SetError(numMax, "Max must be greater than Min");
                SetError(numMin, "Min must be less than Max");
                isValid = false;
            }
            else
            {
                ClearError(numMax);
                ClearError(numMin);
            }

            //validating Inventory between Min Max
            if (inStock < min || inStock >max)
            {
                SetError(numInventory, "Inventory must be between Min and Max");
                isValid = false;
            }
            else
            {
                ClearError(numInventory);
                
            }
            saveBtn.Enabled = isValid;
            //return isValid;
        }
        private void SetError(Control control, string msg)
        {
            toolTip1.SetToolTip(control, msg);
            control.BackColor = Color.Salmon;

        }
        private void ClearError(Control control)
        {
            toolTip1.SetToolTip(control, "");
            control.BackColor = Color.White;
        }
        private void Control_TxtChanged(object sender, EventArgs e)
        {
            ValidateFields();
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

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }

}
