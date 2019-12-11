using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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

        private void buttonUpdatePrice_Click_1(object sender, EventArgs e)
        {
            richTextBoxInformation.AppendText("Starting transaction\n ");
            int Changes = Nc.UpdateMedicin();
            richTextBoxInformation.AppendText(Changes + " New changes where added \n");
            richTextBoxInformation.AppendText("Transaction was succesfully \n");
        }

        private void buttonChangeFile_Click(object sender, EventArgs e)
        {
            string Path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "MedicinData.txt";
            Process.Start(Path);
        }
    }
}
