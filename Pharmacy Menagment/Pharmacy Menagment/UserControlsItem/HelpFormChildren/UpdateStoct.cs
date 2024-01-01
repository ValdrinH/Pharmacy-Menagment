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
    public partial class UpdateStoct : UserControl
    {
        CommandDatabase database = new CommandDatabase();
        private int _IdMdc = 0;
        public UpdateStoct(int id, string mdc,string Gmdc, string batch,string Dataexp,double rate)
        {
            InitializeComponent();
            txtMedicine.Text = mdc;
            txtGeneric.Text = Gmdc;
            txtRate.Text = rate.ToString("0.00");
            BatchId.Text = batch;
            txtDate.Text = Dataexp;
            _IdMdc= id;
            dt.Value = Convert.ToDateTime(Dataexp);
        }

        private void txtDate_Enter(object sender, EventArgs e)
        {
            dt.BringToFront();
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {
            if (dt.Value <= DateTime.Now)
            {
                txtDate.Text = "";
                VarClass.ShowMsgBox("Data e selektuar duhet te jetë më e Madhe", "Kujdes", 2);
            }
            else
            {
                txtDate.Text = dt.Value.ToString("yyyy/MM");
                txtDate.BringToFront();
            }

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (txtRate.Text != "")
            {
                if (!double.TryParse(txtRate.Text, out _))
                {
                    txtRate.Text = "";
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var objWait = new LoadingScreen(InsertDate, "Po ngarkohen të dhënat\nJu lutem prisni..."))
                {
                    objWait.ShowDialog(this);
                    if (objWait.DialogResult == DialogResult.OK)
                    {
                        var objPanel = (Panel)this.Parent;
                        var objForms = (HelpFormDialog)objPanel.Parent;
                        objForms.DialogResult = DialogResult.OK;
                        objForms.Close();
                    }
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertDate()
        {
            try
            {
                if (txtMedicine.Text != "" && txtGeneric.Text != "" && txtRate.Text != "" && BatchId.Text != "" && dt.Value > DateTime.Now)
                {
                    database.InsertDb("Exec UpdatePurchase @Id = '" + _IdMdc + "',@Name = '" + txtMedicine.Text + "',@Gnrc = '" + txtGeneric.Text + "', @ExpDate ='" + dt.Value.ToString("yyyy-MM-dd") + "'," +
                  " @Rate = '" + txtRate.Text + "', @DatePurchase = '" + DateTime.Now.ToString("yyyy-MM-dd") + "',@BatchId = '" + BatchId.Text + "'");

                    VarClass.ShowMsgBox($"U përditësua me sukses "+txtMedicine.Text, "Me sukses", 3);

                }
                else
                    VarClass.ShowMsgBox($"Ju lutem plotësoni të gjitha fushat.", "Kujdes", 1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
