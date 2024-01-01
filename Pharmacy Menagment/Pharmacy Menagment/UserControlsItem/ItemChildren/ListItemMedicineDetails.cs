using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.UserControlsItem.ItemChildren
{
    public partial class ListItemMedicineDetails : UserControl
    {
        public int ID = -1;
        public string LabelNums { get => LabelNum.Text; set => LabelNum.Text = value; }
        public string txtMdcName { get => txtMedicine.Text; set => txtMedicine.Text = value; }
        public string txtGeneric { get => txtGenericName.Text; set => txtGenericName.Text = value; }
        public string _batch { get => BatchId.Text;}
        public int _qty { get => int.Parse(QtyTxt.Text);}
        public double _rate { get => double.Parse(txtRate.Text);}
        public double _amount { get => double.Parse(txtAmount.Text); }
        public bool _errVisible { set=> err1.Visible = value; }
        public DateTime ExpDate = new DateTime();

        public EventHandler EnterTxt = null;

        public EventHandler TototalAmount = null;
        public ListItemMedicineDetails()
        {
            InitializeComponent();
        }

        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {
            if (QtyTxt.Text != "" )
            {
                if (QtyTxt.Text == "0")
                {
                     QtyTxt.Text = "";
                }

                if (int.TryParse(QtyTxt.Text,out _))
                {
                    if (txtRate.Text != "")
                    {
                        double qty = Convert.ToDouble(QtyTxt.Text);
                        double sum = qty * Convert.ToDouble(txtRate.Text);
                        txtAmount.Text = sum.ToString("0.00");
                    }
                    
                }
                else
                {
                    QtyTxt.Text = "";
                }
            }
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text != "")
            {
                if (double.TryParse(txtRate.Text, out _))
                {
                    if (txtRate.Text != "")
                    {
                        if (QtyTxt.Text != "")
                        {
                            double qty = Convert.ToDouble(QtyTxt.Text);
                            double sum = qty * Convert.ToDouble(txtRate.Text);
                            txtAmount.Text = sum.ToString("0.00");
                        }
                    }
                }
                else
                {
                    txtRate.Text = "";
                }
            }
        }

        private void ListItemMedicineDetails_Load(object sender, EventArgs e)
        {
        }

        private void txtMedicine_Enter(object sender, EventArgs e)
        {
            EnterTxt?.Invoke(sender, e);
        }

        private void txtMedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            //bool ifwrt = false;
            //int count = 0;
            //foreach (char item in txtDate.Text.ToCharArray())
            //{
            //    if (item.ToString() == @"\")
            //    {
            //        count++;
            //        ifwrt = true;
            //        if (count > 1)
            //        {
            //            txtDate.Text = "";
            //        }
            //    }
            //}

            //char[] objtxt = txtDate.Text.ToCharArray();
            //int length = txtDate.Text.Length;
            //if (length == 2)
            //{
            //    txtDate.Text += @"\";
            //}

            //if (DateTime.TryParse(txtDate.Text, out _))
            //{

            //}
            //else
            //{
            //    txtDate.Text = "";
            //}

        }

        private void kryptonDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dt.Value> DateTime.Now)
            {
                dt.Visible = false;
                txtRate.Focus();
                txtDate.Text = dt.Value.ToString("MM/yyyy");
                ExpDate = dt.Value ;
            }
            else
            {
                MessageBox.Show("Produkti duhet të ketë një datë tjetër skadimi, ju lutemi rishikoni atë ose përndryshe nuk mund të shtohet në sistem","Nnjoftim",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           
        }

        private void kryptonDateTimePicker1_Leave(object sender, EventArgs e)
        {
            dt.Visible = false;
            txtDate.Focus();
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {
            dt.Visible = true;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            TototalAmount?.Invoke(sender, e);
        }
    }
}
