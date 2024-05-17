using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Brittany_wguC968
{
    public partial class modifyPartForm : Form
    {
        private Part part;
        private Main mainForm;
        public modifyPartForm(Main mainForm, Part part)
        {
            InitializeComponent();
            this.part = part;
            this.mainForm = mainForm;

            IDtextBox.Text = part.PartID.ToString();
            txtPartName.Text = part.Name;
            numInventory.Text = part.InStock.ToString();
            numPrice.Text = part.Price.ToString();
            numMin.Text = part.Min.ToString();
            numMax.Text = part.Max.ToString();

            if (part is InHouse inHouse)
            {
                numMachineID.Text = inHouse.MachineID.ToString();
                inHouseRadioBtn.Checked = true;
                
            }
            else if (part is Outsourced outsourced)
            {
                txtCompanyName.Text = outsourced.CompanyName;
                outSourcedRadioBtn.Checked = true;
                
            }

            //validation
            saveBtn.Enabled = false;

            ValidateFields();
        }
        private int ParseInt(string x)
        {
            return int.Parse(x);
        }
        private void savePartBtn_Click(object sender, EventArgs e)
        {

            Part newPart;
            //part is InHouse inHouse, part is Outsourced outsourced

            if (inHouseRadioBtn.Checked)
            {

                newPart = new InHouse
                {
                    PartID = part.PartID,
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
                    PartID = part.PartID,
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
                MessageBox.Show("Unexpected part type.");
                return;
            }
            Part oldPartID = Inventory.LookupPart(part.PartID);
            Inventory.UpdatePart(mainForm, oldPartID, newPart);
  
            MessageBox.Show("Changes saved SuccessFully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
            //validating Min
            int min;
            if (!int.TryParse(numMin.Text, out min) || min < 0)
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
            //validating instock
            int inStock;
            if (!int.TryParse(numInventory.Text, out inStock) || inStock < 0)
            {
                SetError(numInventory, "Please enter valid interger for Inventory");
                isValid = false;
            }
            else if (inStock < min || inStock > max)
            {
                SetError(numInventory, "Inventory must be between Min and Max");
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


            //validating machineID and CompanyName
            int machineID;
            if (inHouseRadioBtn.Checked && (!int.TryParse(numMachineID.Text, out machineID) || machineID < 0))
            {
                SetError(numMachineID, "Please enter a valid integer for MachineID");
                isValid = false;
            }
            else
            {
                ClearError(numMachineID);

            }


            if (outSourcedRadioBtn.Checked && string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                SetError(txtCompanyName, "Please enter a Company Name");
                isValid = false;
            }
            else
            {
                ClearError(txtCompanyName);

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
        private void inHouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadioBtn.Checked)
            {
                label8.Text = "Machine ID";
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
