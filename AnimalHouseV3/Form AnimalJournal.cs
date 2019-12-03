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
    public partial class AnimalJournal : Form
    {
        public AnimalJournal()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            AnimalHouseTemp.Controller Contemp = new AnimalHouseTemp.Controller();

            dataGridViewJournal.DataSource = Contemp.GetJournal(txtBoxAnimalID.Text);
        }
    }
}
