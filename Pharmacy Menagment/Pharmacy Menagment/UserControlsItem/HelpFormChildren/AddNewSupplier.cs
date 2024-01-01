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
    public partial class AddNewSupplier : UserControl
    {
        CommandDatabase command = new CommandDatabase();
        public AddNewSupplier()
        {
            InitializeComponent();
        }
        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            err1.Visible = true;
            if (txtSupplierName.Text.Length == 0 || txtSupplierName.Text.Length <= 3)
            {
                err1.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                err1.Text = "This field must be filled";
            }
            else
            {
                err1.StateCommon.ShortText.Color1 = Color.Green;
                err1.Text = "The field meets the criteria";
            }
        }

        private void txtGeneric_TextChanged(object sender, EventArgs e)
        {
            err2.Visible = true;
            char at = '0';
            char[] arr = txtEmail.Text.ToCharArray();
            foreach (char item in arr)
            {
                if (item == '@')
                {
                    at = item;
                }
            }
            if (at != '@')
            {
                err2.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                err2.Text = "Please enter a correct email";
            }
            else
            {
                err2.StateCommon.ShortText.Color1 = Color.Green;
                err2.Text = "The field meets the criteria";
            }
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNum.Text, out _))
            {
                // Pastro TextBox dhe shfaq mesazhin gabim
                txtNum.Clear();
            }
        }

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                err3.Visible = true;
                err3.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                err3.Text = "This fiel must be Tel. Number";
            }
            else
            {
                err3.Visible = true;
                err3.StateCommon.ShortText.Color1 = Color.Green;
                err3.Text = "The field meets the criteria";
                //if (txtNum.Text.Length > 0)
                //{

                //    err3.StateCommon.ShortText.Color1 = Color.Green;
                //    err3.Text = "Supplier selected";
                //    //err3.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                //    //err3.Text = "Please select the supplier";
                //}
            }

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            err4.Show();
            if (txtAddress.Text.Length == 0 || txtAddress.Text.Length <= 3)
            {

                err4.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                err4.Text = "This field must be filled";
            }
            else
            {
                err4.StateCommon.ShortText.Color1 = Color.Green;
                err4.Text = "The field meets the criteria";
            }
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtNum.Text != "")
            {
                try
                {
                    using (var objWait = new LoadingScreen(InsertWithLs, "Po shtohet Furnizuesi i ri\nJu lutem prisni..."))
                    {
                        objWait.ShowDialog(this);
                    }
                    txtSupplierName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtNum.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //
                err1.Visible = true;
                if (txtSupplierName.Text.Length == 0 || txtSupplierName.Text.Length <= 3)
                {
                    err1.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    err1.Text = "This field must be filled";
                }
                else
                {
                    err1.StateCommon.ShortText.Color1 = Color.Green;
                    err1.Text = "The field meets the criteria";
                }

                //
                err2.Visible = true;
                char at = '0';
                char[] arr = txtEmail.Text.ToCharArray();
                foreach (char item in arr)
                {
                    if (item == '@')
                    {
                        at = item;
                    }
                }
                if (at != '@')
                {
                    err2.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    err2.Text = "Please enter a correct email";
                }
                else
                {
                    err2.StateCommon.ShortText.Color1 = Color.Green;
                    err2.Text = "The field meets the criteria";
                }


                //
                err3.Visible = true;
                if (txtNum.Text == "")
                {
                    err3.Visible = true;
                    err3.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    err3.Text = "This fiel must be Tel. Number";
                }
                else
                {
                    err3.Visible = true;
                    err3.StateCommon.ShortText.Color1 = Color.Green;
                    err3.Text = "The field meets the criteria";
                    //if (txtNum.Text.Length > 0)
                    //{

                    //    err3.StateCommon.ShortText.Color1 = Color.Green;
                    //    err3.Text = "Supplier selected";
                    //    //err3.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    //    //err3.Text = "Please select the supplier";
                    //}
                }

                //

                err4.Show();
                if (txtAddress.Text.Length == 0 || txtAddress.Text.Length <= 3)
                {

                    err4.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    err4.Text = "This field must be filled";
                }
                else
                {
                    err4.StateCommon.ShortText.Color1 = Color.Green;
                    err4.Text = "The field meets the criteria";
                }


            }
        }

        private void InsertWithLs()
        {
            command.InsertDb("Exec AddSupplier @SName = '" + txtSupplierName.Text + "',@SEmail = '" + txtEmail.Text + "',@STel = '" + txtNum.Text + "',@SAddress = '" + txtAddress.Text + "';");
        }
    }
}
