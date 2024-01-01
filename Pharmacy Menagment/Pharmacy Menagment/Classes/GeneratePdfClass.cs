using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Pharmacy_Menagment.Classes
{
    public class GeneratePdfClass
    {
        private static int _Qty = 0;
        private static int Sasiaembushur = 0;
        private static string pack = "";
        public static void ExportPdfFile(string filePath,DataGridView dataGridView,string dategen,Form obj,bool wichReport) 
        {

            string newtit = (wichReport) ? "Raporti Shitjeve" : "Raporti Blerjeve";

            // Shtoni një vijë të gjatë në dokument
            LineSeparator line = new LineSeparator();
            Paragraph space = new Paragraph("\n", FontFactory.GetFont(FontFactory.HELVETICA, 12f));


            iTextSharp.text.Document document = new iTextSharp.text.Document();
            // Krijoni një objekt PdfWriter për të shkruar në skedarin PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Hapni dokumentin për të filluar të shkruani të dhënat
            document.Open();





            Paragraph title = new Paragraph(newtit, FontFactory.GetFont(FontFactory.HELVETICA, 30f));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);
            document.Add(space);

            //Shtoni logo në qendër të dokumentit
            System.Drawing.Image image = Properties.Resources.icons8_pharmacy_60;
            iTextSharp.text.Image logoImage = iTextSharp.text.Image.GetInstance(image, System.Drawing.Imaging.ImageFormat.Png);
            logoImage.ScaleToFit(60f, 60f); // Përshtatet në një kuar me madhësi të caktuar (200 piksela në gjerësi dhe 200 piksela në lartësi)

            // Vendosni madhësinë dhe pozicionin e imazhit në dokument
            logoImage.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
            //logoImage.SetAbsolutePosition((document.PageSize.Width - logoImage.ScaledWidth) / 2, document.PageSize.Height - 100);
            // Shto imazhin në dokument
            document.Add(logoImage);


            Paragraph Firm = new Paragraph("My Medicine", FontFactory.GetFont(FontFactory.HELVETICA, 10f));
            Firm.Alignment = Element.ALIGN_RIGHT;
            document.Add(Firm);


            // Shtoni datën ndermjet datave




            Paragraph para = new Paragraph("My Medicine Pharmacy", FontFactory.GetFont(FontFactory.HELVETICA, 10f));
            para.Alignment = Element.ALIGN_LEFT;
            document.Add(para);

            Paragraph Menager = new Paragraph("Menagjer: Valdrin Hasallari", FontFactory.GetFont(FontFactory.HELVETICA, 10f));
            Menager.Alignment = Element.ALIGN_LEFT;
            document.Add(Menager);

            // Shtoni datën dhe orën e sotme në fund të dokumentit
            Paragraph dateParagraph = new Paragraph("Data e Gjenerimit: " + DateTime.Now.ToString("dd/MMM/yyyy"), FontFactory.GetFont(FontFactory.HELVETICA, 10f));
            dateParagraph.Alignment = Element.ALIGN_RIGHT;
            document.Add(dateParagraph);

            Paragraph dategenerate = new Paragraph("Perioda e Raportit: " + dategen, FontFactory.GetFont(FontFactory.HELVETICA, 10f));
            dategenerate.Alignment = Element.ALIGN_RIGHT;
            document.Add(dategenerate);


            document.Add(space);
            document.Add(line);
            document.Add(space);


            // Krijoni një objekt PdfPTable për të paraqitur tabelën
            PdfPTable table = new PdfPTable(dataGridView.Columns.Count);

            iTextSharp.text.Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 8f); // Zvogëlo madhësinë e fontit në 8

            // Shtoni kolumnat në tabelë dhe vendosni stilin për secilën prej tyre
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, cellFont));
                cell.BackgroundColor = new BaseColor(Color.LightGray);
                table.AddCell(cell);
            }

            double total = 0;
            // Shtoni rreshtat dhe vlerat për secilën qelizë në tabelë
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (wichReport)
                    total += (double.TryParse(row.Cells[3].Value.ToString(), out _)) ? double.Parse(row.Cells[3].Value.ToString()) : 0;
                else
                    total += (double.TryParse(row.Cells[9].Value.ToString(), out _)) ? double.Parse(row.Cells[9].Value.ToString()) : 0;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string dateValue = cell.Value is DateTime ? ((DateTime)cell.Value).ToShortDateString() : cell.Value.ToString();
                    PdfPCell cells = new PdfPCell(new Phrase(dateValue, cellFont));
                    table.AddCell(cells);
                }
            }

            document.Add(space);
            document.Add(line);
            table.WidthPercentage = 100;
            table.SetWidths(GetColumnWidths(dataGridView));

            // Shtoni tabelën në dokument
            document.Add(table);

            document.Add(space);
            // Shtoni totalin në fund të dokumentit
            Paragraph tot = new Paragraph($"Totali i Rreshtave : {dataGridView.RowCount}                   Totali : {total}€", FontFactory.GetFont(FontFactory.HELVETICA, 12f));
            tot.Alignment = Element.ALIGN_RIGHT;
            document.Add(tot);
            //


            if (VarClass.Description && wichReport == false)
            {
                document.Add(space);
                document.Add(line);
                if (dataGridView.Rows.Count > 14)
                {
                    writer.NewPage();
                }
                Paragraph persh = new Paragraph("Përshkrimi", FontFactory.GetFont(FontFactory.HELVETICA, 12f));
                persh.Alignment = Element.ALIGN_CENTER;
                document.Add(persh);
                document.Add(space);


                string msg = "Produkti më i blerë:\r\n" +
                  $"Emri i produktit më të bler është {MostValueRepated(dataGridView)}. Gjatë periudhës së analizuar, ka qenë produkti më i blerë në farmaci.\r\n" +
                  $"Sasia totale e blerë për këtë produkt është {pack}. Kjo tregon një kërkesë të lartë dhe përdorim të gjërë të këtij produkti nga klientët e farmacisë.\r\n" +
                  "\r\nFurnizuesi me shumë furnizime:\r\n" +
                  $"Emri i furnizuesit që ka siguruar më shumë furnizime është Kompania {MostRepatedVlaueString(dataGridView, 2)}. Ky furnizues ka ofruar produkte të ndryshme për farmacitë dhe ka qenë i pranishëm në shumë transaksione të blerjes gjatë periudhës së raportuar.\r\n" +
                  "\r\nProdukti me rimbursimin më të madh në stok:\r\n" +
                  $"Një produkt tjetër i rëndësishëm është  {MostValueRepatedRem(dataGridView)}, i cili ka pasur një sasi të rimbursuar prej {Sasiaembushur}. Ky tregues tregon se ka pasur një kthim të madh të këtij produkti në stok, gjë që mund të lidhet me kërkesën e lartë për të dhe efektivitetin e tij në trajtimin e ndryshëm të dhimbjeve.";
                Paragraph Desc = new Paragraph(msg, FontFactory.GetFont(FontFactory.HELVETICA, 8f));
                Desc.Alignment = Element.ALIGN_LEFT;
                document.Add(Desc);

            }
            if (VarClass.ChartGen)
            {
                iTextSharp.text.Image Chart = iTextSharp.text.Image.GetInstance(GenerateChartPdt(dataGridView), System.Drawing.Imaging.ImageFormat.Jpeg);
                Chart.ScaleToFit(120f, 120f); // Përshtatet në një kuar me madhësi të caktuar (200 piksela në gjerësi dhe 200 piksela në lartësi)

                // Vendosni madhësinë dhe pozicionin e imazhit në dokument
                Chart.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                //logoImage.SetAbsolutePosition((document.PageSize.Width - logoImage.ScaledWidth) / 2, document.PageSize.Height - 100);
                // Shto imazhin në dokument
                document.Add(Chart);
            }
            



            document.Close();

            obj.Close();

            string NameValue = (wichReport) ? "RS" : "RB";
            if (!CfgFile.IfFileExcist())
            {
                CfgFile.CreateCfg(NameValue, "1");
            }
            else
            {
                if (!CfgFile.CheckLinesIndCfg(NameValue))
                {
                    CfgFile.AddnewLine(NameValue, "1");
                }
                else
                {
                    CfgFile.IncreaseNumber(NameValue);
                }
            }
            VarClass.ShowMsgBox("U gjenerua raporti me sukses", "Me sukses", 3);
        }

        private static System.Drawing.Image GenerateChartPdt(DataGridView dataGridView)
        {
            // Krijoni një listë për të ruajtur të dhënat e marrura nga datagridview
            List<decimal> dataPoints = new List<decimal>();

            // Iteroni nëpër rreshtat e datagridview dhe merrni vlerat e kolonës së nevojshme
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                decimal value = Convert.ToInt32(row.Cells["Sasia ne Euro"].Value);
                dataPoints.Add(value);
            }

            // Krijoni grafikun dhe plotësoni me të dhënat e marrura
            Chart chart = new Chart();
            chart.Series.Add("Euro");
            chart.Series["Euro"].Points.AddXY("Test",12);
            chart.Series["Euro"].Points.AddXY("Test", 12);
            chart.Series["Euro"].Points.AddXY("Test", 12);
            chart.Series["Euro"].Points.AddXY("Test", 12);
            chart.Series["Euro"].Points.AddXY("Test", 12);
            chart.Series["Euro"].Points.AddXY("Test", 12);
            chart.Series["Euro"].Points.AddXY("Test", 12);


            // ...

            // Shfaq grafikun në një PictureBox ose në një kontrol tjetër të përshtatshëm në aplikacionin tuaj C#
            MemoryStream ms = new MemoryStream();

            // Vendosni grafikun në MemoryStream në formatin e imazhit PNG
            chart.SaveImage(ms, ChartImageFormat.Png);

            // Krijoni imazhin nga MemoryStream
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

            // Shfaq imazhin në PictureBox ose në një kontroll tjetër të përshtatshëm në aplikacionin tuaj C#
            return image;
        }

        private static float[] GetColumnWidths(DataGridView dataTable)
        {
            int columnCount = dataTable.Columns.Count;
            float[] columnWidths = new float[columnCount];

            // Cakto gjatësinë e kolonave sipas nevojës
            // Këtu mund të caktoni vlerat në mënyrë të ndërvarur sipas logjikës suaj
            for (int i = 0; i < columnCount; i++)
            {
                columnWidths[i] = 250f; // Gjatësia e kolonës në piksel
            }

            return columnWidths;
        }
        static string MostRepatedVlaueString(DataGridView dt, int columnIndex)
        {
            // Identifikoni indeksin e kolonës në DataGridView

            // Krijo një dictionary për të numëruar përsëritjet
            Dictionary<object, int> countDictionary = new Dictionary<object, int>();

            // Iteroni në të gjitha rreshtat e DataGridView
            foreach (DataGridViewRow row in dt.Rows)
            {
                // Merr vlerën për kolonën e caktuar
                object value = row.Cells[columnIndex].Value;

                // Kontrollo nëse vlera ekziston në dictionary
                if (countDictionary.ContainsKey(value))
                {
                    // Shto një përsëritje në vlerën e dictionary
                    countDictionary[value]++;
                }
                else
                {
                    // Shto vlerën në dictionary me përsëritje 1
                    countDictionary.Add(value, 1);
                }
            }

            // Gjej vlerën me numrin më të madh të përsëritjeve
            int maxCount = countDictionary.Values.Max();
            object mostRepeatedValue = countDictionary.FirstOrDefault(x => x.Value == maxCount).Key;

            // Tani keni vlerën më të përsëritur në kolonën e specifikuar
            return mostRepeatedValue.ToString();
        }
        static string MostValueRepated(DataGridView dt)
        {
            try
            {
                // Identifikoni indeksin e kolonës "Qty" në DataGridView

                // Variablat për të mbajtur vlerën maksimale dhe rreshtin korrespondues
                int maxQty = int.MinValue;
                DataGridViewRow maxQtyRow = null;

                // Iteroni në të gjitha rreshtat e DataGridView
                foreach (DataGridViewRow row in dt.Rows)
                {
                    // Merr vlerën në kolonën "Qty"
                    int qtyValue = Convert.ToInt32(row.Cells["Qty"].Value);

                    // Kontrollo nëse vlera është më e madhe se vlera maksimale aktuale
                    if (qtyValue > maxQty)
                    {
                        // Përditëso vlerën maksimale dhe rreshtin korrespondues
                        maxQty = qtyValue;
                        maxQtyRow = row;
                    }
                }

                // Kontrollo nëse është gjetur një vlerë maksimale
                if (maxQtyRow != null)
                {
                    // Merr vlerën e kolonës tjetër për rreshtin me vlerën maksimale të "Qty"
                    object otherColumnValue = maxQtyRow.Cells["Emri"].Value; // Ndryshoni otherColumnIndex me indeksin e kolonës tjetër që dëshironi
                    _Qty = maxQty;

                    string num = "";
                    string packname = "";
                    foreach (char item in maxQtyRow.Cells["Paketimi"].Value.ToString())
                    {
                        if (int.TryParse(item.ToString(), out _))
                        {
                            num += item.ToString();
                        }
                        else
                            packname += item.ToString();

                    }
                    pack = $"{_Qty * Convert.ToInt32(num)} {packname}";
                    // Shfaq vlerën e dëshiruar
                    return otherColumnValue.ToString();
                }
            }
            catch
            {
            }
           

            return "";
        }
        static string MostValueRepatedRem(DataGridView dt)
        {
            try
            {
                // Identifikoni indeksin e kolonës "Qty" në DataGridView

                // Variablat për të mbajtur vlerën maksimale dhe rreshtin korrespondues
                int maxQty = int.MinValue;
                DataGridViewRow maxQtyRow = null;

                // Iteroni në të gjitha rreshtat e DataGridView
                foreach (DataGridViewRow row in dt.Rows)
                {
                    int qtyValue = 0;
                    // Merr vlerën në kolonën "Qty"
                    if (row.Cells["Rimbushur"].Value != null)
                    {
                        qtyValue = Convert.ToInt32(row.Cells["Rimbushur"].Value.ToString());
                    }

                    // Kontrollo nëse vlera është më e madhe se vlera maksimale aktuale
                    if (qtyValue > maxQty)
                    {
                        // Përditëso vlerën maksimale dhe rreshtin korrespondues
                        maxQty = qtyValue;
                        maxQtyRow = row;
                    }
                }

                // Kontrollo nëse është gjetur një vlerë maksimale
                if (maxQtyRow != null)
                {
                    // Merr vlerën e kolonës tjetër për rreshtin me vlerën maksimale të "Qty"
                    object otherColumnValue = maxQtyRow.Cells["Emri"].Value; // Ndryshoni otherColumnIndex me indeksin e kolonës tjetër që dëshironi
                                                                             // Shfaq vlerën e dëshiruar
                    if (maxQtyRow.Cells["Rimbushur"].Value != null)
                    {
                        Sasiaembushur = int.Parse(maxQtyRow.Cells["Rimbushur"].Value.ToString());
                    }
                    else
                        Sasiaembushur = 0;

                    return otherColumnValue.ToString();
                }
            }
            catch 
            {
            }

            return "";
        }
    }
}
