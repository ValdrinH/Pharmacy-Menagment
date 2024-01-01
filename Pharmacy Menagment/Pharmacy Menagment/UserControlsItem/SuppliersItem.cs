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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class SuppliersItem : UserControl
    {
        CommandDatabase command = new CommandDatabase();
        public SuppliersItem()
        {
            InitializeComponent();
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            err1.Visible = true;
            if (txtSupplierName.Text.Length == 0 || txtSupplierName.Text.Length <= 3)
            {
                err1.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                err1.Text = "Kjo fushë duhet të jetë e mbushur";
            }
            else
            {
                err1.StateCommon.ShortText.Color1 = Color.Green;
                err1.Text = "Kjo fushë plotësoni kriterin";
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
                err2.Text = "Ju lutem vendosni një email";
            }
            else
            {
                err2.StateCommon.ShortText.Color1 = Color.Green;
                err2.Text = "Kjo fushë plotësoni kriterin";
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
                err3.Text = "Kjo fushë duhet të jetë numër";
            }
            else
            {
                err3.Visible = true;
                err3.StateCommon.ShortText.Color1 = Color.Green;
                err3.Text = "Kjo fushë plotësoni kriterin";
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
                err4.Text = "Kjo fushë duhet të jetë e mbushur";
            }
            else
            {
                err4.StateCommon.ShortText.Color1 = Color.Green;
                err4.Text = "Kjo fushë plotësoni kriterin";
            }
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text !="" && txtAddress.Text != "" && txtEmail.Text != "" && txtNum.Text != "")
            {
                try
                {
                    using (var objWait = new LoadingScreen(InsertWithLs, "Po shtohet Furnizuesi i ri\nJu lutem prisni..."))
                    {
                        objWait.ShowDialog(this);
                        if (objWait.DialogResult == DialogResult.OK)
                        {
                            txtSupplierName.Text = string.Empty;
                            txtEmail.Text = string.Empty;
                            txtNum.Text = string.Empty;
                            txtAddress.Text = string.Empty;
                            LoadData();
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
                //
                err1.Visible = true;
                if (txtSupplierName.Text.Length == 0 || txtSupplierName.Text.Length <= 3)
                {
                    err1.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    err1.Text = "Kjo fushë duhet të jetë e mbushur";
                }
                else
                {
                    err1.StateCommon.ShortText.Color1 = Color.Green;
                    err1.Text = "Kjo fushë plotësoni kriterin";
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
                    err2.Text = "Ju lutem vendosni një email";
                }
                else
                {
                    err2.StateCommon.ShortText.Color1 = Color.Green;
                    err2.Text = "Kjo fushë plotësoni kriterin";
                }


                //
                err3.Visible = true;
                if (txtNum.Text == "")
                {
                    err3.Visible = true;
                    err3.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    err3.Text = "Kjo fushë duhet të jetë numër";
                }
                else
                {
                    err3.Visible = true;
                    err3.StateCommon.ShortText.Color1 = Color.Green;
                    err3.Text = "Kjo fushë plotësoni kriterin";
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
                    err4.Text = "Kjo fush duhet të jetë e mbushur";
                }
                else
                {
                    err4.StateCommon.ShortText.Color1 = Color.Green;
                    err4.Text = "Kjo fushë plotësoni kriterin";
                }


            }
        }

        private void InsertWithLs()
        {
            command.InsertDb("Exec AddSupplier @SName = '" + txtSupplierName.Text + "',@SEmail = '" + txtEmail.Text + "',@STel = '" + txtNum.Text + "',@SAddress = '" + txtAddress.Text + "';");
        }
        void LoadData()
        {
            try
            {
                dtMedicineStock.DataSource = command.GetDataTable("Exec LoadSupplier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void VisbleRows()
        {
            var vsbl = dtMedicineStock.Rows.Cast<DataGridViewRow>().Where(item => item.Visible).ToList();
            totRows.Text = "Total i Rreshtave : " + vsbl.Count.ToString();
        }
        private void SuppliersItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtFurnizues_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void txtEmailSearch_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int tot = 0;
                bool ifEmpty = false;
                foreach (DataGridViewRow item in dtMedicineStock.Rows)
                {
                    bool ifchecket = Convert.ToBoolean(item.Cells["Check"].Value);
                    if (ifchecket)
                    {
                        if (item.Cells["Emri Furnizuesit"].Value.ToString() != "" && item.Cells["Tel."].Value.ToString() != "" && item.Cells["Email"].Value.ToString() != "" && item.Cells["Adresa"].Value.ToString() != "")
                        {
                            command.InsertDb($"Exec UpdateSupplier @Id = {int.Parse(item.Cells["Id"].Value.ToString())},@Sname ='" + item.Cells["Emri Furnizuesit"].Value.ToString() + "',@SEmail ='" + item.Cells["Email"].Value.ToString() + "' ,@STel ='" + item.Cells["Tel."].Value.ToString() + "',@SAdres ='" + item.Cells["Adresa"].Value.ToString() + "'");
                            item.Cells["Check"].Value = false;
                            tot++;
                        }
                        else
                            ifEmpty = true;
                    }
                }
                dtMedicineStock.Refresh();
                if (tot > 0) { VarClass.ShowMsgBox($"U përditësuan me sukses gjithësej : {tot}\nNumri Total Rreshtave: " + dtMedicineStock.RowCount, "Me sukses", 3); }
                if (ifEmpty) { MessageBox.Show($"Kolonat ne rreshtat përkatëse nuk duhet të jenë të zbrazura", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRows_Click(object sender, EventArgs e)
        {
            try
            {
                int tot = 0;
                if (dtMedicineStock.Rows.Count > 0)
                {
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        bool ifchecket = Convert.ToBoolean(item.Cells["Select"].Value);
                        if (ifchecket)
                        {
                            command.InsertDb($"Exec DeleteSupplier @Id = {int.Parse(item.Cells["Id"].Value.ToString())}");
                            dtMedicineStock.Rows.Remove(item);
                            tot++;
                        }
                    }
                    dtMedicineStock.Refresh();
                    if (tot > 0) { VarClass.ShowMsgBox($"U fshin me sukses gjithësej : {tot}\nNumri Total Rreshtave: " + dtMedicineStock.RowCount, "Me sukses", 3); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtMedicineStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "Id")
            {
                dtMedicineStock.Columns[e.ColumnIndex].Visible = false;
            }
          
        }

        private void dtMedicineStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtMedicineStock.Rows.Count > 0)
            {
                dtMedicineStock.Rows[e.RowIndex].Cells[1].Value = true;
            }
        }

        private void dtMedicineStock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count;
        }

        private void dtMedicineStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count;
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
