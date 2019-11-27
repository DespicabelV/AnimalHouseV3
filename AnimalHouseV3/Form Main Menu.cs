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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnBookning_Click(object sender, EventArgs e)
        {
            Form_Booking Bookning = new Form_Booking();
            Bookning.ShowDialog();
        }

        private void BtnEjer_Click(object sender, EventArgs e)
        {
            Form_Owner Owner = new Form_Owner();
            Owner.ShowDialog();
        }

        private void BtnDyr_Click(object sender, EventArgs e)
        {
            Form_Animal Animal = new Form_Animal();
            Animal.ShowDialog();
        }

        private void BtnSalg_Click(object sender, EventArgs e)
        {
            FormSalePos Sale = new FormSalePos();
            Sale.ShowDialog();
        }

        private void BtnIndlæsMedicin_Click(object sender, EventArgs e)
        {
            FormImportMedicin importMedicin = new FormImportMedicin();
            importMedicin.ShowDialog();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            FormPrint Print = new FormPrint();
            Print.ShowDialog();
        }
    }
}
