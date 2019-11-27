using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseTemp;
using System.Windows.Forms;

namespace AnimalHouseV3
{
    public partial class Form_Owner : Form
    {
        JacobTempAHC Controller = new JacobTempAHC();
        
        public Form_Owner()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {}
        private void ButtonCreateOwner_Click(object sender, EventArgs e)
        {
            if (BusinessCheck.Checked==true &&PrivateCheck.Checked!=true)
            {
                Controller.CreateBusinessOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text), TextBoxCompanyName.Text, Convert.ToInt32(TextBoxCVRNR.Text));
                PrivateCheck.Checked = false;
               
                
            }
            else if(PrivateCheck.Checked==true&&BusinessCheck.Checked!=true)
            {
                Controller.CreatePrivateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
                BusinessCheck.Checked = false;
            }
            else if(PrivateCheck.Checked == true && BusinessCheck.Checked == true)
            {
                MessageBox.Show("check only one box", "Only one checkbox please", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Please check either Business or Private checkbox", "Checkbox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Form_Owner_Load(object sender, EventArgs e)
        {

        }
        private void BusinessCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BusinessCheck.Checked)
            {
                PrivateCheck.Checked = false;
                TextBoxCompanyName.Visible = true;
                TextBoxCVRNR.Visible = true;
                labelCVRNR.Visible = true;
                labelCompanyName.Visible = true;
            }
            if (!BusinessCheck.Checked)
            {
                PrivateCheck.Checked = true;
                TextBoxCompanyName.Visible = false;
                TextBoxCVRNR.Visible = false;
                labelCVRNR.Visible = false;
                labelCompanyName.Visible = false;
            }
        }

        private void ButtonSearchOwner_Click(object sender, EventArgs e)
        {
            if (BusinessCheck.Checked)
            {
             //  List<string>
               List<string> OwnerList= Controller.SearchForOwner(TextBoxTelephoneNR.Text);
                TextBoxTelephoneNR.Text = OwnerList[0];
                TextBoxFirstName.Text = OwnerList[1];
                TextBoxLastName.Text = OwnerList[2];
                TextBoxStreet.Text = OwnerList[3];
                TextBoxEmail.Text = OwnerList[4];
                TextBoxCity.Text = OwnerList[5];
                TextBoxZipCode.Text = OwnerList[6];
                
                
               
            }
            else if(PrivateCheck.Checked)
            {
                List<string> OwnerList = Controller.SearchForOwner(TextBoxTelephoneNR.Text);
                TextBoxTelephoneNR.Text = OwnerList[0];
                TextBoxFirstName.Text = OwnerList[1];
                TextBoxLastName.Text = OwnerList[2];
                TextBoxStreet.Text = OwnerList[3];
                TextBoxEmail.Text = OwnerList[4];
                TextBoxCity.Text = OwnerList[5];
                TextBoxZipCode.Text = OwnerList[6];
            }
        }

        private void ButtonUpdateOwner_Click(object sender, EventArgs e)
        {
         //   Controller.UpdatePrivateOwner()
        }
    }
}
