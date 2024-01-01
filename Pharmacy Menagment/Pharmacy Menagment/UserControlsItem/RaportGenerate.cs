using Pharmacy_Menagment.Classes;
using Pharmacy_Menagment.UserControlsItem.HelpFormChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class RaportGenerate : UserControl
    {
        CommandDatabase database = new CommandDatabase();
        static bool reportgem = false;
        bool SalePurchase = false;
        string _QuerryMedcineNames = "";
        public RaportGenerate()
        {
            InitializeComponent();
        }
        public void ChoseReportGenerate(bool line)
        {
            reportgem = line;
            if (reportgem == false)
            {
                LineLoc("panel14");
            }
            else
                LineLoc("panel13");

        }
        private void RaportGenerate_Load(object sender, EventArgs e)
        {
            bool value = (reportgem) ? false : true;
            GenerateOption(value);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            reportgem = true;
            GenerateOption(false);
            LineLoc("panel13");

        }
        void GenerateOption(bool value )
        {
            foreach (object item in this.Controls)
            {
                if (item is Krypton.Toolkit.KryptonLabel)
                {
                    var label = (Krypton.Toolkit.KryptonLabel)item;
                    if (label.Tag != null && label.Tag.ToString() == "1")
                    {
                        label.Visible = value;
                    }
                }
                else if (item is Krypton.Toolkit.KryptonTextBox)
                {
                    var text = (Krypton.Toolkit.KryptonTextBox)item;
                    if (text.Tag != null && text.Tag.ToString() == "1")
                    {
                        text.Visible = value;
                    }
                }
                else if (item is CheckBox)
                {
                    var check = (CheckBox)item;
                    if (check.Tag != null && check.Tag.ToString() == "1")
                    {
                        check.Checked = false;
                        check.Visible = value;
                    }
                }
            }
        }
        private void panel14_Click(object sender, EventArgs e)
        {
            reportgem = false;
            GenerateOption(true);
            LineLoc("panel14");
        }
        void LineLoc(string pn)
        {
            int positionX;
            Color color = Color.Firebrick;
            if (pn == "panel13")
            {
                positionX = panel13.Location.X;
                color = panel13.BackColor;
            }
            else
            {
                positionX = panel14.Location.X;
                color = panel14.BackColor;

            }
            Line.Location = new Point(positionX, Line.Location.Y);
            Line.BackColor = color;
        }

        private void betwenDate_CheckStateChanged(object sender, EventArgs e)
        {
            if (betwenDate.Checked)
            {
               lblDatam.Visible= true;
               dhe.Visible= true;
               dataMbarimit.Visible= true;
            }
            else
            {
                lblDatam.Visible = false;
                dhe.Visible = false;
                dataMbarimit.Visible = false;
            }

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (SalePurchase == false) //Raporti Shtijeve
                {
                    DateTime dateTime1 = dtFillimit.Value;
                    DateTime dateTime2 = dtFillimit.Value;

                    string dategen = dateTime1.ToString("dd/MM/yyyy");
                    if (betwenDate.Checked)
                    {
                        dateTime2 = dataMbarimit.Value; 
                        dategen += " deri " + dateTime2.ToString("dd/MM/yyyy");
                    }
                    DataTable dt = null;
                    if (reportgem )
                    {
                        dt = database.GetDataTable("Exec ReportInvoice @dataf = '" + dateTime1.ToString("yyyy-MM-dd") + "' ,@datam ='" + dateTime2.ToString("yyyy-MM-dd") + "'");
                    }
                    else
                        dt = database.GetDataTable("Exec PruchaseReport @Dataf = '" + dateTime1.ToString("yyyy-MM-dd") + "' ,@dataM ='" + dateTime2.ToString("yyyy-MM-dd") + "',@Supplier = '"+txtSupplier.Text+ "',@Sasia = '"+txtVlera.Text+"'");

                    PrintDialogForm printDialogForm = new PrintDialogForm(dt, dategen, reportgem);
                    printDialogForm.ShowDialog();


                }
                else // Raporti i Blerjeve
                {
                    //DataTable dt = database.GetDataTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chckPershkrim.Text = (chckPershkrim.Checked) ? "Po" : "Jo";
            VarClass.Description = chckPershkrim.Checked;
        }

        private void chckDiagram_CheckedChanged(object sender, EventArgs e)
        {
            chckDiagram.Text = (chckDiagram.Checked) ? "Po" : "Jo";
            VarClass.ChartGen = chckDiagram.Checked;
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSupplier_Enter(object sender, EventArgs e)
        {
            DialogResult drs = VarClass.HelpFormResult("Selekto Furnizuesin", new ListOfSupplier());
            if (drs == DialogResult.OK)
            {
                txtSupplier.Text = DetailsSupplierStruct.SName;
                Generate.Focus();
            }
            else
            {
                Generate.Focus();
            }
        }

        private void txtMedicineName_Enter(object sender, EventArgs e)
        {
            var obj = new GetMedicineDetails(true);
            DialogResult drs = VarClass.HelpFormResult("Selekto Medikamentin", obj);
          
            if (drs == DialogResult.OK)
            {
                try
                {
                    txtMedicineName.Text = DetailsMedicineStruct.MdcName;
                    Generate.Focus();
                    foreach (string item in GetMedicineDetails.NamesMedicine)
                    {
                        if (item != "")
                        {
                            _QuerryMedcineNames += item + ", ";
                        }
                    }
                    _QuerryMedcineNames.Remove(_QuerryMedcineNames.Length - 1);
                    MessageBox.Show(_QuerryMedcineNames);
                }
                catch 
                {
                }
                
            }
            else
            {
                Generate.Focus();
            }
        }

        private void txtVlera_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtVlera.Text,out _))
            {
                txtVlera.Text = "";
            }
        }

        private void RaportGenerate_Click(object sender, EventArgs e)
        {

        }
    }
}
