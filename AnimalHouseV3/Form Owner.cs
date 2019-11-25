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
        {
            
        }

        private void ButtonCreateOwner_Click(object sender, EventArgs e)
        {
            if (BusinessCheck.Checked==true)
            {
                Controller.CreateBusinessOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text), TextBoxCompanyName.Text, Convert.ToInt32(TextBoxCVRNR.Text));
            }
            else if(PrivateCheck.Checked==true)
            {
                Controller.CreatePrivateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
            }
            else
            {
                MessageBox.Show("Please check either Business or Private checkbox", "Checkbox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
