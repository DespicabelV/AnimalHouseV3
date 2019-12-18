using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AnimalHouseV3
{
    public partial class MainMenu : Form
    {
        private delegate void SafeCallDelegateDataGrid(DataGridViewRow text);
        private delegate void SafeCallDelegateTextBox(string text);
        private delegate void SafeCallDelegateDeleteDataGrid(int num);
        Random rnd = new Random();
        private string[,] TempRanPatient = { 
            { "Fiddo", "Bloodtest", "Peter Madsen", "9-10"}, 
            { "Mads", "Ear Exam", "Peter Madsen", "10-11"}, 
            { "Simba", "Snip", "Maria Lund", "11-12"}, 
            { "Bubi", "Bath", "Jens Larsen", "12-13"},
            { "Scooby", "Nail clipping", "Maria Lund", "13-14"} };
        static int TempPatientNumb = 0;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonBookning_Click(object sender, EventArgs e)
        {
            FormBooking Bookning = new FormBooking();
            Bookning.Show();
        }

        private void ButtonOwner_Click(object sender, EventArgs e)
        {
            Form_Owner Owner = new Form_Owner();
            Owner.Show();
        }

        private void ButtonAnimal_Click(object sender, EventArgs e)
        {
            Form_Animal Animal = new Form_Animal();
            Animal.Show();
        }

        private void ButtonSale_Click(object sender, EventArgs e)
        {
            FormSalePos Sale = new FormSalePos();
            Sale.Show();
        }

        private void ImportMedicin_Click(object sender, EventArgs e)
        {
            FormImportMedicin importMedicin = new FormImportMedicin();
            importMedicin.Show();
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            FormPrint Print = new FormPrint();
            Print.Show();
        }

        // Patient Line

        private void buttonStartTest_Click(object sender, EventArgs e)
        {
            Thread PatienChecker = new Thread(new ThreadStart(PatientLineChecker));
            PatienChecker.Start();
            buttonStartTest.Visible = false;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (TempPatientNumb < 4)
            {
                TempPatientNumb++;
            }
            else
            {
                TempPatientNumb = 0;
            }
            Thread TempThead = new Thread(new ThreadStart(PatientLineAddPatient));
            TempThead.Start();
        }

        private void buttonTreatPatient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewPatients.Rows.Count-1; i++)
            {
                int TempIndex;
                Thread TempThread;
                if (Convert.ToBoolean(dataGridViewPatients.Rows[i].Cells[0].Value))
                {
                    TempIndex = i;
                    TempThread = new Thread(() => PatientLineTreatPatient((string)dataGridViewPatients.Rows[TempIndex].Cells[1].Value, TempIndex));
                    TempThread.Start();
                }
            }
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.Rows.Clear();
            dataGridViewPatients.Refresh();
        }

        private void PatientLineAddPatient()
        {
            DataGridViewRow Row = (DataGridViewRow)dataGridViewPatients.Rows[0].Clone();
            for (int i = 1; i < 5; i++)
            {
                Row.Cells[i].Value = TempRanPatient[TempPatientNumb, i-1]; 
            }
            WriteTextSafeDataGrid(Row);
        }

        private void PatientLineTreatPatient(string Name, int Index)
        {
            int TempIndex = Index;
            int num = rnd.Next(1,10);
            WriteTextSafeTextBox($"Patient {Name} is being treated for {num} sek\n");
            Thread.Sleep(num * 1000);
            WriteTextSafeTextBox($"Patient {Name} is now done being treated\n");
            dataGridViewPatients.Rows[TempIndex].Cells[5].Value = true;
        }

        private void PatientLineChecker()
        {
            while (true)
            {
                for (int i = 0; i < dataGridViewPatients.Rows.Count - 1; i++)
                {
                    if (Convert.ToBoolean(dataGridViewPatients.Rows[i].Cells[5].Value))
                    {
                        DeleteSafeDataGrid(i);
                    }
                }
                Thread.Sleep(5000);
            }
        }

        private void WriteTextSafeTextBox(string text)
        {
            if (dataGridViewPatients.InvokeRequired)
            {
                var d = new SafeCallDelegateTextBox(WriteTextSafeTextBox);
                dataGridViewPatients.Invoke(d, new object[] { text });
            }
            else
            {
                richTextBoxInfo.AppendText(text);
                richTextBoxInfo.Update();
            }
        }

        private void WriteTextSafeDataGrid(DataGridViewRow Row)
        {
            if (dataGridViewPatients.InvokeRequired)
            {
                var d = new SafeCallDelegateDataGrid(WriteTextSafeDataGrid);
                dataGridViewPatients.Invoke(d, new object[] { Row });
            }
            else
            {
                dataGridViewPatients.Rows.Add(Row);
            }
        }

        private void DeleteSafeDataGrid(int num)
        {
            if (dataGridViewPatients.InvokeRequired)
            {
                var d = new SafeCallDelegateDeleteDataGrid(DeleteSafeDataGrid);
                dataGridViewPatients.Invoke(d, new object[] { num });
            }
            else
            {
                dataGridViewPatients.Rows.RemoveAt(num);
                dataGridViewPatients.Update();
            }
        }
    }
}
