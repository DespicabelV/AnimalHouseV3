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
using AnimalHouseV3.Properties;

namespace AnimalHouseV3
{
    public partial class Form_Animal : Form
    {

        private string[,] DoctorArray; // array bliver lavet
        public Form_Animal()
        {
            Contoller Controller = new Contoller();

            InitializeComponent();

            List<string> DoctorList = Controller.ControllerFindAllDoctor(); // ny list bliver lavet. FindAllDoctor er også en list. FindAllDoctorList finder 12 læger

            DoctorArray = new string[DoctorList.Count / 2, 2]; // list bliver instatireret og array er lige med ny instans af list. FindAllDoctorList bliver halveret. 
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
            Contoller Controller = new Contoller();

            if (TxtAnimalName.Text == "" || TxtAnimal.Text == "" || DoctorComboBox.Text == "" || TxtBoxAnimalChip.Text == "" || TxtOwnerPhone.Text == "")
            {
                MessageBox.Show("Fill out the blanks");
            }
            else
            {
                Controller.ControllerNewAnimal(TxtAnimalName.Text, Gender(), Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"),
                    TxtAnimal.Text, Convert.ToInt32(DoctorArray[DoctorComboBox.SelectedIndex,0]), Convert.ToInt32(TxtBoxAnimalChip.Text));
                TxtBoxAnimalNr.Text = Controller.ControllerFindAnimalID(TxtAnimalName.Text, Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"),
                    TxtAnimal.Text, Gender())[0];
                Controller.ControllerAddRelation(Convert.ToInt32(TxtOwnerPhone.Text), Convert.ToInt32(TxtBoxAnimalNr.Text));
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();

            if (Controller.ControllerCheckIfAnimalExist(TxtBoxAnimalNr.Text) == false)
            {
                MessageBox.Show("Animal doesn't exist");
            }
            else
            {
                List<string> DoctorList = Controller.ControllerFindAllDoctor();

                
                TxtAnimalName.Text = Controller.ControllerSearchAnimal(TxtBoxAnimalNr.Text)[1];
                if (Controller.ControllerSearchAnimal(TxtBoxAnimalNr.Text)[2] == "F")
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
                AnimalBirthCalender.Value = Convert.ToDateTime(Controller.ControllerSearchAnimal(TxtBoxAnimalNr.Text)[3]);
                TxtAnimal.Text = Controller.ControllerSearchAnimal(TxtBoxAnimalNr.Text)[4];
                DoctorComboBox.Text = Controller.ControllerGetDoctorName(TxtBoxAnimalNr.Text);
                TxtBoxAnimalChip.Text = Controller.ControllerSearchAnimal(TxtBoxAnimalNr.Text)[6];
            }
        }

        private void btnAnimalUpdate_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();

            Controller.ControllerUpdateAnimal(Convert.ToInt32(TxtBoxAnimalNr.Text), TxtAnimalName.Text, Gender(), Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"), TxtAnimal.Text, Convert.ToInt32(DoctorArray[DoctorComboBox.SelectedIndex,0]), Convert.ToInt32(TxtBoxAnimalChip.Text));
        }

        private void btnAnimalDelete_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            Controller.ControllerDeleteRelation(TxtBoxAnimalNr.Text);
            Controller.ControllerDeleteAnimal(TxtBoxAnimalNr.Text);
        }

        private void btnAnimalUploadPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture is uploaded");
        }
        
        private void btnJournal_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            Controller.ControllerAddJournal(Convert.ToInt32(DoctorArray[DoctorComboBox.SelectedIndex,0]), Convert.ToInt32(TxtBoxAnimalNr.Text), Convert.ToDateTime(JournalCalender.Value).ToString("yyyy-MM-dd"), TxtJournalTitle.Text, TextBoxJournal.Text);
        }

        private void btnShowJournal_Click(object sender, EventArgs e)
        {
            AnimalJournal Journal = new AnimalJournal();
            Journal.ShowDialog();
        }

        private void ButtonCheckOwner_Click_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            if (Controller.ControllerCheckAnimalOwner(TxtOwnerPhone.Text) == true)
            {
                CheckOwnerWrong.Checked = false;
                CheckOwnerRight.Checked = true;
            }
            else
            {
                CheckOwnerRight.Checked = false;
                CheckOwnerWrong.Checked = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp Help = new FormHelp();
            Help.HelpIndex = 1;
            Help.Show();
        }
    }   
}
