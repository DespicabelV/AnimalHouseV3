using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseController;
using AnimalHouseTemp;

namespace AnimalHouseV3
{
    public partial class Form_Animal : Form
    {
        public Form_Animal()
        {
            InitializeComponent();
        }
        //Husk at ændre nedenunder
        AnimalHouseTemp.Controller Contemp = new Controller();


        private void btnAnimalCreate_Click(object sender, EventArgs e)
        {
            char Gender = 'T';
            if (CheckBoxFemale.Checked == false && CheckBoxMale.Checked == false)
            {
                MessageBox.Show("Choose gender");
                return;
            }
            
            if (CheckBoxFemale.Checked == true)
            {
                Gender = 'F';
            }
            else
            {
                Gender = 'M';
            }


            if (TxtAnimalName.Text == "" || TxtAnimal.Text == "" || TxtBoxAnimalDoctorNr.Text == "" || TxtBoxAnimalChip.Text == "" || TxtOwnerPhone.Text == "")
            {
                MessageBox.Show("Fill out the blanks");
            }
            else
            {
                Contemp.NewAnimal(TxtAnimalName.Text, Gender, Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"), TxtAnimal.Text, Convert.ToInt32(TxtBoxAnimalDoctorNr.Text), Convert.ToInt32(TxtBoxAnimalChip.Text));
                TxtBoxAnimalNr.Text = TxtBoxAnimalNr.Text + Contemp.FindDyrID(TxtAnimalName.Text, Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"), TxtAnimal.Text, Gender)[0];
                Contemp.AddRelation(Convert.ToInt32(TxtOwnerPhone.Text), Convert.ToInt32(TxtBoxAnimalNr.Text));
            }
        }

        private void CheckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxFemale.Checked == true)
            {
                CheckBoxMale.Enabled = false;
            }
            else CheckBoxMale.Enabled = true;
        }

        private void CheckBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxMale.Checked == true)
            {
                CheckBoxFemale.Enabled = false;
            }
            else CheckBoxFemale.Enabled = true;
        }

        private void btnCheckOwner_Click(object sender, EventArgs e)
        {
            if (Contemp.CheckAnimalOwner("Ejer", "TelefonNr", TxtOwnerPhone.Text) == true)
            {
                CheckOwnerRight.Checked = true;
                CheckOwnerWrong.Checked = false; 
            }
            else
            {
                CheckOwnerWrong.Checked = true;
                CheckOwnerRight.Checked = false;
            }
            
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Contemp.CheckIfAnimalExist("Dyr", "ID", TxtBoxAnimalNr.Text) == false)
            {
                MessageBox.Show("Animal doesn't exist");
            }
            else
            {
                TxtAnimalName.Text = Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[1];
                if (Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[2] == "F")
                {
                    CheckBoxMale.Checked = false;
                    CheckBoxFemale.Checked = true;
                    CheckBoxMale.Enabled = false;
                }
                else
                {
                    CheckBoxFemale.Checked = false;
                    CheckBoxMale.Checked = true;
                    CheckBoxFemale.Enabled = false;
                }
                AnimalBirthCalender.Value = Convert.ToDateTime(Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[3]);
                TxtAnimal.Text = Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[4];
                TxtBoxAnimalDoctorNr.Text = Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[5];
                TxtBoxAnimalChip.Text = Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[6];
            }


        }
    }   
}
