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
    public partial class AnimalJournal : Form
    {
        public AnimalJournal()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            dataGridViewJournal.DataSource = Controller.ControllerGetJournal(txtBoxAnimalID.Text);
        }
    }
}
