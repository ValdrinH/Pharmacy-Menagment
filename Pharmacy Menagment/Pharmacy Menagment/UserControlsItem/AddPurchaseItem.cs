using Pharmacy_Menagment.Classes;
using Pharmacy_Menagment.UserControlsItem.HelpFormChildren;
using Pharmacy_Menagment.UserControlsItem.ItemChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class AddPurchaseItem : UserControl
    {
        int loadNum = 1,sec = 0, totInserted = 0, methodPayment = -1;
        bool err = false;
        CommandDatabase insert = new CommandDatabase();//Metodat Per komunikimin me databazen

        List<string> Names = new List<string>();
        List<ListItemMedicineDetails> ErrList = new List<ListItemMedicineDetails>();

        public AddPurchaseItem()
        {
            InitializeComponent();
        }

        private void AddPurchaseItem_Load(object sender, EventArgs e)
        {
            AddToList();
        }

        private void AddList_Click(object sender, EventArgs e)
        {
            AddToList();
        }
        void AddToList()
        {
            var obj = new ListItemMedicineDetails();
            obj.LabelNums = $"{loadNum++}";

            obj.EnterTxt += (ss, ee) =>
            {

                VarClass.num = 0;
                DialogResult drs = VarClass.HelpFormResult("Selekto Medikamentin", new GetMedicineDetails(false));
               
                if (drs == DialogResult.OK)
                {
                    bool check = false;
                    foreach (ListItemMedicineDetails item in pnlItemList.Controls)
                    {
                        if (item.txtMdcName != "")
                        {
                            if (DetailsMedicineStruct.MdcName.ToLower().Contains(item.txtMdcName.ToLower()))
                            {
                                check = true;
                            }
                        }

                    }
                    if (!check)
                    {
                        obj.txtMdcName = DetailsMedicineStruct.MdcName;
                        obj.txtGeneric = DetailsMedicineStruct.MdcGenericName;
                        obj.ID = DetailsMedicineStruct._Id;
                        //txtSupplier.Text = DetailsMedicineStruct.Supplier;
                        obj.txtGenericName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Medicina me këtë Emër: '" + DetailsMedicineStruct.MdcName + "' është selektuar një here.\nJu lutem zgjedhni një medicinë tjetër.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        obj.txtGenericName.Focus();
                    }




                }
                else
                    obj.txtGenericName.Focus();

            };
            obj.TototalAmount += (ss, ee) =>
            {

                TotalCalc();

            };

            pnlItemList.Controls.Add(obj);
        }
        void TotalCalc()
        {
            double total = 0;
            if (pnlItemList.Controls.Count > 0 )
            {
                foreach (ListItemMedicineDetails item in pnlItemList.Controls)
                {
                    if (item.txtAmount.Text != "")
                    {
                        double tot = Convert.ToDouble(item.txtAmount.Text);
                        total += tot;
                        txtNetTotal.Text = total.ToString() + "€";
                    }
                }
            }
            else
                txtNetTotal.Text = total.ToString() + "€";


        }
        private void Body_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int lengthControls = pnlItemList.Controls.Count;
            if (lengthControls != 0)
            {
                pnlItemList.Controls.RemoveAt(lengthControls - 1);
                loadNum--;
                TotalCalc();
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            int lengthControls = pnlItemList.Controls.Count;
            if (lengthControls > 0)
            {
                try
                {
                    methodPayment = GetNum(PaymetMethod.Text);
                    using (var objWait = new LoadingScreen(InsertWithLs, "Po Insertoen të dhënat\nJu lutem prisni..."))
                    {
                        objWait.ShowDialog(this);
                        if (objWait.DialogResult == DialogResult.OK)
                        {
                            if (!err)
                            {
                                AddToList();
                                SortingofObjects();
                            }
                        }
                    }
                    SortingofObjects();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }
        private void SortingofObjects()
        {
            int numCalc = 1;
            foreach (ListItemMedicineDetails item in pnlItemList.Controls)
            {
                item.LabelNums = numCalc.ToString();
                numCalc++;
            }
        }
        void InsertWithLs()
        {
            try
            {
                foreach (ListItemMedicineDetails item in pnlItemList.Controls)
                {
                    if (item.txtMdcName != "" && item.txtGeneric != "" && item.QtyTxt.Text != "" && item._batch != "" && item._rate != 0 && item.ID != -1 && item.txtDate.Text != "" && txtSupplier.Text != "")
                    {
                        if (insert.GetIdItem("Exec GetIdElement @Id = '" + item.ID + "'") == 0)
                        {
                            insert.InsertDb("Exec AddPurchase @Id = '" + item.ID + "', @BatchId  = '" + item._batch + "', @ExpDate  = '" + item.ExpDate.ToString("yyyy-MM-dd") + "',@Qty  = '" + item._qty + $"' , @Rate = '"+item._rate+"' ,@DatePurchase = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' , @Supplier = '" + txtSupplier.Text + "' , @Payment_Type = '" + methodPayment + "'");
                            if (item.InvokeRequired)
                            {
                                item.Invoke(new MethodInvoker(delegate () { item.Parent.Controls.Remove(item); }));
                            }
                            else
                            {
                                item.Parent.Controls.Remove(item);
                            }
                            loadNum--;
                            totInserted++;
                        }
                        else
                        {
                            Names.Add(item.txtMdcName);
                            insert.InsertDb("Exec UpdateStockMedicine @Id = '" + item.ID + "', @ExpDate  = '" + item.ExpDate.ToString("yyyy-MM-dd") + "',@Qty  = '" + item._qty + "' , @Rate = '" + item._rate + "' ,@DatePurchase = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' , @Supplier = '" + txtSupplier.Text + "' , @Payment_Type = '" + methodPayment + "',@BatchId = '" + item._batch + "'");
                            err = false;
                            if (item.InvokeRequired)
                            {
                                item.Invoke(new MethodInvoker(delegate () { item.Parent.Controls.Remove(item); }));
                            }
                            else
                            {
                                item.Parent.Controls.Remove(item);
                            }
                            loadNum--;

                        }
                    }
                    else
                    {
                        if (item.InvokeRequired)
                        {
                            item.Invoke(new MethodInvoker(delegate () { item._errVisible = true; }));
                            err = true;
                        }
                    }

                }
                if (Names.Count > 0)
                {
                    string namesList = "";
                    foreach (string item in Names)
                    {
                        namesList += item + ",";
                    }
                    string newMsg = namesList.Remove(namesList.Length - 1);
                    string msg = "Produkti me Emrin '" + newMsg + "' nuk mund të regjistrohet sepse gjindet në stock.\nJanë përditësuar automatikisht nga sistemi.";
                    MessageBox.Show(msg, "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //lblScd.Text = "U përditësuan me sukses: " + Names.Count;
                    //Scd.Enabled = true;
                    //Scd.Start();
                    VarClass.ShowMsgBox("U përditësuan me sukses: " + Names.Count, "Me sukses", 3);
                    Names.Clear();
                }
                if (totInserted > 0)
                {
                    //lblScd.Text = "U insertuan me sukses: " + totInserted;
                    //Scd.Enabled = true;
                    //Scd.Start();
                    VarClass.ShowMsgBox("U insertuan me sukses: " + totInserted, "Me sukses", 3);
                    totInserted = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void txtSupplier_Enter(object sender, EventArgs e)
        {
            DialogResult drs = VarClass.HelpFormResult("Selekto Furnizuesin", new ListOfSupplier());
            if (drs == DialogResult.OK)
            {
                txtSupplier.Text = DetailsSupplierStruct.SName;
                PaymetMethod.Focus();
            }
            else
            {
                PaymetMethod.Focus();
            }
        }

        private int GetNum(string text)
        {
            switch (text)
            {
                case "Cash Payment":
                    return 1;
                case "Net Banking":
                    return 2;
                case "Payment Due":
                    return 3;
                default:
                    break;
            }
            return -1;
        }

        private void AddSupplier(object sender, EventArgs e)
        {
            DialogResult dr = VarClass.HelpFormResult("Shto Furnizues të ri", new AddNewSupplier());
        }
        private void Scd_Tick(object sender, EventArgs e)
        {
            pnlInsertetd.Visible = true;
            sec++;
            if (sec > 3)
            {
                Scd.Stop();
                sec = 0;
                Scd.Enabled = false;
                pnlInsertetd.Visible = false;

            }
        }
    }
}
