using Krypton.Toolkit;
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
using static System.Net.Mime.MediaTypeNames;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class CreateCostumer : UserControl
    {
        Color color1 = Color.White;
        CommandDatabase database = new CommandDatabase();

        public CreateCostumer()
        {
            InitializeComponent();
            color1= txtNameDoc.StateCommon.Border.Color1;
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(txtNumber.Text, out _))
            {
                // Pastro TextBox dhe shfaq mesazhin gabim
                txtNumber.Clear();
            }
        }
        int numfromText = 0;
        private void AddCostumer_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text != "" && txtCustomerName.Text != "" && txtNameDoc.Text != "" && txtAddress.Text != "" && CitySelect.Text != "" && CitySelect.Text != "Zgjedh Qytetin e banimit")
            {
                //do something
                numfromText = GetNum(CitySelect.Text);
                using (var objWait = new LoadingScreen(InsertingDb, "Po ngarkohen të dhënat\nJu lutem prisni..."))
                {
                    objWait.ShowDialog(this);
                    if (objWait.DialogResult == DialogResult.OK)
                    {
                        ClearElements();
                        LoadData();
                    }
                }
            }
            else
            {
                BorderColor(Color.Red);
                err1.Visible = true;
            }
        }
        private void ClearElements()
        {
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNameDoc.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtNumber.Text = string.Empty;
            CitySelect.Text = "Zgjedh Qytetin e banimit";
        }

        private void InsertingDb()
        {
            database.InsertDb("Exec AddNewCustomer @Name = '" + txtCustomerName.Text + "',@ContactNum = '" + txtNumber.Text + $"',@City = {numfromText},@Doc_Name = '" + txtNameDoc.Text + "'");
        }

        public static int GetNum(string text)
        {
            char[] num = new char[text.Length];
            int index = 0;
            foreach (char item in text)
            {
                if (int.TryParse(item.ToString(), out _))
                {
                    num[index] = item;
                    index++;
                }
            }

            string numtxt = "";
            foreach (char item in num)
            {
                numtxt += item.ToString();
            }
            return int.Parse(numtxt);
        }

        void BorderColor(Color color)
        {
            foreach (Control item in this.Controls)
            {
                if (item is KryptonTextBox)
                {
                    var txtKrp = (KryptonTextBox)item;
                    if (txtKrp.Text == "")
                    {
                        txtKrp.StateCommon.Border.Color1 = color;
                    }
                    else
                    {
                        txtKrp.StateCommon.Border.Color1 = color1;
                    }
                }
            }
        }

        private void txtCustomerName_MouseEnter(object sender, EventArgs e)
        {
            if (err1.Visible)
            {
                err1.Visible = false;
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

        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            if (txtMedicineName.Text != "")
            {
                if (dtMedicineStock.Rows.Count > 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                    currencyManager1.SuspendBinding();
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        if (txtNr.Text != "")
                        {
                            item.Visible = (item.Cells["Emri dhe Mbiemri"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower())
                                 && (item.Cells["Tel."].Value.ToString().ToLower().Contains(txtNr.Text.ToLower())));
                        }
                        else
                            item.Visible = (item.Cells["Emri dhe Mbiemri"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower()));

                    }
                    VisbleRows();
                }
            }
            else
            {
                if (txtNr.Text == "")
                {
                    LoadData();
                }
            }
        }
        void VisbleRows()
        {
            var vsbl = dtMedicineStock.Rows.Cast<DataGridViewRow>().Where(item => item.Visible).ToList();
            totRows.Text = "Total i Rreshtave : " + vsbl.Count.ToString();
        }

        private void txtNr_TextChanged(object sender, EventArgs e)
        {
            if (txtNr.Text != "")
            {
                if (dtMedicineStock.Rows.Count > 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                    currencyManager1.SuspendBinding();
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        if (txtMedicineName.Text != "")
                        {
                            item.Visible = (item.Cells["Tel."].Value.ToString().ToLower().Contains(txtNr.Text.ToLower())
                                 && (item.Cells["Emri dhe Mbiemri"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower())));
                        }
                        else
                            item.Visible = (item.Cells["Tel."].Value.ToString().ToLower().Contains(txtNr.Text.ToLower()));

                    }
                    VisbleRows();
                }
            }
            else
            {
                if (txtMedicineName.Text == "")
                {
                    LoadData();
                }
            }
        }
        void LoadData()
        {
            try
            {
                dtMedicineStock.DataSource = database.GetDataTable("Exec LoadCustomer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CreateCostumer_Load(object sender, EventArgs e)
        {
            LoadData();
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
                        if (item.Cells["Emri dhe Mbiemri"].Value.ToString() != "" && item.Cells["Tel."].Value.ToString() != "" && item.Cells["Doktorri"].Value.ToString() != "")
                        {
                            database.InsertDb($"Exec EditCustomer @Id = {int.Parse(item.Cells["Id"].Value.ToString())},@NameSurname ='"+ item.Cells["Emri dhe Mbiemri"].Value.ToString() + "',@Nrtel ='"+ item.Cells["Tel."].Value.ToString() + "' ,@Doc ='"+ item.Cells["Doktorri"].Value.ToString() + "'");
                            item.Cells["Check"].Value = false;
                            tot++;
                        }
                        else
                            ifEmpty = true;
                    }
                }
                dtMedicineStock.Refresh();
                if (tot > 0) { VarClass.ShowMsgBox($"U përditësuan me sukses gjithësej : {tot}\nNumri Total Rreshtave: " + dtMedicineStock.RowCount, "Me sukses", 3); }
                if (ifEmpty) { MessageBox.Show($"Kolonat ne rreshtat përkatëse nuk duhet të jenë të zbrazura", "Gabim", MessageBoxButtons.OK,MessageBoxIcon.Warning); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtMedicineStock_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dtMedicineStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtMedicineStock.Rows.Count > 0)
            {
                dtMedicineStock.Rows[e.RowIndex].Cells[0].Value = true;
            }
        }

        private void dtMedicineStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "Id")
            {
                dtMedicineStock.Columns[e.ColumnIndex].Visible = false;
            }
            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "Qyteti")
            {
                dtMedicineStock.Columns[e.ColumnIndex].ReadOnly = true;
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
                        bool ifchecket = Convert.ToBoolean(item.Cells["Selekto"].Value);
                        if (ifchecket)
                        {
                            database.InsertDb($"Exec DeleteCustomer @Id = {int.Parse(item.Cells["Id"].Value.ToString())}");
                            dtMedicineStock.Rows.Remove(item);
                            tot ++;
                        }
                    }
                    dtMedicineStock.Refresh();
                    if (tot> 0) { VarClass.ShowMsgBox($"U fshin me sukses gjithësej : {tot}\nNumri Total Rreshtave: " +dtMedicineStock.RowCount, "Me sukses", 3); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
