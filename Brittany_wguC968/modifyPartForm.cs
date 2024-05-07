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

namespace Brittany_wguC968
{
    public partial class modifyPartForm : Form
    {
        private Part part;
        public modifyPartForm(Part part)
        {
            InitializeComponent();
            this.part = part;

            IDtextBox.Text = part.PartID.ToString();
            txtPartName.Text = part.Name;
            numInventory.Text = part.InStock.ToString();
            numPrice.Text = part.Price.ToString();
            numMin.Text = part.Min.ToString();
            numMax.Text = part.Max.ToString();

            if(part is InHouse inHouse)
            {
                numMachineID.Text = inHouse.MachineID.ToString();
                inHouseRadioBtn.Checked = true;
                outSourcedRadioBtn.Enabled = false;
            }
            else if (part is Outsourced outsourced)
            {
                txtCompanyName.Text = outsourced.CompanyName;
                outSourcedRadioBtn.Checked = true;
                inHouseRadioBtn.Enabled = false;
            }
        }
        private int ParseInt(string x)
        {
            return int.Parse(x);
        }
        private void savePartBtn_Click(object sender, EventArgs e)
        {
            part.Name = txtPartName.Text;
            part.InStock = ParseInt(numInventory.Text);
            part.Price = decimal.Parse(numPrice.Text);
            part.Min = ParseInt(numMin.Text);
            part.Max = ParseInt(numMax.Text);
            

            if (part is InHouse inHouse)
            {
                inHouse.MachineID = ParseInt(numMachineID.Text);
            }
            else if (part is Outsourced outsourced)
            {
                outsourced.CompanyName = txtCompanyName.Text;
            }
            MessageBox.Show("Changes saved SuccessFully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
