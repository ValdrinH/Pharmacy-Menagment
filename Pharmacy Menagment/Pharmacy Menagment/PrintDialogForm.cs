using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Pharmacy_Menagment.Classes;

namespace Pharmacy_Menagment
{
    public partial class PrintDialogForm : Form
    {
        DataTable table;
        string dategen = "";
        bool iftwo = false;

        private bool mouseDown;
        private Point lastLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public PrintDialogForm(DataTable dataTable,string date,bool twodate)
        {
            table = dataTable;
            dategen = date;
            iftwo = twodate;
            InitializeComponent();
        }

        private void PrintDialogForm_Load(object sender, EventArgs e)
        {
            dtMedicineStock.DataSource= table;


            if (dtMedicineStock.Rows.Count <= 0)
            {
                VarClass.ShowMsgBox("Nuk u gjet asnjë rekord! ", "Gabim", 1);
                this.Close();

            }
            lblTitle.Location = new Point((TopPanel.Width - lblTitle.Width) / 2, (TopPanel.Height - lblTitle.Height) / 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void dtMedicineStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (dtMedicineStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || string.IsNullOrWhiteSpace(dtMedicineStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                {
                    e.CellStyle.BackColor = Color.Red; // Ndryshoni ngjyrën e bazës së qelizës sipas dëshirës
                    e.CellStyle.ForeColor = Color.White; // Ndryshoni ngjyrën e tekstit të qelizës sipas dëshirës
                    dtMedicineStock.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
            catch
            {

            }
           
        }

        private void Generate_Click(object sender, EventArgs e)
        {

            try
            {
                string path = "C:\\Gjenerimi i Reportave";
                string nameFile = (iftwo) ? "Raporti_Shitjeve.pdf" : "Raporti_Blerjeve.pdf";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string valuePath = Path.Combine(path, nameFile);
                if (File.Exists(Path.Combine(path, nameFile)))
                {
                    valuePath = KontrolloDheVendosNumerFile(Path.Combine(path, nameFile));
                }

                GeneratePdfClass.ExportPdfFile(valuePath, dtMedicineStock, dategen, this, iftwo);


            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine("Gabim në krijimin e dokumentit PDF: " + de.Message);
            }

           
        }
        public string KontrolloDheVendosNumerFile(string Filepath)
        {
            string fileExtension = Path.GetExtension(Filepath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(Filepath);

            int counter = 1;
            string newFilePath = Filepath;

            while (File.Exists(newFilePath))
            {
                string newFileName = $"{fileNameWithoutExtension}_{counter}{fileExtension}";
                newFilePath = Path.Combine("C:\\Gjenerimi i Reportave", newFileName);
                counter++;
            }

            return newFilePath;
        }

    }
}
