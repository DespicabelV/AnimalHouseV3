using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHouseController;
using System.Windows.Forms;

namespace AnimalHouseV3
{
    public partial class Form_Owner : Form
    {
        //Jacob
        Contoller Controller = new Contoller();
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
            if (TextBoxTelephoneNR.Text == "" || TextBoxFirstName.Text == "" || TextBoxLastName.Text == "" || TextBoxStreet.Text == "" || TextBoxNr.Text == "" || TextBoxEmail.Text == "" || TextBoxCity.Text == "" || TextBoxZipCode.Text == "")
            {
                MessageBox.Show("You are missing some blank spaces, fill them out please", "Error: Empty spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BusinessCheck.Checked &&!PrivateCheck.Checked)
                {
                    Controller.ControllerCreateBusinessOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text+ " " +TextBoxNr.Text+ " " +TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text), TextBoxCompanyName.Text, Convert.ToInt32(TextBoxCVRNR.Text));
                    PrivateCheck.Checked = false;
                    MessageBox.Show("The Owner was added to The System", "Creation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if(PrivateCheck.Checked&&!BusinessCheck.Checked)
                {
                    Controller.ControllerCreatePrivateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text + " " + TextBoxNr.Text + " " + TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
                    BusinessCheck.Checked = false;
                    MessageBox.Show("The Owner was added to The System", "Creation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
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
            if (TextBoxTelephoneNR.Text == "")
            {
                MessageBox.Show("You are missing some blank spaces, fill them out please", "Error: Empty spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Controller.ControllerOwnerExist(TextBoxTelephoneNR.Text) == false)
            {
                MessageBox.Show("Does not exist!");
            }
            else if (BusinessCheck.Checked)
            {
               BusinessList = Controller.ControllerSearchForBusiness(TextBoxTelephoneNR.Text);
               OwnerList= Controller.ControllerSearchForOwner(TextBoxTelephoneNR.Text);
               Adresse = OwnerList[3].Split(' ');
               TextBoxTelephoneNR.Text = OwnerList[0];
               TextBoxFirstName.Text = OwnerList[1];
               TextBoxLastName.Text = OwnerList[2];
                if (ApartmentCheck.Checked)
                {
                   TextBoxStreet.Text = Adresse[0];
                   TextBoxNr.Text = Adresse[1];
                   TextBoxFloor.Text = Adresse[2];
                }
                else
                {
                    TextBoxStreet.Text = Adresse[0];
                    TextBoxNr.Text = Adresse[1];
                    label5.Visible = true;
                    TextBoxFloor.Visible = true;
                }
                TextBoxEmail.Text = OwnerList[4];
               TextBoxCity.Text = OwnerList[5];
               TextBoxZipCode.Text = OwnerList[6];
               TextBoxCompanyName.Text = BusinessList[1];
               TextBoxCVRNR.Text = BusinessList[2];

                dataGridViewOwnerDyr.DataSource = Controller.ControllerShowAnimalDataTable(TextBoxTelephoneNR.Text);
            }
            else if(PrivateCheck.Checked)
            {
                 OwnerList = Controller.ControllerSearchForOwner(TextBoxTelephoneNR.Text);
                 Adresse = OwnerList[3].Split(' ');
                TextBoxTelephoneNR.Text = OwnerList[0];
                TextBoxFirstName.Text = OwnerList[1];
                TextBoxLastName.Text = OwnerList[2];
                if (ApartmentCheck.Checked)
                {
                    TextBoxStreet.Text = Adresse[0];
                    TextBoxNr.Text = Adresse[1];
                    TextBoxFloor.Text = Adresse[2];
                }
                else
                {
                    TextBoxStreet.Text = Adresse[0];
                    TextBoxNr.Text = Adresse[1];
                    label5.Visible = true;
                    TextBoxFloor.Visible = true;
                }
                TextBoxEmail.Text = OwnerList[4];
                TextBoxCity.Text = OwnerList[5];
                TextBoxZipCode.Text = OwnerList[6];

                dataGridViewOwnerDyr.DataSource = Controller.ControllerShowAnimalDataTable(TextBoxTelephoneNR.Text);
            }
        }

        private void ButtonUpdateOwner_Click(object sender, EventArgs e)
        {
            if (TextBoxTelephoneNR.Text == "" || TextBoxFirstName.Text == "" || TextBoxLastName.Text == "" || TextBoxStreet.Text == "" || TextBoxNr.Text == "" || TextBoxEmail.Text == "" || TextBoxCity.Text == "" || TextBoxZipCode.Text == "")
            {
                MessageBox.Show("You are missing some blank spaces, fill them out please", "Error: Empty spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BusinessCheck.Checked)
            {
                Controller.ControllerUpdateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text+" " + TextBoxNr.Text+" " + TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
                Controller.ControllerUpdateBusiness(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxCompanyName.Text, Convert.ToInt32(TextBoxCVRNR.Text));
                MessageBox.Show("The Owner was updated Sucessfully", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else if(PrivateCheck.Checked)
            {
                Controller.ControllerUpdateOwner(Convert.ToInt32(TextBoxTelephoneNR.Text), TextBoxFirstName.Text, TextBoxLastName.Text, TextBoxStreet.Text + " "+TextBoxNr.Text +" "+TextBoxFloor.Text, TextBoxEmail.Text, TextBoxCity.Text, Convert.ToInt32(TextBoxZipCode.Text));
                MessageBox.Show("The Owner was updated Sucessfully", "Update Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void ButtonAddPet_Click(object sender, EventArgs e)
        {
            Form_Animal form = new Form_Animal();
            form.ShowDialog();
        }

        private void ButtonDeleteOwner_Click(object sender, EventArgs e)
        {
             MessageBox.Show("This funtion isn't implemented yet");
            //if (TextBoxTelephoneNR.Text== "")
            //{
            //    MessageBox.Show("You are missing some blank spaces, fill them out please", "error: Empty Spaces", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (PrivateCheck.Checked)
            //{
            //    Controller.ControllerDeleteOwner("Relation", "ejer", TextBoxTelephoneNR.Text);
            //    Controller.ControllerDeleteOwner("Private_", "ejer", TextBoxTelephoneNR.Text);
            //    Controller.ControllerDeleteOwner("ejer", "TelefonNr", TextBoxTelephoneNR.Text);
            //    MessageBox.Show("The Owner was removed Sucessfully", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //else if (BusinessCheck.Checked)
            //{
            //    Controller.ControllerDeleteOwner("Relation", "ejer", TextBoxTelephoneNR.Text);
            //    Controller.ControllerDeleteOwner("Erhverv", "ejer", TextBoxTelephoneNR.Text);
            //    Controller.ControllerDeleteOwner("ejer", "TelefonNr", TextBoxTelephoneNR.Text);
            //    MessageBox.Show("The Owner was removed Sucessfully", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
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

        private void ApartmentCheck_CheckChanged(object sender, EventArgs e)
        {
            if (ApartmentCheck.Checked)
            {
                label5.Visible = true;
                TextBoxFloor.Visible = true;
            }
            else if(!ApartmentCheck.Checked)
            {
                label5.Visible = false;
                TextBoxFloor.Visible = false;
            }
        }
        //Viggo
        private void ButtonHelpOwner_Click(object sender, EventArgs e)
        {
            FormHelp Help = new FormHelp();
            Help.HelpIndex = 3;
            Help.Show();
        }
    }
}
