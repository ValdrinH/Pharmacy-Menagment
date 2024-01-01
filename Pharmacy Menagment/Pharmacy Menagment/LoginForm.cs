using Pharmacy_Menagment.Classes;
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
    public partial class LoginForm : Form
    {
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

        CommandDatabase database = new CommandDatabase();
        public LoginForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void HideShow(object sender, EventArgs e)
        {
            
        }

        private void btnLoggin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPsw.Text != "")
            {
                try
                {
                   int ifExcist = database.GetIdItem("Select dbo.LoginCount('" + txtEmail.Text + "','" + txtPsw.Text + "') ");
                    if (ifExcist > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                        VarClass.ShowMsgBox($"Kredencialet të gabuara.\nProvo përsëri", "Kujdes", 2);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                VarClass.ShowMsgBox($"Fushat nuk duhet të jenë të zbrazura", "Kujdes", 2);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txtPsw.PasswordChar == '●')
            {
                txtPsw.PasswordChar = '\0';
                picHide.Image = Properties.Resources.icons8_hide_40;
            }
            else
            {
                txtPsw.PasswordChar = '●';
                picHide.Image = Properties.Resources.icons8_eye_40;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
