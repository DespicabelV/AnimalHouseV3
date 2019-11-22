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
    public partial class FormSalePos : Form
    {
        public FormSalePos()
        {
            InitializeComponent();
        }

        private void PrivateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivateCheckBox.Checked == true)
            {
                BuisnessCheckBox.Enabled = false;
            }
            else BuisnessCheckBox.Enabled = true;
        }

        private void BuisnessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BuisnessCheckBox.Checked == true)
            {
                PrivateCheckBox.Enabled = false;
            }
            else PrivateCheckBox.Enabled = true;
        }

        private void BtnSearchOwner_Click(object sender, EventArgs e)
        {
            if (BuisnessCheckBox.Checked == true)
            {
                //Select telenr from BuisnessCustomers
            }
        }

        private void FormSalePos_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
