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
//TEMP!
using AnimalHouseTemp;
//TEMP END

namespace AnimalHouseV3
{
    public partial class Form_Booking : Form
    {
        //TEMP
        ViggoTemp Controller = new ViggoTemp();
        //TEMP END
        
        private string[,] DoctorArray;
        private string[,] TreatmentArray;
        private string[,] AnimalArray;

        public Form_Booking()
        {
            InitializeComponent();

            List<string> TreatmentList = Controller.ControllerGetAllTreatment();
            List<string> DoctorList = Controller.ControllerGetAllDoctor();
            
            DoctorArray      = new string[DoctorList.Count / 2, 2];
            for (int i = 0; i < DoctorList.Count/2; i++)
            {
                DoctorArray[i, 0] = DoctorList[i];
                DoctorArray[i, 1] = DoctorList[i+1];
                comboBoxDoctorChoice.Items.Add(DoctorList[i + 1]);
            }

            TreatmentArray = new string[TreatmentList.Count / 2, 2];
            for (int i = 0; i < TreatmentList.Count / 2; i++)
            {
                TreatmentArray[i, 0] = TreatmentList[i];
                TreatmentArray[i, 1] = TreatmentList[i + 1];
                comboBoxTreatmentsChoice.Items.Add(TreatmentList[i + 1]);
            }

        }

        private void buttonAddOwner_Click(object sender, EventArgs e)
        {
            Form_Owner Owner = new Form_Owner();
            Owner.ShowDialog();
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            Form_Animal Animal = new Form_Animal();
            Animal.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<string> TempOwnerList = new List<string>();
            List<string> TempRelationList = new List<string>();
            List<string> TempAnimalList = new List<string>();

            if (textBoxOwnerInput.TextLength == 0)
            {
                MessageBox.Show("Please put in a phone number for the owner");
                return;
            }
            if (Controller.ControllerOwnerExist(textBoxOwnerInput.Text) == false)
            {
                MessageBox.Show("No owner exist under that phone number");
                return;
            }

            TempOwnerList = Controller.ControllerGetOwner(textBoxOwnerInput.Text);
            textBoxOwnerPhoneInfo.Text  = TempOwnerList[0];
            textBoxOwnerNameInfo.Text   = TempOwnerList[1] + " " + TempOwnerList[2];
            textBoxOwnerStreetInfo.Text = TempOwnerList[3];
            textBoxOwnerEmailInfo.Text  = TempOwnerList[4];
            textBoxOwnerCityInfo.Text   = TempOwnerList[5];
            textBoxOwnerZipInfo.Text    = TempOwnerList[6];

            TempRelationList = Controller.ControllerGetRelation(textBoxOwnerInput.Text);
            AnimalArray = new string[TempRelationList.Count / 2 , 7];


            for (int i = 0; i < TempRelationList.Count; i = i++)
            {
                TempAnimalList = Controller.ControllerGetAnimal(TempRelationList[i+1]);
                for (int j = 0; j < 7; j++)
                {
                    AnimalArray[i, j] = TempAnimalList[j];
                }
                comboBoxAnimalChoice.Items.Add(AnimalArray[i,1]);
            }

        }

        private void comboBoxAnimalChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> TempAnimalList = new List<string>();

            TempAnimalList = Controller.ControllerGetAnimal(comboBoxAnimalChoice.Text);

            textBoxAnimalIDInfo.Text     = TempAnimalList[0];
            textBoxAnimalNameInfo.Text   = TempAnimalList[1];
            textBoxAnimalGenderInfo.Text = TempAnimalList[2];
            textBoxAnimalBDayInfo.Text   = TempAnimalList[3];
            textBoxAnimalRaceInfo.Text   = TempAnimalList[4];
            textBoxAnimalDoctorInfo.Text = DoctorArray[1,Convert.ToInt32(TempAnimalList[5])-1];
            textBoxAnimalChipInfo.Text   = TempAnimalList[6];
        }
    }
}
