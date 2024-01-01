using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class InoviceManage : UserControl
    {
        public InoviceManage()
        {
            InitializeComponent();
        }

        private void dtMedicineStock_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count.ToString();
        }

        private void dtMedicineStock_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            totRows.Text = "Total i Rreshtave : " + dtMedicineStock.Rows.Count.ToString();
        }
    }
}
