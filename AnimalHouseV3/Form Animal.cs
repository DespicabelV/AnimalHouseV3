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
using AnimalHouseV3.Properties;

namespace AnimalHouseV3
{
    public partial class Form_Animal : Form
    {

        AnimalHouseTemp.Controller Contemp = new Controller();
        private string[,] DoctorArray;
        public Form_Animal()
        {
            AnimalHouseTemp.Controller Contemp = new Controller();

            InitializeComponent();

            List<string> DoctorList = Contemp.FindAllDoctor();

            DoctorArray = new string[DoctorList.Count/2,2];
            for (int i = 0; i < DoctorList.Count / 2; i++) 
            {
                DoctorArray[i, 0] = DoctorList[(i * 2)];
                DoctorArray[i, 1] = DoctorList[(i * 2) + 1];
                DoctorComboBox.Items.Add(DoctorList[(i * 2) + 1]);
            }
        }
        //Husk at ændre nedenunder
        
        private char Gender()
        {
            AnimalHouseTemp.Controller Contemp = new Controller();
            char Gender = 'T';
            if (CheckBoxFemale.Checked == false && CheckBoxMale.Checked == false)
            {
                MessageBox.Show("Choose gender");                
            }

            if (CheckBoxFemale.Checked == true)
            {
                Gender = 'F';
            }
            else
            {
                Gender = 'M';
            }
            return Gender;
        }

        private void btnAnimalCreate_Click(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();

            if (TxtAnimalName.Text == "" || TxtAnimal.Text == "" || DoctorComboBox.Text == "" || TxtBoxAnimalChip.Text == "" || TxtOwnerPhone.Text == "")
            {
                MessageBox.Show("Fill out the blanks");
            }
            else
            {
                Contemp.NewAnimal(TxtAnimalName.Text, Gender(), Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"),
                    TxtAnimal.Text, Convert.ToInt32(DoctorComboBox.Text), Convert.ToInt32(TxtBoxAnimalChip.Text));
                TxtBoxAnimalNr.Text = Contemp.FindDyrID(TxtAnimalName.Text, Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"),
                    TxtAnimal.Text, Gender())[0];
                Contemp.AddRelation(Convert.ToInt32(TxtOwnerPhone.Text), Convert.ToInt32(TxtBoxAnimalNr.Text));
            }
        }

        private void CheckBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();

            if (CheckBoxFemale.Checked == true)
            {
                CheckBoxMale.Enabled = false;
            }
            else CheckBoxMale.Enabled = true;
        }

        private void CheckBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();

            if (CheckBoxMale.Checked == true)
            {
                CheckBoxFemale.Enabled = false;
            }
            else CheckBoxFemale.Enabled = true;
        }

        private void btnCheckOwner_Click(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();
            if (TxtOwnerPhone.Text =="")
            {
                MessageBox.Show("Fill the blank");
            }
            else
            if (Contemp.CheckAnimalOwner(TxtOwnerPhone.Text) == true)
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
            AnimalHouseTemp.Controller Contemp = new Controller();

            if (Contemp.CheckIfAnimalExist(TxtBoxAnimalNr.Text) == false)
            {
                MessageBox.Show("Animal doesn't exist");
            }
            else
            {
                List<string> DoctorList = Contemp.FindAllDoctor();

                
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
                DoctorComboBox.Text = Contemp.GetDoctorName(TxtBoxAnimalNr.Text);
                TxtBoxAnimalChip.Text = Contemp.SearchAnimal(TxtBoxAnimalNr.Text)[6];
            }
        }

        private void btnAnimalUpdate_Click(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();

            Contemp.UpdateAnimal(Convert.ToInt32(TxtBoxAnimalNr.Text), TxtAnimalName.Text, Gender(), Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"), TxtAnimal.Text, Convert.ToInt32(DoctorComboBox.Text), Convert.ToInt32(TxtBoxAnimalChip.Text));
        }

        private void btnAnimalDelete_Click(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();
            Contemp.DeleteRelation(TxtBoxAnimalNr.Text);
            Contemp.DeleteAnimal(TxtBoxAnimalNr.Text);
        }

        private void btnAnimalUploadPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture is uploaded");
        }
        
        private void btnJournal_Click(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new Controller();
            Contemp.AddJournal(Convert.ToInt32(DoctorComboBox.Text), Convert.ToInt32(TxtBoxAnimalNr.Text), Convert.ToDateTime(JournalCalender.Value).ToString("yyyy-MM-dd"), TxtJournalTitle.Text, TextBoxJournal.Text);
        }

        //ikke færdig
        private void buttonHelp_Click(object sender, EventArgs e)
        {
        //    PictureBox Help = new PictureBox();
        //    Help.Image = Resources.Labrador_edit;
        //    Help.Show();
        }

        private void btnShowJournal_Click(object sender, EventArgs e)
        {
            AnimalJournal Journal = new AnimalJournal();
            Journal.ShowDialog();
        }
    }   
}
