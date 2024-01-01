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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class DashboardItem : UserControl
    {
        CommandDatabase command = new CommandDatabase();
        public DashboardItem()
        {
            InitializeComponent();
        }
        private void SubMenuOption(object sender, EventArgs e)
        {
            var addmdc = (AddNewMedicineItem)DashBoard.objclass[1];
            UserControls(addmdc);
        }
        void UserControls(UserControl userControl)
        {
            var pnl = (Panel)DashBoard.obj;
            pnl.Controls.Clear();
            foreach (Panel item in DashBoard.panels)
            {
                if (item.Name == "pnl1")
                {
                    item.Location = new Point(529, -1);
                }
                else if (item.Name == "pnl2")
                {
                    item.Location = new Point(689, -1);
                }
                else if (item.Name == "pnl3")
                {
                    item.Location = new Point(854, -1);
                }
                else if (item.Name == "pnl4")
                {
                    item.Location = new Point(1007, -2);
                }

                pnl.Controls.Add(item);
            }
            userControl.Dock = DockStyle.Fill;
            pnl.Controls.Add(userControl);
        }

        private void SubMenuPurchase(object sender, EventArgs e)
        {
            var addprch = (AddPurchaseItem)DashBoard.objclass[2];
            UserControls(addprch);
        }

        private void SuppliersAdd(object sender, EventArgs e)
        {
            var addsupp = (SuppliersItem)DashBoard.objclass[4];
            UserControls(addsupp);
        }

        private void AddNewInvoices(object sender, EventArgs e)
        {
            var addInvc = (CreateInvoice)DashBoard.objclass[5];
            UserControls(addInvc);
        }

        private void Customer(object sender, EventArgs e)
        {
            var addCst = (CreateCostumer)DashBoard.objclass[6];
            UserControls(addCst);
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            
        }

        private void DashboardItem_Load(object sender, EventArgs e)
        {
            supp.Text = command.GetIdItem("SELECT [dbo].[Totals](1)").ToString()+"      ";
            medc.Text = command.GetIdItem("SELECT [dbo].[Totals](2)").ToString()+"      ";
            exp.Text = command.GetIdItem("SELECT [dbo].[Totals](3)").ToString() + "      ";
            outs.Text = command.GetIdItem("SELECT [dbo].[Totals](4)").ToString() + "      ";
            lblClient.Text = command.GetIdItem("SELECT [dbo].[Totals](5)").ToString() + "      ";
            lblfat.Text = command.GetIdItem("SELECT [dbo].[Totals](6)").ToString() + "      ";
            lblRb.Text = CfgFile.ReturntValue("RB") + "      ";
            lblRS.Text = CfgFile.ReturntValue("RS") + "      ";
        }

        private void DashboardItem_Click(object sender, EventArgs e)
        {

        }

        private void Shitjet(object sender, EventArgs e)
        {
            var addCst = (RaportGenerate)DashBoard.objclass[7];
            addCst.ChoseReportGenerate(true);
            UserControls(addCst);
        }

        private void ReportBlerje(object sender, EventArgs e)
        {
            var addCst = (RaportGenerate)DashBoard.objclass[7];
            addCst.ChoseReportGenerate(false);
            UserControls(addCst);
        }
    }
}
