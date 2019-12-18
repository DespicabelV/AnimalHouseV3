using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouseController;

namespace AnimalHouseV3
{
    public partial class FormSalePos : Form
    {
        Contoller Controller = new Contoller();
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

        private void ButtonSearchOwner_Click(object sender, EventArgs e)
        {
            if (Controller.ControllerOwnerExist(textBoxOwner.Text) == true)
            {
                OwnerValidCheckBox.Checked = true;
                OwnerValidCheckBox.Enabled = false;
                if (Controller.ControllerCheckIfExsistInPrivateIsPrivate(textBoxOwner.Text) == true)
                {
                    PrivateCheckBox.Checked = true;
                    BuisnessCheckBox.Checked = false;
                }
                else
                {
                    PrivateCheckBox.Checked = false;
                    BuisnessCheckBox.Checked = true;
                }
            }
            else
            {
                OwnerValidCheckBox.Checked = false;
                OwnerValidCheckBox.Enabled = false;
            }

            foreach (string item in Controller.ControllerBookningFeetch(textBoxOwner.Text))
            {
                ComboBoxBookning.Items.Add(item);
            }
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCategory=ComboBoxCategory.SelectedItem.ToString();
            DataGridViewItemsInStock.DataSource = Controller.ControllerPrintCategoryToDataGridView(SelectedCategory);
        }

        private void ButtonSearchRessource_Click(object sender, EventArgs e)
        {
            string Category = ComboBoxCategory.SelectedItem.ToString();
            DataGridViewItemsInStock.DataSource = Controller.ControllerPrintCategoryToDataGridViewName(Category,TxtboxSearchRessourceCategory.Text);
            
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
                            if (Row.Cells[2].Value.ToString() == DataGridViewCart.Rows[j].Cells[1].Value.ToString())
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
                    }
                    txtboxTotalPrisWithOutTax.Text = Controller.ControllerChangeOfPriceWithOutMoms(Convert.ToInt32(Row.Cells[5].Value),Convert.ToInt32(TextboxAmount.Text), Convert.ToInt32(txtboxTotalPrisWithOutTax.Text)).ToString();
                    txtboxTotalPrisWithTax.Text = Controller.ControllerChangeOfPriceWithMoms(Convert.ToInt32(Row.Cells[5].Value), Convert.ToInt32(TextboxAmount.Text), Convert.ToInt32(txtboxTotalPrisWithOutTax.Text)).ToString();
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
            
            //NC.SelectSpecificTreatment(Convert.ToInt32(ComboBoxBookning.Text));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp Help = new FormHelp();
            Help.HelpIndex = 4;
            Help.Show();
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            if (BuisnessCheckBox.Checked == false && BuisnessCheckBox.Checked == false || textBoxOwner.Text == "")
            {
                MessageBox.Show("Fill out the empty brackets");
                
            }
            else if (BuisnessCheckBox.Checked == true)
            {
                int ReceiptID = Controller.ControllerInsertReciept(Convert.ToInt32(txtboxTotalPrisWithOutTax.Text), Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(textBoxOwner.Text));
                for (int i = 0; i <= DataGridViewCart.Rows.Count - 2; i++)
                {
                    DataGridViewRow Row = DataGridViewCart.Rows[i];
                    //              Faktura   //RessourceCategorySetToRecieptID                 //RessourceId                       //Price                                 //Amount
                    Controller.ControllerInsertOrderLine(ReceiptID, Convert.ToInt32(Row.Cells[0].Value), Convert.ToInt32(Row.Cells[1].Value), Convert.ToInt32(Row.Cells[4].Value), Convert.ToInt32(Row.Cells[3].Value));
                }
            }
            else if (PrivateCheckBox.Checked == true)
            {
                int ReceiptID = Controller.ControllerInsertReciept(Convert.ToInt32(txtboxTotalPrisWithTax.Text), Convert.ToInt32(ComboBoxBookning.Text), Convert.ToInt32(textBoxOwner.Text));
                for (int i = 0; i <= DataGridViewCart.Rows.Count - 2; i++)
                {
                    DataGridViewRow Row = DataGridViewCart.Rows[i];
                    Controller.ControllerInsertOrderLine(ReceiptID, Convert.ToInt32(Row.Cells[0].Value), Convert.ToInt32(Row.Cells[1].Value), Convert.ToInt32(Row.Cells[4].Value), Convert.ToInt32(Row.Cells[3].Value));
                }
            }
            MessageBox.Show("Your Transaction was succesfull", "Succes!", MessageBoxButtons.OK);
            this.Close();
        }

        private void ButtonDiscount_Click(object sender, EventArgs e)
        {
           txtboxTotalPrisWithOutTax.Text = Controller.ControllerDiscount(Convert.ToInt32(txtboxTotalPrisWithOutTax.Text), Convert.ToInt32(TextboxDiscount.Text)).ToString();
           txtboxTotalPrisWithTax.Text = Controller.ControllerDiscount(Convert.ToInt32(txtboxTotalPrisWithTax.Text), Convert.ToInt32(TextboxDiscount.Text)).ToString();
        }
    }
}
