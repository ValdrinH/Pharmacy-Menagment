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
    public partial class GetMedicineDetails : UserControl
    {
        CommandDatabase database = new CommandDatabase();
        private bool slcTable = false;
        public static List<string> NamesMedicine = new List<string>();
        public GetMedicineDetails(bool slcTable)
        {
            InitializeComponent();
            this.slcTable = slcTable;
        }

        private void GetMedicineDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (slcTable)
                {
                    dtMedicineStock.Columns[0].Visible = false;
                    dtMedicineStock.ReadOnly = false;
                }
                dtMedicineStock.Columns[1].Visible = slcTable;
                dtMedicineStock.Columns[2].Visible = slcTable;
                dtMedicineStock.DataSource =  database.GetDataTable("Exec MedicineDetails @GetVal = '"+VarClass.num+"'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtMedicineStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtMedicineStock.Columns[e.ColumnIndex].Name == "SelectBtn")
                {
                    DetailsMedicineStruct.MdcName = dtMedicineStock.Rows[e.RowIndex].Cells[3].Value.ToString();
                    DetailsMedicineStruct.MdcGenericName = dtMedicineStock.Rows[e.RowIndex].Cells[4].Value.ToString();
                    DetailsMedicineStruct.Supplier = dtMedicineStock.Rows[e.RowIndex].Cells[5].Value.ToString();
                    DetailsMedicineStruct._Id = Convert.ToInt32(dtMedicineStock.Rows[e.RowIndex].Cells[6].Value.ToString());

                    if (VarClass.num == 1)
                    {
                      
                        DetailsMedicineStruct.MdcBatch = dtMedicineStock.Rows[e.RowIndex].Cells[7].Value.ToString();
                        DetailsMedicineStruct.MdcExp = DateTime.Parse(dtMedicineStock.Rows[e.RowIndex].Cells[8].Value.ToString());
                        DetailsMedicineStruct.MdcQty = Convert.ToInt32(dtMedicineStock.Rows[e.RowIndex].Cells[9].Value.ToString());
                        DetailsMedicineStruct.MdcRate = Convert.ToDouble(dtMedicineStock.Rows[e.RowIndex].Cells[10].Value.ToString());
                    }

                    var objPanel = (Panel)this.Parent;
                    var objForms = (HelpFormDialog)objPanel.Parent;
                    objForms.DialogResult = DialogResult.OK;
                    objForms.Close();
                }
                else if (dtMedicineStock.Columns[e.ColumnIndex].Name == "Done")
                {
                    foreach (DataGridViewRow item in dtMedicineStock.Rows)
                    {
                        string name = (Convert.ToBoolean(item.Cells[2].Value) == true) ? item.Cells[3].Value.ToString() : "";
                        NamesMedicine.Add(name);
                    }
                    var objPanel = (Panel)this.Parent;
                    var objForms = (HelpFormDialog)objPanel.Parent;
                    objForms.DialogResult = DialogResult.OK;
                    objForms.Close();
                }

            }
            catch
            {

            }
           
        }

        private void dtMedicineStock_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void dtMedicineStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (this.dtMedicineStock.Columns[e.ColumnIndex].Name == "slc")
            {
                dtMedicineStock.Columns[e.ColumnIndex].ReadOnly = false;
            }

        }
    }
}
