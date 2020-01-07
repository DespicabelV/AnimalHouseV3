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
using AnimalHouseController;

namespace AnimalHouseV3
{
    public partial class FormPrint : Form
    {
        //Allan
        Contoller Controller = new Contoller();

        public FormPrint()
        {
            InitializeComponent();
        }

        private void buttonPrintRessource_Click(object sender, EventArgs e)
        {
            Contoller Controller = new Contoller();
            List<string> MedicinStock = Controller.ControllerPrintMedicin();
            List<string> ShelfStock = Controller.ControllerPrintShelfStock();

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
                Writer.WriteLine($"Item Categori: {ShelfStock[(i*5)]}, Item ID: {ShelfStock[(i*5)+1]}," +
                    $"Item Name: {ShelfStock[(i*5)+2]}, Quantity: {ShelfStock[(i*5)+3]}, Price: {ShelfStock[(i*5)+4]}");
            }

            Writer.Close();
            MessageBox.Show("Print Completed");
            Process.Start(path);
        }

        //Viggo
        private void buttonPrintDoctorNotice_Click(object sender, EventArgs e)
        {
            List<string> DockterLetterList = Controller.ControllerPrintDocktorLetter();

            string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "DockterLetter.txt";
            File.WriteAllText(path, String.Empty);
            TextWriter tw = new StreamWriter(path, true);
            for (int i = 0; i < DockterLetterList.Count / 5; i++)
            {
                tw.WriteLine($"Animal ID: {DockterLetterList[i * 5]}, belonging to owner: {DockterLetterList[(i * 5) + 1]} " +
                    $"was last in here the: {Convert.ToDateTime(DockterLetterList[(i * 5) + 2]).ToString("dd-MM-yyyy")} to a {DockterLetterList[(i * 5) + 3]} whit doctor {DockterLetterList[(i * 5) + 4]}");
            }

            tw.Close();

            MessageBox.Show("Letter list created", "Sucess!", MessageBoxButtons.OK);
            Process.Start(path);
            this.Close();
        }
    }
}
