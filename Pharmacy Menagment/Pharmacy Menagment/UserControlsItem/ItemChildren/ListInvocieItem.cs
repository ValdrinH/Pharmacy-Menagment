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
    public partial class ListInvocieItem : UserControl
    {
        public EventHandler ActionClick = null;

        public EventHandler EnterAction = null;

        public EventHandler AmountTextChange = null;
        public string LabelNums { get => LabelNum.Text; set => LabelNum.Text = value; }
        public int AllQty { get; set; }
        public int IdMedicine { get; set; }
        public ListInvocieItem()
        {
            InitializeComponent();
        }

        private void ActionForm(object sender, EventArgs e)
        {
            this.ActionClick?.Invoke(sender, e);
        }

        private void txtMedicine_Enter(object sender, EventArgs e)
        {
            this.EnterAction?.Invoke(sender, e);
        }

        private void QtyTxt_TextChanged(object sender, EventArgs e)
        {
            if (QtyTxt.Text != "" && int.TryParse(QtyTxt.Text, out _))
            {
                if (int.Parse(QtyTxt.Text) < AllQty && int.Parse(QtyTxt.Text) > 0)
                {
                    double total = 0;
                    if (txtdiscount.Text != "")
                    {
                        double calcnewValue = double.Parse(QtyTxt.Text) * double.Parse(txtRate.Text);
                        double firstval = double.Parse(txtdiscount.Text) / 100;
                        double secondVal = calcnewValue * firstval;
                        total = calcnewValue - secondVal;
                    }
                    else
                    {
                        total = double.Parse(QtyTxt.Text) * double.Parse(txtRate.Text);
                    }
                    txtAmount.Text = total.ToString("0.00") + "€";

                }
                else
                {
                    QtyTxt.Text = AllQty.ToString();
                }

            }
            else
            {
                if (!int.TryParse(QtyTxt.Text, out _))
                {
                    QtyTxt.Text = "";
                }
            }
        }

        private void QtyTxt_Leave(object sender, EventArgs e)
        {
            //if (int.Parse(QtyTxt.Text) < AllQty && int.Parse(QtyTxt.Text) > 0)
            //{

            //}
            //else
            //{

            //}
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (QtyTxt.Text != "")
            {
                double total = 0;
                if (txtdiscount.Text != "")
                {
                    double calcnewValue = double.Parse(QtyTxt.Text) * double.Parse(txtRate.Text);
                    double firstval = double.Parse(txtdiscount.Text) / 100;
                    double secondVal = calcnewValue * firstval;
                    total = calcnewValue - secondVal;
                }
                else
                {
                    total = double.Parse(QtyTxt.Text) * double.Parse(txtRate.Text);
                }
                txtAmount.Text = total.ToString("0.00") + "€";


            }
            else
                txtAmount.Text = "";
        }

        private void kryptonTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtdiscount.Text,out _))
            {
                double total = 0;
                if (QtyTxt.Text != "" && txtRate.Text != "")
                {
                    double calcnewValue = double.Parse(QtyTxt.Text) * double.Parse(txtRate.Text);
                    double firstval = double.Parse(txtdiscount.Text) / 100;
                    double secondVal = calcnewValue * firstval;
                    total = calcnewValue - secondVal;
                    txtAmount.Text = total.ToString("0.00") + "€";
                }
            }
            else
            {
                txtdiscount.Text = "";
            }
           
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            this.AmountTextChange?.Invoke(sender, e);

        }
    }
}
