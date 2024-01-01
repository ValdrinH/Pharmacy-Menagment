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
    public partial class LoadingScreen : Form
    {
        public Action action { get; set; }
        public LoadingScreen(Action Worker,string text)
        {
            InitializeComponent();
            lblnotify.Text = text;
            lblnotify.Location = new Point((this.Width - lblnotify.Width) / 2, lblnotify.Location.Y);

            if (Worker == null)
                throw new ArgumentNullException();
            action = Worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(action).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void LoadingScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
