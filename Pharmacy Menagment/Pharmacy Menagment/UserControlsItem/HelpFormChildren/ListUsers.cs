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
    public partial class ListUsersItem : UserControl
    {
        public string NameSurname { get => Name.Text; set=>Name.Text = value; }
        public string NrTel { get => Nr.Text; set => Nr.Text = value; }
        public string Adress { get; set; }

        public EventHandler handler = null;

        public ListUsersItem()
        {
            InitializeComponent();
        }

        private void Name_Click(object sender, EventArgs e)
        {
            handler?.Invoke(sender,e);
        }

        private void ListUsers_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            Nr.ForeColor = Color.White;
            Name.ForeColor = Color.White;
        }

        private void ListUsers_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            Nr.ForeColor= Color.Black;
            Name.ForeColor = Color.Black;

        }
    }
}
