using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseTemp;

namespace AnimalHouseV3
{
    public partial class FormImportMedicin : Form
    {
        NæstenController Nc = new NæstenController();
        public FormImportMedicin()
        {
            InitializeComponent();
        }

        private void buttonUpdatePrice_Click(object sender, EventArgs e)
        {
            richTextBoxInformation.AppendText("Starting transaction\n ");
            Nc.UpdateMedicin();
            richTextBoxInformation.AppendText("Transaction was succesfully \n");
        }
    }
}
