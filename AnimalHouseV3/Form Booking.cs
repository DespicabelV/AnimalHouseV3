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
        public Form_Booking()
        {
            InitializeComponent();
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
            int RelationItemCount;

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
            RelationItemCount = TempRelationList.Count;
            for (int i = 0; i < RelationItemCount; i = i + 2)
            {
                comboBoxAnimalChoice.Items.Add(TempRelationList[i+1]);
            }

        }

        private void comboBoxAnimalChoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
