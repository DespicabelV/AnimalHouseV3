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
    public partial class FormSalePos : Form
    {
        NichlasTemp Temp = new NichlasTemp();
        public FormSalePos()
        {
            InitializeComponent();
        }

        private void PrivateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PrivateCheckBox.Checked == true)
            {
                BuisnessCheckBox.Enabled = false;
                ComboBoxCart.SelectedIndex = 1;
            }
            else BuisnessCheckBox.Enabled = true;
        }

        private void BuisnessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BuisnessCheckBox.Checked == true)
            {
                PrivateCheckBox.Enabled = false;
                ComboBoxCart.SelectedIndex = 0;
            }
            else PrivateCheckBox.Enabled = true;
        }

        private void BtnSearchOwner_Click(object sender, EventArgs e)
        {
            //Select * from Owner
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCategory=ComboBoxCategory.SelectedItem.ToString();
            DataGridViewItemsInStock.DataSource = Temp.SelectFromXToGridView(SelectedCategory);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string Category = ComboBoxCategory.SelectedItem.ToString();
            DataGridViewItemsInStock.DataSource = Temp.SelectFromXToGridViewWhereX(Category,TxtboxSearchRessourceCategory.Text);
            
        }

        private void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGridViewItemsInStock.Rows.Count; i++)
            {
                bool RowAlreadyExist = false;
                bool CheckedCells = (bool)DataGridViewItemsInStock.Rows[i].Cells[0].Value;
                if (CheckedCells == true)
                {
                    DataGridViewRow Row = DataGridViewItemsInStock.Rows[i];
                    if (DataGridViewCart.Rows.Count!=0)
                    {
                        for(int j = 0; j <= DataGridViewCart.Rows.Count; j++) 
                        {
                            if (Row.Cells[0].Value.ToString() == DataGridViewCart.Rows[j].Cells[0].Value.ToString())
                            {
                                RowAlreadyExist = true;
                                break;
                            }
                        }
                        if (RowAlreadyExist == false)
                        {
                            int RessourceID = 0;
                            string Name = "";
                            double Price = 0;
                            int RessourceKategory = 0;
                            foreach (DataGridViewRow k in DataGridViewItemsInStock.Rows)
                            {
                                RessourceID = Convert.ToInt32(k.Cells[0].Value);
                                Name = k.Cells[1].Value.ToString();
                                Price = Convert.ToInt32(k.Cells[3].Value);
                                RessourceKategory = Convert.ToInt32(k.Cells[4].Value);
                            }
                            Temp.DBCInsertOrderLine(Convert.ToInt32(ComboBoxBookning.Text), RessourceKategory,RessourceID,Price,Convert.ToInt32(TextboxAmount.Text));
                        }
                    }
                    else
                    {

                    }
                }
            }
            DataGridViewCart.DataSource = Temp.SelectFromOrdreLine(2);

        }
    }
}
