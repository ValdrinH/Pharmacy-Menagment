using Pharmacy_Menagment.Classes;
using Pharmacy_Menagment.UserControlsItem.HelpFormChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class AddNewMedicineItem : UserControl
    {
        int countSelected = 0;
        CommandDatabase insert = new CommandDatabase();
        public AddNewMedicineItem()
        {
            InitializeComponent();
        }

        private void txtMedicine_TextChanged(object sender, EventArgs e)
        {
            err1.Visible = true;
            if (txtMedicine.Text.Length == 0 || txtMedicine.Text.Length <= 3)
            {
                err1.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                if (txtMedicine.Text.Length == 0)
                {
                    err1.Text = "This field must be filled";
                }
                else
                {
                    err1.Text = "The medicine name must be longer";

                }
            }
            else
            {
                err1.StateCommon.ShortText.Color1 = Color.Green;
                err1.Text = "The field meets the criteria";
            }

        }

        private void txtGeneric_TextChanged(object sender, EventArgs e)
        {
            err2.Visible = true;
            if (txtGeneric.Text.Length == 0 || txtGeneric.Text.Length <= 3)
            {
                err2.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                if (txtGeneric.Text.Length == 0)
                {
                    err2.Text = "This field must be filled";
                }
                else
                {
                    err2.Text = "The Generic name must be longer";
                }
            }
            else
            {
                err2.StateCommon.ShortText.Color1 = Color.Green;
                err2.Text = "The field meets the criteria";
            }
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            err3.Visible = true;
            if (txtSupplier.Text.Length == 0)
            {
                err3.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                err3.Text = "Please select the supplier";
            }
            else
            {
                err3.StateCommon.ShortText.Color1 = Color.Green;
                err3.Text = "Supplier selected";
            }
        }

        private void AddMedicine_Click(object sender, EventArgs e)
        {
            if (txtMedicine.Text !="" && txtGeneric.Text != ""&& txtSupplier.Text != "" && txtPacking.Text != "")
            {
                try
                {
                    insert.InsertDb("Exec MedicineInsert @MedicineName = '"+txtMedicine.Text+"',@Generic_Name = '"+txtGeneric.Text+"',@Supplier_Name ='"+txtSupplier.Text+"',@Packing = '" +txtPacking.Text+"';");
                    MessageBox.Show("Medicine inserted successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                err1.Visible = true;
                err2.Visible = true;
                err3.Visible = true;
                //err1
                if (txtMedicine.Text.Length == 0 || txtMedicine.Text.Length <= 3)
                {
                    err1.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    if (txtMedicine.Text.Length == 0)
                    {
                        err1.Text = "This field must be filled";
                    }
                    else
                    {
                        err1.Text = "The medicine name must be longer";

                    }
                }
                else
                {
                    err1.StateCommon.ShortText.Color1 = Color.Green;
                    err1.Text = "The field meets the criteria";
                }
                //err2
                err2.Visible = true;
                if (txtGeneric.Text.Length == 0 || txtGeneric.Text.Length <= 3)
                {
                    err2.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    if (txtGeneric.Text.Length == 0)
                    {
                        err2.Text = "This field must be filled";
                    }
                    else
                    {
                        err2.Text = "The Generic name must be longer";
                    }
                }
                else
                {
                    err2.StateCommon.ShortText.Color1 = Color.Green;
                    err2.Text = "The field meets the criteria";
                }

                //err3
                if (txtGeneric.Text.Length == 0 || txtGeneric.Text.Length <= 3)
                {
                    err2.StateCommon.ShortText.Color1 = Color.FromName("Maroon");
                    if (txtGeneric.Text.Length == 0)
                    {
                        err2.Text = "This field must be filled";
                    }
                    else
                    {
                        err2.Text = "The Generic name must be longer";
                    }
                }
                else
                {
                    err2.StateCommon.ShortText.Color1 = Color.Green;
                    err2.Text = "The field meets the criteria";
                }

            }
        }

        private void ClearFields()
        {
            err1.Visible = false;
            err2.Visible = false;
            err3.Visible = false;

            txtMedicine.Text = string.Empty;
            txtGeneric.Text = string.Empty;
            txtSupplier.Text = string.Empty;    
            txtPacking.Text = string.Empty;
        }
        void LoadData()
        {
            try
            {
                dtMedicineStock.DataSource = insert.GetDataTable("Exec LoadMedicine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNewMedicineItem_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtMedicineStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count;
        }

        private void dtMedicineStock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count;
        }

        private void dtMedicineStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtMedicineStock.Columns[e.ColumnIndex].Name == "Slc")
            {

                //if (Convert.ToBoolean(dtMedicineStock.Rows[e.RowIndex].Cells[0].Value) == false) 
                //{
                //    if (CheckIfMedicineIsPruchase(int.Parse(dtMedicineStock.Rows[e.RowIndex].Cells[1].Value.ToString())))
                //    {
                //        countSelected+=1;
                //    }
                //    else
                //    {
                //        var obj = dtMedicineStock.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                //        obj.Value = false;
                //        VarClass.ShowMsgBox($"Kjo Medicine gjindet ne stock\nNuk mund ta selektoni","Kujdes", 2);
                //    }
                //}
                //else { countSelected-=1; }
                //EnableBtn();
            }
        }
        void EnableBtn()
        {
            if (countSelected <= 0)
            {
                btnDeleteRows.Enabled = false;
            }
            else if (countSelected > 0)
            {
                btnDeleteRows.Enabled = true;
            }

        }

        private void btnDeleteRows_Click(object sender, EventArgs e)
        {
            try
            {
                int inPruch = 0;
                string[] names = new string[dtMedicineStock.RowCount];
                DialogResult dr = MessageBox.Show("Deshiron të fshish medicinat e selekuara ?", "Pyetje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int delCount = 0;
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        if (Convert.ToBoolean(dtMedicineStock.Rows[item.Index].Cells[1].Value) == true)
                        {
                            if (CheckIfMedicineIsPruchase(int.Parse(dtMedicineStock.Rows[item.Index].Cells[2].Value.ToString())))
                            {
                                delCount++;
                                insert.InsertDb($"Exec RemoveMedicine @Id = {int.Parse(dtMedicineStock.Rows[item.Index].Cells[2].Value.ToString())}");
                                dtMedicineStock.Refresh();
                            }
                            else { names[inPruch] = dtMedicineStock.Rows[item.Index].Cells[3].Value.ToString(); inPruch++; }
                        }
                        item.Cells["Slc"].Value = false;
                    }

                    string newmsg = string.Empty;
                    foreach (string item in names)
                    {
                        newmsg += item + "\n";
                    }
                    if (inPruch > 0) { MessageBox.Show($"Medicinat :\n{newmsg} Nuk mund te fshihen nga databaza për shkak sepse gjinden ne stoqe.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                    if (delCount == 0) { LoadData(); VarClass.ShowMsgBox($"Nuk u fshi asnjë rresht", "Informacion", 1); }
                    else if(delCount > 0) { LoadData(); VarClass.ShowMsgBox($"U fshin me sukses", "Me sukses", 3); }


                   
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool CheckIfMedicineIsPruchase(int _id)
        {
            bool verf = (insert.GetIdItem($"Exec GetIdElement @Id = {_id}") == 0) ? true : false;
            return verf;
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtMedicineName.Text != "")
            {
                if (dtMedicineStock.RowCount > 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                    currencyManager1.SuspendBinding();
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        if (txtgnrc.Text != "" || txtSupp.Text != "")
                        {
                            item.Visible = (item.Cells["Emri Medicines"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower())
                                 && (item.Cells["Generic Emri"].Value.ToString().ToLower().Contains(txtgnrc.Text.ToLower()) && item.Cells["Furnizues"].Value.ToString().ToLower().Contains(txtSupp.Text.ToLower())));
                        }
                        else
                            item.Visible = (item.Cells["Emri Medicines"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower()));
                    }
                    VisbleRows();
                }
            }
            else
            {
                if (txtSupp.Text == "" && txtgnrc.Text == "")
                {
                    LoadData();
                }
            }
        }

        private void txtgnrc_TextChanged(object sender, EventArgs e)
        {
            if (txtgnrc.Text != "")
            {
                if (dtMedicineStock.RowCount > 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                    currencyManager1.SuspendBinding();
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        if (txtMedicineName.Text != "" || txtSupp.Text != "")
                        {
                            item.Visible = (item.Cells["Generic Emri"].Value.ToString().ToLower().Contains(txtgnrc.Text.ToLower())
                                 && (item.Cells["Emri Medicines"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower()) && item.Cells["Furnizues"].Value.ToString().ToLower().Contains(txtSupp.Text.ToLower())));
                        }
                        else
                            item.Visible = (item.Cells["Generic Emri"].Value.ToString().ToLower().Contains(txtgnrc.Text.ToLower()));

                    }
                }
                VisbleRows();
            }
            else
            {
                if (txtSupp.Text == "" && txtMedicineName.Text == "")
                {
                    LoadData();
                }
            }
        }

        private void txtSupp_TextChanged(object sender, EventArgs e)
        {
            if (txtSupp.Text != "")
            {
                if (dtMedicineStock.RowCount > 0)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                    currencyManager1.SuspendBinding();
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        if (txtMedicineName.Text != "" || txtgnrc.Text != "")
                        {
                            item.Visible = (item.Cells["Furnizues"].Value.ToString().ToLower().Contains(txtSupp.Text.ToLower())
                                 && (item.Cells["Emri Medicines"].Value.ToString().ToLower().Contains(txtMedicineName.Text.ToLower()) && item.Cells["Generic Emri"].Value.ToString().ToLower().Contains(txtgnrc.Text.ToLower())));
                        }
                        else
                            item.Visible = (item.Cells["Furnizues"].Value.ToString().ToLower().Contains(txtSupp.Text.ToLower()));
                    }
                    VisbleRows();
                }
            }
            else
            {
                if (txtgnrc.Text == "" && txtMedicineName.Text == "")
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
        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult dr = VarClass.HelpFormResult("Shto Furnizues të ri", new AddNewSupplier());
        }

        private void txtSupplier_Enter(object sender, EventArgs e)
        {
            DialogResult drs = VarClass.HelpFormResult("Selekto Furnizuesin", new ListOfSupplier());
            if (drs == DialogResult.OK)
            {
                txtSupplier.Text = DetailsSupplierStruct.SName;
                txtPacking.Focus();
            }
            else
            {
                txtPacking.Focus();
            }
        }

        private void txtPacking_TextChanged(object sender, EventArgs e)
        {
            if (txtPacking.Text != "")
            {
                string[] newText = txtPacking.Text.Split(" ");
                if (newText.Length > 1 && newText.Length < 3) { err4.Visible = false; }
                else if(newText.Length >= 3) { txtPacking.Text = "";err4.Visible = true; }
            }
        }
    }
}
