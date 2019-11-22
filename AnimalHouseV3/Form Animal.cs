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

namespace AnimalHouseV3
{
    public partial class Form_Animal : Form
    {
        public Form_Animal()
        {
            InitializeComponent();
        }
        AnimalHouseController.Contoller controller;
        private void btnAnimalCreate_Click(object sender, EventArgs e)
        {
            char Gender = 'T';
            char CheckGender()
            {
                
                if (CheckBoxFemale.Checked == false || CheckBoxMale.Checked == false)
                {
                    MessageBox.Show("Choose gender");
                }
                else if (CheckBoxFemale.Checked == true)
                {
                    return Gender = 'F';
                }
                else if (CheckBoxMale.Checked == true)
                {
                    return Gender = 'M';
                }
                return Gender;
            }            

            if (TxtAnimalName.Text=="" || TxtAnimalRace.Text == "" || TxtBoxAnimalDoctorNr.Text=="" || TxtBoxAnimalChip.Text=="")
            {
                MessageBox.Show("Fill out the blanks");
            }            
            else
            {
                MessageBox.Show(AnimalBirthCalender.Value.ToShortDateString().ToString());               
                
                controller.NewAnimal(TxtAnimalName.Text, Gender, AnimalBirthCalender.Value, TxtAnimalRace.Text, Convert.ToInt32(TxtBoxAnimalDoctorNr.Text), Convert.ToInt32(TxtBoxAnimalChip.Text));
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
