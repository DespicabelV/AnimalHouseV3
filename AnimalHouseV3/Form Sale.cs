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
        NæstenController NC = new NæstenController();
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
            Temp.GetOwner(textBoxOwner.Text);
            Temp.CheckIfExsist(textBoxOwner.Text);
            if (Temp.CheckIfExsist(textBoxOwner.Text) == true)
            {
                OwnerValid.Checked = true;
                OwnerValid.Enabled = false;
            }
            else
            {
                OwnerValid.Checked = false;
                OwnerValid.Enabled = false;

            }

            foreach (string item in Temp.GetBookning1(textBoxOwner.Text))
            {
                ComboBoxBookning.Items.Add(item);
            }
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
            for (int i = 0; i <= DataGridViewItemsInStock.Rows.Count -1; i++)
            {
                bool RowExist = false;
                bool CheckedCell = Convert.ToBoolean(DataGridViewItemsInStock.Rows[i].Cells[0].Value);
                if (CheckedCell == true)
                {
                    DataGridViewRow Row = DataGridViewItemsInStock.Rows[i];
                    if (DataGridViewCart.Rows.Count != 0)
                    {
                        for (int j= 0; j < DataGridViewCart.Rows.Count-1; j++)
                        {
                            if (Row.Cells[2].Value.ToString() == DataGridViewCart.Rows[j].Cells[2].Value.ToString())
                            {
                                RowExist = true;
                                break;
                            }
                        }
                        if(RowExist == false)
                        {
                            DataGridViewCart.Rows.Add(Row.Cells[1].Value.ToString(),
                                                      Row.Cells[2].Value.ToString(),
                                                      Row.Cells[3].Value.ToString(),
                                                      Row.Cells[4].Value = TextboxAmount.Text,
                                                      Row.Cells[5].Value.ToString());
                            DataGridViewItemsInStock.Rows[i].Cells[0].Value = false;

                            //  NC.InsertOrderLine(Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(Row.Cells[1].Value),Convert.ToInt32(Row.Cells[2].Value), Convert.ToInt32(Row.Cells[5].Value), Convert.ToInt32(TextboxAmount.Text));
                            //  DataGridViewCart.DataSource = Temp.SelectFromOrdreLine(Convert.ToInt32(ComboBoxBookning.Text));
                        }
                    }
                    else
                    {
                        DataGridViewCart.Rows.Add(Row.Cells[1].Value.ToString(),//RessourceCategory
                                                  Row.Cells[2].Value.ToString(),//RessourceNumber
                                                  Row.Cells[3].Value.ToString(),//Name
                                                  Row.Cells[4].Value = TextboxAmount.Text,//Amount
                                                  Row.Cells[5].Value.ToString());//Pris
                        DataGridViewItemsInStock.Rows[i].Cells[0].Value = false;
                        // NC.InsertOrderLine(Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(Row.Cells[1].Value), Convert.ToInt32(Row.Cells[2].Value), Convert.ToInt32(Row.Cells[5].Value), Convert.ToInt32(TextboxAmount.Text));
                    }
                    TextboxDiscount.Text = Row.Cells[5].Value.ToString();
                    txtboxTotalPrisWithOutTax.Text = NC.ChangeOfPriceWithOutMoms(Convert.ToInt32(Row.Cells[5].Value),Convert.ToInt32(TextboxAmount.Text), Convert.ToInt32(txtboxTotalPrisWithOutTax.Text)).ToString();
                    txtboxTotalPrisWithTax.Text = NC.ChangeOfPriceWithMoms(Convert.ToInt32(Row.Cells[5].Value), Convert.ToInt32(TextboxAmount.Text), Convert.ToInt32(txtboxTotalPrisWithOutTax.Text)).ToString();
                }
            }
            TextboxAmount.Text = "";
            
        }

        private void ComboBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxCart.SelectedIndex==0)
            {
                TextboxDiscount.Text = "10";
            }
            if (ComboBoxCart.SelectedIndex == 1)
            {
                TextboxDiscount.Text = "0";
            }
            if (ComboBoxCart.SelectedIndex == 2)
            {
                TextboxDiscount.Text = "8";
            }
        }

        private void BtnAddBookning_Click(object sender, EventArgs e)
        {
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            NæstenController NC = new NæstenController();
            if (ComboBoxBookning.Text == "")
            {
                MessageBox.Show("");
            }
            if (BuisnessCheckBox.Checked == true)
            {
                NC.InsertReciept(Convert.ToInt32(txtboxTotalPrisWithOutTax.Text), Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(textBoxOwner.Text));
            }
        
            if (PrivateCheckBox.Checked== false)
            {
                NC.InsertReciept(Convert.ToInt32(txtboxTotalPrisWithTax.Text), Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(textBoxOwner.Text));
            }

            for (int i = 0; i <= DataGridViewCart.Rows.Count - 2; i++)
            {
                DataGridViewRow Row = DataGridViewCart.Rows[i];
                MessageBox.Show("xD");
                //Faktura                               //RessourceCategory                 //RessourceId                       //Price                                 //Amount
               // NC.InsertOrderLine(Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(Row.Cells[1].Value), Convert.ToInt32(Row.Cells[2].Value), Convert.ToInt32(Row.Cells[5].Value), Convert.ToInt32(TextboxAmount.Text));
            }

            //NC.UpdateAmountInStock("Medicin", Row.Cells[2].Value, , );
        }

        private void ButtonDiscount_Click(object sender, EventArgs e)
        {
           txtboxTotalPrisWithOutTax.Text = NC.Discount(Convert.ToInt32(txtboxTotalPrisWithOutTax.Text), Convert.ToInt32(TextboxDiscount.Text)).ToString();
           txtboxTotalPrisWithTax.Text = NC.Discount(Convert.ToInt32(txtboxTotalPrisWithTax.Text), Convert.ToInt32(TextboxDiscount.Text)).ToString();
        }
    }
}
