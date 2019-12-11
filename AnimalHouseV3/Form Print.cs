using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalHouseV3
{
    public partial class FormPrint : Form
    {
        public FormPrint()
        {
            InitializeComponent();
        }

        private void buttonPrintRessource_Click(object sender, EventArgs e)
        {
            AnimalHouseTemp.Controller Contemp = new AnimalHouseTemp.Controller();
            List<string> MedicinStock = Contemp.ControllerPrintMedicin();
            List<string> ShelfStock = Contemp.PrintShelfStock();

            string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "PrintRessource.txt";
            System.IO.File.WriteAllText(path, string.Empty);
            TextWriter Writer = new StreamWriter(path, true);

            for (int i = 0; i < MedicinStock.Count/5; i++)
            {
                Writer.WriteLine($"Item Categori: {MedicinStock[(i*5)]}, Item ID: {MedicinStock[(i*5)+1]}," +
                    $"Item Name: {MedicinStock[(i*5)+2]}, Quantity: {MedicinStock[(i*5)+3]}, Price: {MedicinStock[(i*5)+4]}");
            }

            for (int i = 0; i < ShelfStock.Count/5; i++)
            {
                Writer.WriteLine($"Item Categori: {MedicinStock[(i*5)]}, Item ID: {MedicinStock[(i*5)+1]}," +
                    $"Item Name: {MedicinStock[(i*5)+2]}, Quantity: {MedicinStock[(i*5)+3]}, Price: {MedicinStock[(i*5)+4]}");
            }

            Writer.Close();
            MessageBox.Show("Print Completed");
            Process.Start(path);
        }
    }
}
