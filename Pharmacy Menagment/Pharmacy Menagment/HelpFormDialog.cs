using Pharmacy_Menagment.UserControlsItem.HelpFormChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment
{
    public partial class HelpFormDialog : Form
    {
        public UserControl user { get; set; }
        public string _Tit { get => lblTitle.Text; set => lblTitle.Text = value; }
        private bool mouseDown;
        private Point lastLocation;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect,     // x-coordinate of upper-left corner
         int nTopRect,      // y-coordinate of upper-left corner
         int nRightRect,    // x-coordinate of lower-right corner
         int nBottomRect,   // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
     );
        public HelpFormDialog()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void HelpFormDialog_Load(object sender, EventArgs e)
        {
            UserC(user);
            lblTitle.Location = new Point((TopPnl.Width - lblTitle.Width) / 2, (TopPnl.Height - lblTitle.Height) / 2);
        }
        void UserC(UserControl users)
        {
            Body.Controls.Clear();
            users.Dock = DockStyle.Fill;
            Body.Controls.Add(users);
            users.BringToFront();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void TopPnl_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
