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
    public partial class FormBooking : Form
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

        public FormBooking()
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
            comboBoxTimeChoice.Items.Clear();
            comboBoxTimeChoice.Text = "";

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
            
            if (buttonUpdate.Visible == true)
            {
                buttonUpdate.Visible = false;
                buttonCreate.Visible = true;
            }
            else
            {
                buttonCreate.Visible = true;
            }
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
            comboBoxTimeChoice.Items.Clear();

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
            FormHelp Help = new FormHelp();
            Help.HelpIndex = 1;
            Help.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int CageID, CageDays;
            if (checkBoxCage.Checked)
            {
                CageID = Convert.ToInt32(CageArray[comboBoxCageChoice.SelectedIndex, 0]);
                CageDays = Convert.ToInt32(comboBoxDaysChoice.Text);
            }
            else
            {
                CageID = 110;
                CageDays = 0;
            }

            Controller.ControllerUpdateBookning(
                Convert.ToInt32(TreatmentArray[comboBoxTreatmentsChoice.SelectedIndex, 0]),
                Convert.ToInt32(DoctorArray[comboBoxDoctorChoice.SelectedIndex, 0]),
                Convert.ToInt32(BookingArray[comboBoxBookningChoice.SelectedIndex,0]),
                CageID,
                CageDays,
                Convert.ToDateTime(dateTimePickerDate.Value).ToString("yyyy-MM-dd"),
                Convert.ToInt32(TimeArray[comboBoxTimeChoice.SelectedIndex, 0]));

            MessageBox.Show("Bookning Updated", "sucess!", MessageBoxButtons.OK);
            this.Close();
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
                for (int j = 0; j < 9; j++)
                {
                    BookingArray[i, j] = TempBookningList[(i * 9) + j];
                }
                comboBoxBookningChoice.Items.Add(Convert.ToDateTime(TempBookningList[(i * 9) + 6]).ToString("dd-MM-yyyy") + " " + Controller.ControllerGetAnimal(TempBookningList[(i * 9) + 3])[1]);
            }
            comboBoxBookningChoice.SelectedIndex = BookingArray.Length/9 - 1;

            if (buttonCreate.Visible == true)
            {
                buttonCreate.Visible = false;
                buttonUpdate.Visible = true;
            }
            else
            {
                buttonUpdate.Visible = true;
            }
        }

        private void comboBoxBookningChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTimeChoice.Items.Clear();
            int TempTreatmentIndex  = 0;
            int TempCageIndex       = 0;
            List<string> TempOwnerList = new List<string>();
            List<string> TempAnimalList = new List<string>();
            List<string> TempTimeList = new List<string>();
            TimeArray = new string[1, 2];
            TempAnimalList = Controller.ControllerGetAnimal(BookingArray[comboBoxBookningChoice.SelectedIndex,3]);
            TempTimeList = Controller.ControllerGetTime();

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


            for (int i = 0; i < TreatmentArray.Length / 2; i++)
            {
                if (TreatmentArray[i,0] == BookingArray[comboBoxBookningChoice.SelectedIndex, 1])
                {
                    break;
                }
                TempTreatmentIndex++;
            }

            comboBoxTreatmentsChoice.SelectedIndex  = TempTreatmentIndex;
            comboBoxDoctorChoice.SelectedIndex      = Convert.ToInt32(BookingArray[comboBoxBookningChoice.SelectedIndex, 2])-1;
            dateTimePickerDate.Value                = Convert.ToDateTime(BookingArray[comboBoxBookningChoice.SelectedIndex, 6]);
            
            comboBoxTimeChoice.Items.Add(TempTimeList[(Convert.ToInt32(BookingArray[comboBoxBookningChoice.SelectedIndex,7]) * 2) +1]);
            TimeArray[0, 0] = TempTimeList[(Convert.ToInt32(BookingArray[comboBoxBookningChoice.SelectedIndex, 7]) * 2)];
            TimeArray[0, 1] = TempTimeList[(Convert.ToInt32(BookingArray[comboBoxBookningChoice.SelectedIndex, 7]) * 2) + 1];
            comboBoxTimeChoice.SelectedIndex = 0;

            if (BookingArray[comboBoxBookningChoice.SelectedIndex, 4] == "110")
            {
                checkBoxCage.Checked = false;
            }
            else
            {
                checkBoxCage.Checked = true;
                comboBoxDaysChoice.SelectedIndex = Convert.ToInt32(BookingArray[comboBoxBookningChoice.SelectedIndex, 5]);

                for (int i = 0; i < CageArray.Length / 2; i++)
                {
                    if (CageArray[i, 0] == BookingArray[comboBoxBookningChoice.SelectedIndex, 4])
                    {
                        break;
                    }
                    TempCageIndex++;
                }
                comboBoxCageChoice.SelectedIndex = TempCageIndex;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (SearchCheck != true || TimeCheck != true)
            {
                MessageBox.Show("Please select a owner and a time before booking", "Error", MessageBoxButtons.OK);
                return;
            }

            int CageID, CageDays;
            if (checkBoxCage.Checked)
            {
                CageID = Convert.ToInt32(CageArray[comboBoxCageChoice.SelectedIndex, 0]);
                CageDays = Convert.ToInt32(comboBoxDaysChoice.Text);
            }
            else
            {
                CageID = 110;
                CageDays = 0;
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
            MessageBox.Show("Bookning created","Sucess!",MessageBoxButtons.OK);
            this.Close();
        }
    }
}
