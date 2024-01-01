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
    public partial class ListOfSupplier : UserControl
    {
        CommandDatabase command = new CommandDatabase();
        public ListOfSupplier()
        {
            InitializeComponent();
        }

        private void ListOfSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                dtSupplier.DataSource = command.GetDataTable("Exec ListOfSupplier");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtSupplier.Columns[e.ColumnIndex].Name == "SelectBtn")
            {
                DetailsSupplierStruct.SName = dtSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();

                var objPanel = (Panel)this.Parent;
                var objForms = (HelpFormDialog)objPanel.Parent;
                objForms.DialogResult = DialogResult.OK;
                objForms.Close();
            }
        }
    }
}
