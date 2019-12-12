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
    public partial class Form_Booking_Delete : Form
    {
        Contoller Controller = new Contoller();
        private string[,] BookingArray;

        public Form_Booking_Delete()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<string> TempBookningList = new List<string>();
            TempBookningList = Controller.ControllerGetBookning(textBoxBookingSearch.Text);

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

            BookingArray = new string[TempBookningList.Count / 9, 9];
            for (int i = 0; i < TempBookningList.Count / 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    BookingArray[i, j] = TempBookningList[(i * 9) + j];
                }
                comboBoxBookningChoice.Items.Add(Convert.ToDateTime(TempBookningList[(i * 9) + 6]).ToString("dd-MM-yyyy") + " " + Controller.ControllerGetAnimal(TempBookningList[(i * 9) + 3])[1]);
            }
            comboBoxBookningChoice.SelectedIndex = BookingArray.Length / 9 - 1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Controller.ControllerDeleteBookning(BookingArray[comboBoxBookningChoice.SelectedIndex,0]);
            MessageBox.Show("Bookning deleted", "sucess!", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
