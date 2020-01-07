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
        //Allan

        private string[,] DoctorArray;

        public Form_Animal()
        {
            Contoller Controller = new Contoller();

            InitializeComponent();

            List<string> DoctorList = Controller.ControllerFindAllDoctor();

            DoctorArray = new string[DoctorList.Count / 2, 2];
            for (int i = 0; i < DoctorList.Count / 2; i++)  
            {
                DoctorArray[i, 0] = DoctorList[(i * 2)];
                DoctorArray[i, 1] = DoctorList[(i * 2) + 1];
                DoctorComboBox.Items.Add(DoctorList[(i * 2) + 1]);
            }
        }
        
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

        private void buttonAnimalCreate_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            if (TextAnimalName.Text == "" || TextAnimal.Text == "" || DoctorComboBox.Text == "" || TextBoxAnimalChip.Text == "" || TextOwnerPhone.Text == "")
            {
                MessageBox.Show("Fill out the blanks");
            }
            else
            {
                Controller.ControllerNewAnimal(TextAnimalName.Text, Gender(), Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"),
                    TextAnimal.Text, Convert.ToInt32(DoctorArray[DoctorComboBox.SelectedIndex,0]), Convert.ToInt32(TextBoxAnimalChip.Text));
                TextBoxAnimalNr.Text = Controller.ControllerFindAnimalID(TextAnimalName.Text, Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"),
                    TextAnimal.Text, Gender())[0];
                Controller.ControllerAddRelation(Convert.ToInt32(TextOwnerPhone.Text), Convert.ToInt32(TextBoxAnimalNr.Text));
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();

            if (Controller.ControllerCheckIfAnimalExist(TextBoxAnimalNr.Text) == false)
            {
                MessageBox.Show("Animal doesn't exist");
            }
            else
            {
                List<string> DoctorList = Controller.ControllerFindAllDoctor();
                TextAnimalName.Text = Controller.ControllerSearchAnimal(TextBoxAnimalNr.Text)[1];
                if (Controller.ControllerSearchAnimal(TextBoxAnimalNr.Text)[2] == "F")
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
                AnimalBirthCalender.Value = Convert.ToDateTime(Controller.ControllerSearchAnimal(TextBoxAnimalNr.Text)[3]);
                TextAnimal.Text = Controller.ControllerSearchAnimal(TextBoxAnimalNr.Text)[4];
                DoctorComboBox.Text = Controller.ControllerGetDoctorName(TextBoxAnimalNr.Text);
                TextBoxAnimalChip.Text = Controller.ControllerSearchAnimal(TextBoxAnimalNr.Text)[6];
            }
        }

        private void buttonAnimalUpdate_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            Controller.ControllerUpdateAnimal(Convert.ToInt32(TextBoxAnimalNr.Text), TextAnimalName.Text, Gender(), Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"), TextAnimal.Text, Convert.ToInt32(DoctorArray[DoctorComboBox.SelectedIndex,0]), Convert.ToInt32(TextBoxAnimalChip.Text));
        }

        private void buttonAnimalDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This funtion isn't implemented yet");
            //Contoller Controller = new Contoller();
            //Controller.ControllerDeleteRelation(TextBoxAnimalNr.Text);
            //Controller.ControllerDeleteAnimal(TextBoxAnimalNr.Text);
        }

        private void buttonAnimalUploadPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Picture is uploaded");
        }
        
        private void buttonJournal_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            Controller.ControllerAddJournal(Convert.ToInt32(DoctorArray[DoctorComboBox.SelectedIndex,0]), Convert.ToInt32(TextBoxAnimalNr.Text), Convert.ToDateTime(JournalCalender.Value).ToString("yyyy-MM-dd"), TextJournalTitle.Text, TextBoxJournal.Text);
        }

        private void buttonShowJournal_Click(object sender, EventArgs e)
        {
            AnimalJournal Journal = new AnimalJournal();
            Journal.ShowDialog();
        }

        private void ButtonCheckOwner_Click_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            if (Controller.ControllerCheckAnimalOwner(TextOwnerPhone.Text) == true)
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

        //viggo
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp Help = new FormHelp();
            Help.HelpIndex = 1;
            Help.Show();
        }
    }   
}
