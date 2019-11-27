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


            if (TxtAnimalName.Text == "" || TxtAnimalRace.Text == "" || TxtBoxAnimalDoctorNr.Text == "" || TxtBoxAnimalChip.Text == "")
            {
                MessageBox.Show("Fill out the blanks");
            }
            else
            {
                string hej  = AnimalBirthCalender.ToString();
                Contemp.NewAnimal(TxtAnimalName.Text, Gender, Convert.ToDateTime(AnimalBirthCalender.Value).ToString("yyyy-MM-dd"), TxtAnimalRace.Text, Convert.ToInt32(TxtBoxAnimalDoctorNr.Text), Convert.ToInt32(TxtBoxAnimalChip.Text));
                MessageBox.Show("fandme ikk passe");
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
    }
}
