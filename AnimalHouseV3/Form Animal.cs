using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalHouseV3
{
    public partial class Form_Animal : Form
    {
        public Form_Animal()
        {
            InitializeComponent();
        }

        private void Form_Animal_Load(object sender, EventArgs e)
        {

        }

        private void TxtDyrBirthday_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnimalCreate_Click(object sender, EventArgs e)
        {
            if (TxtAnimalName.Text==""||TxtAnimalRace.Text==""||AnimalBirthCalender.Value==null|| TxtBoxAnimalNr.Text==""||TxtOwnerName.Text==""||TxtBoxAnimalDoctorName.Text==""||TxtBoxAnimalChip.Text=="")
            {
                MessageBox.Show("Fill out the blanks");
            }
            else
            {
                //Insert(TxtAnimalName.Text, TxtAnimalRace.Text, AnimalBirthCalender.Value, Convert.ToInt32(TxtBoxAnimalNr.Text), TxtOwnerName.Text, TxtBoxAnimalDoctorName.Text, Convert.ToInt32(TxtBoxAnimalChip.Text));
            }
        }
    }
}
