using PageList;
using Pharmacy_Menagment.Classes;
using Pharmacy_Menagment.UserControlsItem.HelpFormChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class MedicineStockItem : UserControl
    {
        CommandDatabase command = new CommandDatabase();
        private int currentpages = 1;
        private int pagesize = 10;
        private int totPage ;
        private int TotRecords;
        DataTable dt = new DataTable();

        public MedicineStockItem()
        {
            InitializeComponent();
        }

        private void MedicineStockItem_Load(object sender, EventArgs e)
        {
            using (var objWait = new LoadingScreen(LoadData, "Po ngarkohen të dhënat\nJu lutem prisni..."))
            {
                objWait.ShowDialog(this);
                
            }
            loadNumPages();
        }
        void LoadData()
        {
            try
            {
                //dt = command.GetDataTable("Exec LoadSearchStock");
                TotRecords = command.GetIdItem("Select  dbo.TotalRecords()");
                totPage = (int)Math.Ceiling((double)TotRecords / pagesize);
                loadNumPages();

                dtMedicineStock.DataSource = command.GetDataTable($"Exec LoadStock @currentPage = {currentpages} ,@Pagesize = {pagesize}");

            }
            catch (Exception ex)
            {
                if (!ex.Message.Contains("Cross-thread operation not valid: Control 'dtMedicineStock' accessed from a thread other than the thread it was created"))
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void loadNumPages()
        {
            if (lblnum.InvokeRequired)
            {
                lblnum.Invoke(new MethodInvoker(delegate () { lblnum.Text = "1/" + totPage.ToString(); }));
            }
            else
                lblnum.Text = "1/" + totPage.ToString();
        }
        private void dtMedicineStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dtMedicineStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtMedicineStock.Columns[e.ColumnIndex].Name == "Delete")
                {

                    DialogResult drs = MessageBox.Show("Dëshironi ta fshini Medicinen me Emrin: '" + dtMedicineStock.Rows[e.RowIndex].Cells[4].Value.ToString() + "' nga stoku juaj ?", "Pyetje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (drs == DialogResult.Yes)
                    {
                        command.InsertDb("Exec DeleteStockItem @Id = '" + int.Parse(dtMedicineStock.Rows[e.RowIndex].Cells[3].Value.ToString()) + "'");
                        VarClass.ShowMsgBox($"U Fshi me sukses\n Numri Rreshtave {dtMedicineStock.Rows.Count} ", "Me sukses", 3);
                        dtMedicineStock.Rows.RemoveAt(e.RowIndex);
                        dtMedicineStock.Refresh();
                    }

                }
                else if (dtMedicineStock.Columns[e.ColumnIndex].Name == "Edit")
                {
                    //
                    var obj = new UpdateStoct(int.Parse(dtMedicineStock.Rows[e.RowIndex].Cells[3].Value.ToString()), dtMedicineStock.Rows[e.RowIndex].Cells[4].Value.ToString(),
                        dtMedicineStock.Rows[e.RowIndex].Cells[5].Value.ToString(), dtMedicineStock.Rows[e.RowIndex].Cells[7].Value.ToString(), dtMedicineStock.Rows[e.RowIndex].Cells[8].Value.ToString(),
                        double.Parse(dtMedicineStock.Rows[e.RowIndex].Cells[11].Value.ToString()));

                    DialogResult drs = VarClass.HelpFormResult("Përditëso Stokun",obj);
                    if (drs == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Ju lutem bëjeni refresh faqen ose provo të hapësh përsëri aplikacionin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtMedicineStock_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void dtMedicineStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtMedicineStock.Columns[e.ColumnIndex].Name == "Delete")
            {
                dtMedicineStock.Rows.RemoveAt(e.RowIndex);
            }
            else if (dtMedicineStock.Columns[e.ColumnIndex].Name == "Edit")
            {
                dtMedicineStock.RowTemplate.ReadOnly = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dtMedicineStock.Rows)
                {
                    bool isChecked = Convert.ToBoolean(dtMedicineStock.Rows[row.Index].Cells["Chck"].Value);
                    if (isChecked)
                    {
                        //@Id ,@Name ,@Gnrc , @ExpDate , @Rate , @DatePurchase ,@BatchId nvarchar(100)
                        command.InsertDb("Exec UpdatePurchase @Id = '" + dtMedicineStock.Rows[row.Index].Cells[3].Value + "',@Name = '" + dtMedicineStock.Rows[row.Index].Cells[4].Value + "',@Gnrc = '" + dtMedicineStock.Rows[row.Index].Cells[5].Value + "', @ExpDate ='" + Convert.ToDateTime(dtMedicineStock.Rows[row.Index].Cells[8].Value).ToString("yyyy-MM-dd") + "' , @Rate = '" + dtMedicineStock.Rows[row.Index].Cells[11].Value + "' , @DatePurchase ='" + DateTime.Now.ToString("yyyy-MM-dd") + "',@BatchId ='" + dtMedicineStock.Rows[row.Index].Cells[7].Value + "';");
                        num++;
                        dtMedicineStock.Rows[row.Index].Cells["Chck"].Value = false;
                    }
                }
                VarClass.ShowMsgBox($"U përditësuan me sukses\n Numri Rreshtave {num} ","Me sukses", 3);
                LoadData();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void UpdateData()
        //{
        //    try
        //    {
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            try
            {
                dtMedicineStock.DataSource = command.GetDataTable("Exec ExpandOut @numMeth = 1");
                if (dtMedicineStock.Rows.Count == 0)
                {
                    LoadData();
                    loadNumPages();
                    VarClass.ShowMsgBox($"Nuk ka asnjë Medisine të skaduar në Stok\nNumri Total : " + TotRecords, "Me sukses", 3);
                }
                //int visible = 0;
                //foreach (DataGridViewRow dr in dtMedicineStock.Rows)
                //{
                //    if (DateTime.Parse(dr.Cells["Ex. Date"].Value.ToString()).Date > DateTime.Now.Date)
                //    {
                //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //        currencyManager1.SuspendBinding();
                //        dtMedicineStock.Rows[dr.Index].Visible = false;
                //        visible++;
                //    }
                //}
                //if (visible == dtMedicineStock.Rows.Count)
                //{
                //    foreach (DataGridViewRow dr in dtMedicineStock.Rows)
                //    {
                //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //        currencyManager1.SuspendBinding();
                //        dtMedicineStock.Rows[dr.Index].Visible = true;

                //    }
                //    VarClass.ShowMsgBox($"Nuk ka asnjë Medisine të skaduar në Stok\nNumri Total : " + dtMedicineStock.RowCount, "Me sukses", 3);
                //}
                //totRows.Text = "Total i Rreshtave : " + visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnOutStock_Click(object sender, EventArgs e)
        {
            try
            {
                dtMedicineStock.DataSource = command.GetDataTable("Exec ExpandOut @numMeth = 0");
                if (dtMedicineStock.Rows.Count == 0)
                {
                    LoadData();
                    loadNumPages();
                    VarClass.ShowMsgBox($"Nuk ka asnjë Medisine jashtë Stokut\nNumri Total : " + TotRecords, "Me sukses", 3);
                }

                //int visible = 0;
                //foreach (DataGridViewRow dr in dtMedicineStock.Rows)
                //{
                //    if (int.Parse(dr.Cells["Qty"].Value.ToString()) > 0)
                //    {
                //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //        currencyManager1.SuspendBinding();
                //        dtMedicineStock.Rows[dr.Index].Visible = false;
                //        visible++;
                //    }
                //}
                //if (visible == dtMedicineStock.RowCount)
                //{
                //    foreach (DataGridViewRow dr in dtMedicineStock.Rows)
                //    {
                //        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //        currencyManager1.SuspendBinding();
                //        dtMedicineStock.Rows[dr.Index].Visible = true;

                //    }
                //    VarClass.ShowMsgBox($"Nuk ka asnjë Medisine jashtë Stokut\nNumri Total : " + +dtMedicineStock.RowCount, "Me sukses", 3);
                //}
                //totRows.Text = "Total i Rreshtave : " + visible;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtMedicineStock_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row that was changed
            if (dtMedicineStock.Rows.Count > 0)
            {
                dtMedicineStock.Rows[e.RowIndex].Cells[2].Value = true;
            }
           
        }

        private void dtMedicineStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "Id")
            {
                dtMedicineStock.Columns[e.ColumnIndex].Visible = false;
            }
            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "Qty")
            {
                dtMedicineStock.Columns[e.ColumnIndex].ReadOnly = true;
            }
            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "Supplier")
            {
                dtMedicineStock.Columns[e.ColumnIndex].ReadOnly = true;
            }
        }

        private void dtMedicineStock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totRows.Text ="Total i Rreshtave : " +dtMedicineStock.Rows.Count.ToString() ;
        }

        private void dtMedicineStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count.ToString();
        }

        private void txtMedicine_TextChanged(object sender, EventArgs e)
        {
            if (txtMedicine.Text != "")
            {
                try
                {
                    dtMedicineStock.DataSource = command.GetDataTable("Exec LoadSearchStock @nmdc='" + txtMedicine.Text + "',@gnrc ='" + txtGeneric.Text + "',@supplier = '" + txtSupplier.Text + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                //if (dtMedicineStock.RowCount > 0)
                //{
                //    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //    currencyManager1.SuspendBinding();
                //    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                //    {
                //        if (txtGeneric.Text != "" || txtSupplier.Text != "")
                //        {
                //            item.Visible = (item.Cells["Name"].Value.ToString().ToLower().Contains(txtMedicine.Text.ToLower())
                //                 && (item.Cells["Generic Name"].Value.ToString().ToLower().Contains(txtGeneric.Text.ToLower()) && item.Cells["Supplier"].Value.ToString().ToLower().Contains(txtSupplier.Text.ToLower())));
                //        }
                //        else
                //            item.Visible = (item.Cells["Name"].Value.ToString().ToLower().Contains(txtMedicine.Text.ToLower()));

                //    }
                //    VisbleRows();
                //}
            }
            else
            {
                if (txtGeneric.Text == "" && txtSupplier.Text == "")
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
        private void txtGeneric_TextChanged(object sender, EventArgs e)
        {
            if (txtGeneric.Text != "")
            {

                try
                {
                    dtMedicineStock.DataSource = command.GetDataTable("Exec LoadSearchStock @nmdc='" + txtMedicine.Text + "',@gnrc ='" + txtGeneric.Text + "',@supplier = '" + txtSupplier.Text + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //if (dtMedicineStock.RowCount > 0)
                //{
                //    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //    currencyManager1.SuspendBinding();
                //    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                //    {

                //        if (txtMedicine.Text != "" || txtSupplier.Text != "")
                //        {
                //            item.Visible = (item.Cells["Generic Name"].Value.ToString().ToLower().Contains(txtGeneric.Text.ToLower())
                //                 && (item.Cells["Supplier"].Value.ToString().ToLower().Contains(txtSupplier.Text.ToLower()) && item.Cells["Name"].Value.ToString().ToLower().Contains(txtMedicine.Text.ToLower())));
                //        }
                //        else
                //            item.Visible = (item.Cells["Generic Name"].Value.ToString().ToLower().Contains(txtGeneric.Text.ToLower()));
                //    }
                //    VisbleRows();
                //}
            }
            else
            {
                if (txtMedicine.Text == "" && txtSupplier.Text == "")
                {
                    LoadData();
                }
            }
                
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            if (txtSupplier.Text != "")
            {
                try
                {
                    dtMedicineStock.DataSource = command.GetDataTable("Exec LoadSearchStock @nmdc='" + txtMedicine.Text + "',@gnrc ='" + txtGeneric.Text + "',@supplier = '" + txtSupplier.Text + "'");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //if (dtMedicineStock.RowCount > 0)
                //{
                //    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dtMedicineStock.DataSource];
                //    currencyManager1.SuspendBinding();
                //    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                //    {

                //        if (txtMedicine.Text != "" || txtGeneric.Text != "")
                //        {
                //            item.Visible = (item.Cells["Supplier"].Value.ToString().ToLower().Contains(txtSupplier.Text.ToLower())
                //                 && (item.Cells["Name"].Value.ToString().ToLower().Contains(txtMedicine.Text.ToLower()) && item.Cells["Generic Name"].Value.ToString().ToLower().Contains(txtGeneric.Text.ToLower())));
                //        }
                //        else
                //            item.Visible = (item.Cells["Supplier"].Value.ToString().ToLower().Contains(txtSupplier.Text.ToLower()));
                //    }
                //}
                //VisbleRows();
            }
            else
            {
                if (txtMedicine.Text == "" && txtGeneric.Text == "")
                {
                    LoadData();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void forwardmove_Click(object sender, EventArgs e)
        {

            if (currentpages >= totPage)
            {
                currentpages = totPage;
                LoadData();
            }
            else
            {
                currentpages++;
                lblnum.Text = currentpages + "/" + totPage.ToString();
                LoadData();
            }
        }

        private void backmove_Click(object sender, EventArgs e)
        {
            if (currentpages > 1)
            {
                currentpages--;
                lblnum.Text = currentpages + "/" + totPage.ToString();
                LoadData();
            }
            else
            {
                currentpages = 1;
                LoadData();
            }
        }
    }
}
