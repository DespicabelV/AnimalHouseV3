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
        private string[,] TimeArray;
        private string[,] CageArray;
        private string[,] BookingArray;
        private bool SearchCheck, TimeCheck;

        public Form_Booking()
        {
            InitializeComponent();

            List<string> TreatmentList = Controller.ControllerGetAllTreatment();
            List<string> DoctorList = Controller.ControllerGetAllDoctor();
            List<string> CageList = Controller.ControllerGetCage();

            DoctorArray = new string[DoctorList.Count / 2, 2];
            for (int i = 0; i < DoctorList.Count / 2; i++)
            {
                DoctorArray[i, 0] = DoctorList[(i * 2)];
                DoctorArray[i, 1] = DoctorList[(i * 2) + 1];
                comboBoxDoctorChoice.Items.Add(DoctorList[(i * 2) + 1]);
            }
            comboBoxDoctorChoice.SelectedIndex = 0;

            TreatmentArray = new string[TreatmentList.Count / 2, 2];
            for (int i = 0; i < TreatmentList.Count / 2; i++)
            {
                TreatmentArray[i, 0] = TreatmentList[(i * 2)];
                TreatmentArray[i, 1] = TreatmentList[(i * 2) + 1];
                comboBoxTreatmentsChoice.Items.Add(TreatmentList[(i * 2) + 1]);
            }
            comboBoxTreatmentsChoice.SelectedIndex = 0;

            CageArray = new string[CageList.Count / 2, 2];
            for (int i = 0; i < CageList.Count / 2; i++)
            {
                CageArray[i, 0] = CageList[(i * 2)];
                CageArray[i, 1] = CageList[(i * 2) + 1];
                comboBoxCageChoice.Items.Add(CageList[(i * 2)] + " " + CageList[(i * 2 + 1)]);
            }
            comboBoxCageChoice.SelectedIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                comboBoxDaysChoice.Items.Add(i);
            }
            comboBoxDaysChoice.SelectedIndex = 0;
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
            comboBoxAnimalChoice.Items.Clear();

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
            textBoxOwnerPhoneInfo.Text = TempOwnerList[0];
            textBoxOwnerNameInfo.Text = TempOwnerList[1] + " " + TempOwnerList[2];
            textBoxOwnerStreetInfo.Text = TempOwnerList[3];
            textBoxOwnerEmailInfo.Text = TempOwnerList[4];
            textBoxOwnerCityInfo.Text = TempOwnerList[5];
            textBoxOwnerZipInfo.Text = TempOwnerList[6];

            TempRelationList = Controller.ControllerGetRelation(textBoxOwnerInput.Text);

            AnimalArray = new string[TempRelationList.Count / 2, 7];
            for (int i = 0; i < TempRelationList.Count / 2; i++)
            {
                TempAnimalList = Controller.ControllerGetAnimal(TempRelationList[(i * 2) + 1]);
                for (int j = 0; j < 7; j++)
                {
                    AnimalArray[i, j] = TempAnimalList[j];
                }
                comboBoxAnimalChoice.Items.Add(AnimalArray[i, 1]);
            }
            comboBoxAnimalChoice.SelectedIndex = 0;
            SearchCheck = true;
        }

        private void comboBoxAnimalChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> TempAnimalList = new List<string>();
            TempAnimalList = Controller.ControllerGetAnimal(AnimalArray[comboBoxAnimalChoice.SelectedIndex, 0]);

            textBoxAnimalIDInfo.Text = TempAnimalList[0];
            textBoxAnimalNameInfo.Text = TempAnimalList[1];
            textBoxAnimalGenderInfo.Text = TempAnimalList[2];
            textBoxAnimalBDayInfo.Text = Convert.ToDateTime(TempAnimalList[3]).ToString("dd-MM-yyyy");
            textBoxAnimalRaceInfo.Text = TempAnimalList[4];
            textBoxAnimalDoctorInfo.Text = DoctorArray[Convert.ToInt32(TempAnimalList[5]) - 1, 1];
            textBoxAnimalChipInfo.Text = TempAnimalList[6];
            comboBoxDoctorChoice.SelectedIndex = Convert.ToInt32(TempAnimalList[5]);
        }

        private void checkBoxCage_CheckedChanged(object sender, EventArgs e)
        {
            if (labelDays.Visible == true && comboBoxDaysChoice.Visible == true)
            {
                labelDays.Visible = false;
                labelCageChoice.Visible = false;
                comboBoxDaysChoice.Visible = false;
                comboBoxCageChoice.Visible = false;
            }
            else
            {
                labelDays.Visible = true;
                labelCageChoice.Visible = true;
                comboBoxDaysChoice.Visible = true;
                comboBoxCageChoice.Visible = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Form_Booking_Delete Delete = new Form_Booking_Delete();
            Delete.ShowDialog();
        }

        private void buttonTimeSearch_Click(object sender, EventArgs e)
        {
            List<string> TempBookedTimeList, TempTimeList;

            TempBookedTimeList = Controller.ControllerGetBookedTime(Convert.ToDateTime(dateTimePickerDate.Value).ToString("yyyy-MM-dd"), DoctorArray[comboBoxDoctorChoice.SelectedIndex,0]);
            TempTimeList = Controller.ControllerGetTime();

            TimeArray = new string[TempTimeList.Count / 2, 2];
            if (TempBookedTimeList.Count >= 1)
            {
                for (int i = 0; i < TempBookedTimeList.Count / 2; i++)
                {
                    for (int j = 0; j < TempTimeList.Count / 2; j++)
                    {
                        if (TempTimeList[(j * 2)] == TempBookedTimeList[(i * 2) + 1])
                        {
                            TempTimeList.RemoveAt((j * 2));
                            TempTimeList.RemoveAt((j * 2));
                        }
                    }
                }
            }

            for (int i = 0; i < TempTimeList.Count/2; i++)
            {
                TimeArray[i, 0] = TempTimeList[(i * 2)];
                TimeArray[i, 1] = TempTimeList[(i * 2) + 1];
                comboBoxTimeChoice.Items.Add(TimeArray[i, 1]);
            }
            comboBoxTimeChoice.SelectedIndex = 0;
            TimeCheck = true;
        }

        private void comboBoxTreatmentsChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDoctorChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonBookningSearch_Click(object sender, EventArgs e)
        {
            if (textBoxBookingSearch.TextLength == 0)
            {
                MessageBox.Show("Please put in a phone number for the owner");
                return;
            }
            if (Controller.ControllerOwnerExist(textBoxBookingSearch.Text) == false)
            {
                MessageBox.Show("No owner exist under that phone number");
                return;
            }

            List<string> TempBookningList = new List<string>();
            List<string> TempRelationList = new List<string>();
            List<string> TempAnimalList = new List<string>();
            TempBookningList = Controller.ControllerGetBookning(textBoxBookingSearch.Text);
            TempRelationList = Controller.ControllerGetRelation(textBoxBookingSearch.Text);

            AnimalArray = new string[TempRelationList.Count / 2, 7];
            for (int i = 0; i < TempRelationList.Count / 2; i++)
            {
                TempAnimalList = Controller.ControllerGetAnimal(TempRelationList[(i * 2) + 1]);
                for (int j = 0; j < 7; j++)
                {
                    AnimalArray[i, j] = TempAnimalList[j];
                }
            }


            BookingArray = new string[TempBookningList.Count / 9, 9];
            for (int i = 0; i < TempBookningList.Count / 9; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    BookingArray[i, j] = TempBookningList[(i * 9) + j];  //Convert.ToDateTime(TempAnimalList[3]).ToString("dd-MM-yyyy")
                }
                comboBoxBookningChoice.Items.Add(Convert.ToDateTime(TempBookningList[(i * 9) + 6]).ToString("dd-MM-yyyy") + " " + AnimalArray[Convert.ToInt32(TempBookningList[(i * 9) + 3]),1]);
            }
            comboBoxBookningChoice.SelectedIndex = BookingArray.Length/9 - 1;
        }


        private void comboBoxBookningChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> TempOwnerList = new List<string>();
            List<string> TempAnimalList = new List<string>();
            //DONT WORK DOWN!
            //TempAnimalList = Controller.ControllerGetAnimal(AnimalArray[.SelectedIndex, 0]);


            TempOwnerList = Controller.ControllerGetOwner(textBoxBookingSearch.Text);
            textBoxOwnerPhoneInfo.Text = TempOwnerList[0];
            textBoxOwnerNameInfo.Text = TempOwnerList[1] + " " + TempOwnerList[2];
            textBoxOwnerStreetInfo.Text = TempOwnerList[3];
            textBoxOwnerEmailInfo.Text = TempOwnerList[4];
            textBoxOwnerCityInfo.Text = TempOwnerList[5];
            textBoxOwnerZipInfo.Text = TempOwnerList[6];

            textBoxAnimalIDInfo.Text = TempAnimalList[0];
            textBoxAnimalNameInfo.Text = TempAnimalList[1];
            textBoxAnimalGenderInfo.Text = TempAnimalList[2];
            textBoxAnimalBDayInfo.Text = Convert.ToDateTime(TempAnimalList[3]).ToString("dd-MM-yyyy");
            textBoxAnimalRaceInfo.Text = TempAnimalList[4];
            textBoxAnimalDoctorInfo.Text = DoctorArray[Convert.ToInt32(TempAnimalList[5]) - 1, 1];
            textBoxAnimalChipInfo.Text = TempAnimalList[6];
            comboBoxDoctorChoice.SelectedIndex = Convert.ToInt32(TempAnimalList[5]);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (SearchCheck != true || TimeCheck != true)
            {
                MessageBox.Show("Please select a owner and a time before booking", "Error", MessageBoxButtons.OK);
                return;
            }

            int CageID;
            if (checkBoxCage.Checked)
            {
                CageID = Convert.ToInt32(CageArray[comboBoxCageChoice.SelectedIndex, 0]);
            }
            else
            {
                CageID = 110;
            }

            Controller.ControllerAddBookning(
                Convert.ToInt32(TreatmentArray[comboBoxTreatmentsChoice.SelectedIndex, 0]),
                Convert.ToInt32(DoctorArray[comboBoxDoctorChoice.SelectedIndex, 0]),
                Convert.ToInt32(AnimalArray[comboBoxAnimalChoice.SelectedIndex, 0]),
                CageID,
                Convert.ToInt32(comboBoxDaysChoice.Text),
                Convert.ToDateTime(dateTimePickerDate.Value).ToString("yyyy-MM-dd"),
                Convert.ToInt32(TimeArray[comboBoxTimeChoice.SelectedIndex, 0]),
                Convert.ToInt32(textBoxOwnerInput.Text));
            MessageBox.Show("Bookning created","sucess!",MessageBoxButtons.OK);
            this.Close();
        }
    }
}
