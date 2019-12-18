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
    public partial class FormHelp : Form
    {
        public int HelpIndex = 0;
        public FormHelp()
        {
            InitializeComponent();
        }

        private void FormHelp_Shown(object sender, EventArgs e)
        {
            switch (HelpIndex)
            {
                case 1:
                    pictureBoxHelp.Image = AnimalHouseV3.Properties.Resources.FromAnimalHelp;
                    break;
                case 2:
                    pictureBoxHelp.Image = AnimalHouseV3.Properties.Resources.FormBookningHelp;
                    break;
                case 3:
                    pictureBoxHelp.Image = AnimalHouseV3.Properties.Resources.FormOwnerHelp;
                    break;
                case 4:
                    pictureBoxHelp.Image = AnimalHouseV3.Properties.Resources.FormSaleHelp;
                    break;

                default:
                    pictureBoxHelp.Image = AnimalHouseV3.Properties.Resources.Labrador_edit;
                    break;
            }
        }
    }
}
