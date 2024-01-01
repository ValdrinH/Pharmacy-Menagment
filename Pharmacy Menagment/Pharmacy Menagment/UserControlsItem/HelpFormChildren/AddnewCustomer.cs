using Krypton.Toolkit;
using Pharmacy_Menagment.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.UserControlsItem.HelpFormChildren
{
    public partial class AddnewCustomer : UserControl
    {
        Color color1 = Color.White;
        CommandDatabase database = new CommandDatabase();
        public AddnewCustomer()
        {
            InitializeComponent();
            color1 = txtNameDoc.StateCommon.Border.Color1;
        }
        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNumber.Text, out _))
            {
                // Pastro TextBox dhe shfaq mesazhin gabim
                txtNumber.Clear();
            }
        }
        int numfromText = 0;
        private void AddCostumer_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" && txtCustomerName.Text != "" && txtNameDoc.Text != "" && txtAddress.Text != "" && CitySelect.Text != "" && CitySelect.Text != "Zgjedh Qytetin e banimit")
            {
                //do something
                try
                {
                    numfromText = GetNum(CitySelect.Text);
                    using (var objWait = new LoadingScreen(InsertingDb, "Po ngarkohen të dhënat\nJu lutem prisni..."))
                    {
                        objWait.ShowDialog(this);
                        if(objWait.DialogResult== DialogResult.OK)
                        {
                            ClearElements();
                        }
                    }
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BorderColor(Color.Red);
                err1.Visible = true;
            }
        }

        private void ClearElements()
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNameDoc.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNumber.Text = string.Empty;
            CitySelect.Text = "Zgjedh Qytetin e banimit";
        }

        private void InsertingDb()
        {
            database.InsertDb("Exec AddNewCustomer @Name = '" + txtCustomerName.Text + "',@ContactNum = '" + txtNumber.Text + $"',@City = {numfromText},@Doc_Name = '" + txtNameDoc.Text + "'");

        }

        public static int GetNum(string text)
        {
            char[] num = new char[text.Length];
            int index = 0;
            foreach (char item in text)
            {
                if (int.TryParse(item.ToString(),out _))
                {
                    num[index] = item;
                    index++;
                }
            }

            string numtxt = "";
            foreach (char item in num)
            {
                numtxt += item.ToString();
            }
            return int.Parse(numtxt);
        }

        void BorderColor(Color color)
        {
            foreach (Control item in this.Controls)
            {
                if (item is KryptonTextBox)
                {
                    var txtKrp = (KryptonTextBox)item;
                    if (txtKrp.Text == "")
                    {
                        txtKrp.StateCommon.Border.Color1 = color;
                    }
                    else
                    {
                        txtKrp.StateCommon.Border.Color1 = color1;
                    }
                }
            }
        }

        private void txtCustomerName_MouseEnter(object sender, EventArgs e)
        {
            if (err1.Visible)
            {
                err1.Visible = false;
            }
        }

        private void CitySelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
    }
}
