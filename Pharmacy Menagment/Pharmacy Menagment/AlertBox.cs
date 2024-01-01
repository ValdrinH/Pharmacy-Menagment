using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment
{
    public partial class AlertBox : Form
    {
        public string _Tit;
        public string _Message;
        public int _Icon { get; set; }
        public AlertBox(string tit, string message, int icon)
        {
            InitializeComponent();
            _Tit = tit;
            _Message = message;
            _Icon = icon;
        }

        public void PositionForm()
        {
            int posx = 0; int posy = 0;

            posx = Screen.GetWorkingArea(this).Width;
            posy = Screen.GetWorkingArea(this).Height;
            this.Location = new Point(posx - this.Width, posy - this.Height);
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            lblMessagetit.Text = _Tit;
            lblDesc.Text = _Message;
            if (_Icon == 1)
            {
                this.BackColor = Color.FromArgb(251, 251, 207);
                lblDesc.ForeColor = Color.FromArgb(232, 212, 153);
                lblMessagetit.ForeColor = Color.FromArgb(232, 212, 153);
                IconMsg.Image = Properties.Resources.icons8_ok_80;

            }
            else if (_Icon == 2)
            {
                this.BackColor = Color.FromArgb(254, 182, 193);
                lblDesc.ForeColor = Color.FromArgb(193, 106, 119);
                lblMessagetit.ForeColor = Color.FromArgb(193, 106, 119);
                IconMsg.Image = Properties.Resources.icons8_high_priority_80;

            }
            else if (_Icon == 3)
            {
                this.BackColor = Color.FromArgb(143, 237, 148);
                lblDesc.ForeColor = Color.FromArgb(87, 180, 98);
                lblMessagetit.ForeColor = Color.FromArgb(87, 180, 98);
                IconMsg.Image = Properties.Resources.icons8_warning_80;

            }
            PositionForm();

            progressBar.BackColor = lblDesc.BackColor;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar.Value < 111)
            {
                progressBar.Value += 1;
                if (progressBar.Value == 111)
                {
                    this.Close();

                }
            }
        }

        private void Close_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlertBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
