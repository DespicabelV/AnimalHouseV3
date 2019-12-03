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
        List<string> OwnerList;
        List<string> BusinessList;
        string[] Adresse;
        public Form_Owner()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {}
        private void ButtonCreateOwner_Click(object sender, EventArgs e)
        {
            if (BusinessCheck.Checked &&!PrivateCheck.Checked)
            {
                Controller.CreateBusinessOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text+ "" +TextBoxNr.Text+ "" +TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text), TextBoxCompanyName.Text, Convert.ToInt32(TextBoxCVRNR.Text));
                PrivateCheck.Checked = false;
            }
            else if(PrivateCheck.Checked&&!BusinessCheck.Checked)
            {
                Controller.CreatePrivateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text + "" + TextBoxNr.Text + "" + TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
                BusinessCheck.Checked = false;
            }
            MessageBox.Show("The Owner was added to The System", "Creation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form_Owner_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animalhousev3DataSet.Dyr' table. You can move, or remove it, as needed.
            //this.dyrTableAdapter.Fill(this.animalhousev3DataSet.Dyr);

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
               BusinessList = Controller.SearchForBusiness(TextBoxTelephoneNR.Text);
               OwnerList= Controller.SearchForOwner(TextBoxTelephoneNR.Text);
               Adresse = OwnerList[3].Split(' ');
               TextBoxTelephoneNR.Text = OwnerList[0];
               TextBoxFirstName.Text = OwnerList[1];
               TextBoxLastName.Text = OwnerList[2];
                if (LejlighedCheck.Checked)
                {
                   TextBoxStreet.Text = Adresse[0];
                   TextBoxNr.Text = Adresse[1];
                   TextBoxFloor.Text = Adresse[2];
                }
                else
                {
                    TextBoxStreet.Text = Adresse[0];
                    TextBoxNr.Text = Adresse[1];
                    TextBoxFloor.Visible = true;
                }
                TextBoxEmail.Text = OwnerList[4];
               TextBoxCity.Text = OwnerList[5];
               TextBoxZipCode.Text = OwnerList[6];
               TextBoxCompanyName.Text = BusinessList[1];
               TextBoxCVRNR.Text = BusinessList[2];
               
            }
            else if(PrivateCheck.Checked)
            {
                 OwnerList = Controller.SearchForOwner(TextBoxTelephoneNR.Text);
                 Adresse = OwnerList[3].Split(' ');
                TextBoxTelephoneNR.Text = OwnerList[0];
                TextBoxFirstName.Text = OwnerList[1];
                TextBoxLastName.Text = OwnerList[2];
                if (LejlighedCheck.Checked)
                {
                    TextBoxStreet.Text = Adresse[0];
                    TextBoxNr.Text = Adresse[1];
                    TextBoxFloor.Text = Adresse[2];
                }
                else
                {
                    TextBoxStreet.Text = Adresse[0];
                    TextBoxNr.Text = Adresse[1];
                    TextBoxFloor.Visible = true;
                }
                TextBoxEmail.Text = OwnerList[4];
                TextBoxCity.Text = OwnerList[5];
                TextBoxZipCode.Text = OwnerList[6];
                

            }
            dataGridView1.DataSource= Controller.ShowAnimalDataTable(TextBoxTelephoneNR.Text);
        }
        private void ButtonUpdateOwner_Click(object sender, EventArgs e)
        {
            if (BusinessCheck.Checked)
            {
                Controller.UpdateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text+" " + TextBoxNr.Text+" " + TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
                Controller.UpdateBusiness(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxCompanyName.Text, TextBoxCVRNR.Text);
            }
            else if(PrivateCheck.Checked)
            {
                Controller.UpdateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text + " "+TextBoxNr.Text +" "+TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
            }
          
        }
        private void ButtonAddPet_Click(object sender, EventArgs e)
        {
            Form_Animal form = new Form_Animal();
            form.ShowDialog();
        }

        private void ButtonDeleteOwner_Click(object sender, EventArgs e)
        {
            if (PrivateCheck.Checked)
            {
                Controller.DeleteOwner("Relation", "ejer", TextBoxTelephoneNR.Text);
                Controller.DeleteOwner("Private_", "ejer", TextBoxTelephoneNR.Text);
                Controller.DeleteOwner("ejer", "TelefonNr", TextBoxTelephoneNR.Text);

            }
            else if (BusinessCheck.Checked)
            {
                Controller.DeleteOwner("Relation", "ejer", TextBoxTelephoneNR.Text);
                Controller.DeleteOwner("Erhverv", "ejer", TextBoxTelephoneNR.Text);
                Controller.DeleteOwner("ejer", "TelefonNr", TextBoxTelephoneNR.Text);
            }

            MessageBox.Show("The Owner was removed Sucessfully", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrivateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivateCheck.Checked)
            {
                BusinessCheck.Checked = false;
            }
            if (!PrivateCheck.Checked)
            {
                TextBoxCompanyName.Visible = false;
                TextBoxCVRNR.Visible = false;
                labelCVRNR.Visible = false;
                labelCompanyName.Visible = false;
            }
        }

        private void LejlighedCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (LejlighedCheck.Checked)
            {
                TextBoxFloor.Visible = true;
            }
            else if(!LejlighedCheck.Checked)
            {
                TextBoxFloor.Visible = false;
            }
        }

        private void ButtonHelpOwner_Click(object sender, EventArgs e)
        {
            PictureBox HelpPicture = new PictureBox();
            HelpPicture.Image =Image.FromFile("C:/Users/jacob/OneDrive/Billeder/Labrador Edit");

        }
    }
}
