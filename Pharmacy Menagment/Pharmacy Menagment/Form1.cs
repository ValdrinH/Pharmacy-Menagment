using Pharmacy_Menagment.Classes;
using Pharmacy_Menagment.UserControlsItem;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Pharmacy_Menagment
{
    public partial class DashBoard : Form
    {
        //Per te shikuar nese jan shfaqur subMenu Panels               
        bool pnlm = false, pnli = false, pnls = false, pnlp = false, pnlk = false;
        bool pnlMove = false;
        //Usercontrols
        AddNewMedicineItem addNewMedicine = new AddNewMedicineItem();
        AddPurchaseItem purchaseItem = new AddPurchaseItem();
        MedicineStockItem medicineStock = new MedicineStockItem();
        SuppliersItem suppliers = new SuppliersItem();
        CreateInvoice invoice = new CreateInvoice();
        InoviceManage inoviceManage = new InoviceManage();
        CreateCostumer costumer = new CreateCostumer();
        RaportGenerate raport = new RaportGenerate();

        //objektet ne menyr statike te qasshme
        public static List<Panel> panels = new List<Panel>();
        public static Object obj = new Object();
        public static List<Object> objclass = new List<Object>();


        //Per te mbartur formen me maus nese e mbajm down
        private bool mouseDown;
        private Point lastLocation;

        //Mundeson per te ber Round Formen
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
        public DashBoard()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubButtonsMenu(object sender, EventArgs e)
        {
            var objBtn = sender as Button;

            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;

            if (objBtn.Tag.ToString() == "1")
            {
                LoadUsers(medicineStock);
                pnlm = false;
            }
            else if (objBtn.Tag.ToString() == "2")
            {
                LoadUsers(addNewMedicine);
                pnlm = false;
            }
            else if (objBtn.Tag.ToString() == "3")
            {
                pnli = false;
            }
            else if (objBtn.Tag.ToString() == "4")
            {
                LoadUsers(invoice);
                pnli = false;
            }
            else if (objBtn.Tag.ToString() == "5")
            {
                pnls = false;
            }
            else if (objBtn.Tag.ToString() == "6")
            {
                LoadUsers(suppliers);
                pnls = false;
            }
            else if (objBtn.Tag.ToString() == "7")
            {
                pnlp = false;
            }
            else if (objBtn.Tag.ToString() == "8")
            {
                LoadUsers(purchaseItem);
                pnlp = false;
            }
            else if (objBtn.Tag.ToString() == "9")
            {
                
            }
            else if (objBtn.Tag.ToString() == "10")
            {
                pnlk = false;
            }

        }

        private void ProgramActioni(object sender, EventArgs e)
        {
            var obj = sender as PictureBox;

            if(obj.Tag.ToString() == "1")
            {
                Application.Exit();
            }
            else
            {
                this.WindowState= FormWindowState.Minimized;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) { WindowState = FormWindowState.Maximized; }
            else { WindowState = FormWindowState.Normal; }
        }


        private void picMenu_Click(object sender, EventArgs e)
        {
            CMenuStrip.Show(picMenu, new Point(0, picMenu.Height));
        }

        private void MenaxhoShtoKlienta_Click(object sender, EventArgs e)
        {
            LoadUsers(costumer);
            TitleText("Klientat");
        }

        private void DashboardMenu_Click(object sender, EventArgs e)
        {
            DashboardItem dshb = new DashboardItem();
            LoadUsers(dshb);
            TitleText("Dashboard");

        }

        private void ManageMedicine_Click(object sender, EventArgs e)
        {
            LoadUsers(addNewMedicine);
            TitleText("Barnat");

        }

        private void StockManage_Click(object sender, EventArgs e)
        {
            LoadUsers(medicineStock);
            TitleText("Barnat");

        }

        private void CMenuStrip_Click(object sender, EventArgs e)
        {
       
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUsers(raport);
            TitleText("Report");

        }

        private void menaxhoBlerjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TitleText("Blerjet");
        }

        private void shtoBlerjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUsers(purchaseItem);
            TitleText("Blerjet");

        }

        private void shtoMenaxhoFurnizuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUsers(suppliers);
            TitleText("Furnizues");
        }
        void TitleText(string text)
        {
            Title.Text = text;
            Title.Location = new Point((pnlButtons.Width - Title.Width) / 2, (pnlButtons.Height - Title.Height) / 2);
        }

        private void shtoFaturTÎReToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUsers(invoice);
            TitleText("Faturat");
        }

        private void menxhoFatuartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUsers(inoviceManage);
            TitleText("Faturat");
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            //if (loginForm.DialogResult == DialogResult.OK)
            //{
            //    this.Enabled = true;
            //}
            //else
            //    Application.Exit();

            this.Enabled = true;


            Title.Location = new Point((pnlButtons.Width - Title.Width) / 2, (pnlButtons.Height - Title.Height) / 2);

            DashboardItem dshb = new DashboardItem();
            obj = Body;
            LoadUsers(dshb);

            objclass.Add(dshb);
            objclass.Add(addNewMedicine);
            objclass.Add(purchaseItem);
            objclass.Add(medicineStock);
            objclass.Add(suppliers);
            objclass.Add(invoice);
            objclass.Add(costumer);
            objclass.Add(raport);


        }

        void LoadUsers(UserControl userControl)
        {
            Body.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Body.Controls.Add(userControl);

        }
        private void MenuButtons(object sender, EventArgs e)
        {
            var objBtn = sender as Button;
            PanelMenu.Width = 169;
            pnl1.Visible = false;
            pnl2.Visible = false;
            pnl3.Visible = false;
            pnl4.Visible = false;
            pnl5.Visible = false;
           
            //click = false;

            if (objBtn.Tag.ToString() == "1")
            {
                DashboardItem dshb = new DashboardItem();
                LoadUsers(dshb);
            }
            else if (objBtn.Tag.ToString() == "2")
            {
                if (pnlk == false)
                {
                    if (pnl5.Visible == false)
                    {
                        pnlm = false;
                        pnli = false;
                        pnls = false;
                        pnlp = false;
                        pnlk = true;

                        pnl5.Visible = true;

                    }
                }
                else
                {
                    pnl5.Visible = false;
                    pnlk = false;
                }
            }
            else if (objBtn.Tag.ToString() == "3")
            {
                if (pnlm == false)
                {
                    if (pnl1.Visible == false)
                    {
                        pnlm = true;
                        pnli = false;
                        pnls = false;
                        pnlp = false;
                        pnlk= false;

                        pnl1.Visible = true;

                    }
                }
                else
                {
                    pnl1.Visible = false;
                    pnlm = false;
                }
            }
            else if (objBtn.Tag.ToString() == "4")
            {
                if (pnli == false)
                {
                    if (pnl2.Visible == false)
                    {
                        pnl2.Visible = true;
                        pnli = true;
                        pnlm = false;
                        pnls = false;
                        pnlp = false;
                        pnlk = false;

                    }

                }
                else
                {
                    pnl2.Visible = false;
                    pnli = false;

                }

            }
            else if (objBtn.Tag.ToString() == "5")
            {
                if (pnls == false)
                {
                    if (pnl3.Visible == false)
                    {
                        pnl3.Visible = true;
                        pnls = true;
                        pnlm = false;
                        pnli = false;
                        pnlp = false;
                        pnlk = false;

                    }
                }
                else
                {
                    pnl3.Visible = false;
                    pnls= false;
                }

            }
            else if (objBtn.Tag.ToString() == "6")
            {

                if (pnlp == false)
                {
                    if (pnl4.Visible == false)
                    {
                        pnl4.Visible = true;
                        pnls = false;
                        pnlm = false;
                        pnli = false;
                        pnlp = true;
                        pnlk = false;

                    }
                }
                else
                {
                    pnl4.Visible = false;
                    pnlp = false;
                }
            }
            else if (objBtn.Tag.ToString() == "7")
            {
                LoadUsers(raport);
            }

        }


        //private void button3_MouseLeave(object sender, EventArgs e)
        //{
        //    //var objBtn = sender as Button;
        //    //if (objBtn.Tag.ToString() == "3")
        //    //{
        //    //    if (click1)
        //    //    {
        //    //        if (pnl1.Visible == true)
        //    //            pnl1.Visible = false;
        //    //    }
               
        //    //}
        //    //else if (objBtn.Tag.ToString() == "4")
        //    //{
        //    //    if (pnl2.Visible == true)
        //    //        pnl2.Visible = false;

        //    //}
        //    //else if (objBtn.Tag.ToString() == "5")
        //    //{
        //    //    if (pnl3.Visible == true)
        //    //        pnl3.Visible = false;

        //    //}


        //}

        //private void button5_MouseHover(object sender, EventArgs e)
        //{
        //    //var objBtn = sender as Button;
        //    //pnl1.Visible = false;
        //    //pnl2.Visible = false;
        //    //pnl3.Visible = false;
        //    //if (objBtn.Tag.ToString() == "3")
        //    //{
        //    //    if (pnl1.Visible == false)
        //    //        pnl1.Visible = true;
        //    //}
        //    //else if (objBtn.Tag.ToString() == "4")
        //    //{
        //    //    if (pnl2.Visible == false)
        //    //        pnl2.Visible = true;

        //    //}
        //    //else if (objBtn.Tag.ToString() == "5")
        //    //{
        //    //    if (pnl3.Visible == false)
        //    //        pnl3.Visible = true;

        //    //}
          
        //}
    }
}