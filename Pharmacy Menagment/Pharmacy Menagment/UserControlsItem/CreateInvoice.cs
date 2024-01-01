using Pharmacy_Menagment.Classes;
using Pharmacy_Menagment.UserControlsItem.HelpFormChildren;
using Pharmacy_Menagment.UserControlsItem.ItemChildren;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Pharmacy_Menagment.UserControlsItem
{
    public partial class CreateInvoice : UserControl
    {
        int num = 1;
        CommandDatabase command = new CommandDatabase();
        private SynchronizationContext syncContext;
        public CreateInvoice()
        {
            InitializeComponent();
            syncContext = SynchronizationContext.Current;
        }

        private void CreateInvoice_Load(object sender, EventArgs e)
        {
            ListInvocieItem item = new ListInvocieItem();
            AddItemInBody(item);
        }
        void AddItemInBody(ListInvocieItem listInvocieItem)
        {
            var objList = listInvocieItem;
            objList.ActionClick = (ss, ee) =>
            {
                var pic = ss as PictureBox;
                if (pic.Name == "AddNew")
                {
                    var objListItemNew = new ListInvocieItem();
                    objListItemNew.EnterAction = (ss, ee) =>
                    {
                        VarClass.num = 1;
                        DialogResult drs = VarClass.HelpFormResult("Selekto Medikamentin", new GetMedicineDetails(false));

                        if (drs == DialogResult.OK)
                        {
                            bool IfExcist = false;
                            foreach (ListInvocieItem item in Body.Controls)
                            {
                                if (item.txtMedicine.Text != "" && DetailsMedicineStruct.MdcName != "")
                                {
                                    if (DetailsMedicineStruct.MdcName.ToLower().Contains(item.txtMedicine.Text.ToLower()))
                                    {
                                        IfExcist = true;
                                    }
                                }
                            }
                            if (IfExcist == false)
                            {
                                if (DetailsMedicineStruct.MdcQty > 0)
                                {
                                    objListItemNew.txtMedicine.Text = DetailsMedicineStruct.MdcName;
                                    objListItemNew.TXTBatchId.Text = DetailsMedicineStruct.MdcBatch;
                                    objListItemNew.txtExpiry.Text = DetailsMedicineStruct.MdcExp.ToString("MM/yyyy");
                                    objListItemNew.txtRate.Text = DetailsMedicineStruct.MdcRate.ToString("0.00");
                                    objListItemNew.AllQty = DetailsMedicineStruct.MdcQty;
                                    objListItemNew.IdMedicine = DetailsMedicineStruct._Id;
                                    //txtSupplier.Text = DetailsMedicineStruct.Supplier;
                                    objListItemNew.QtyTxt.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Nuk ka sasi të mjafueshme të kësaj medicine '" + DetailsMedicineStruct.MdcName + "' në stock për të mundësuar shitjen.\nSasia e Medicines që ju zgjodhët është 0 në stock.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    objListItemNew.TXTBatchId.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Medicina me këtë Emër: '" + DetailsMedicineStruct.MdcName + "' është selektuar një here.\nJu lutem zgjedhni një medicinë tjetër.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                objListItemNew.TXTBatchId.Focus();
                            }
                            


                        }
                        else
                            objListItemNew.QtyTxt.Focus();
                    };
                    AddItemInBody(objListItemNew);
                }
                else
                {
                    num--;
                    Body.Controls.Remove(objList);
                    CheckifControlsIsZero();
                    AllCalc();
                    SortingofObjects();
                }
            };
            objList.EnterAction = (ss, ee) =>
            {
                VarClass.num = 1;
                DialogResult drs = VarClass.HelpFormResult("Selekto Medikamentin", new GetMedicineDetails(false));

                if (drs == DialogResult.OK)
                {
                    bool IfExcist = false;
                    foreach (ListInvocieItem item in Body.Controls)
                    {
                        if (item.txtMedicine.Text != "" && DetailsMedicineStruct.MdcName != "")
                        {
                            if (DetailsMedicineStruct.MdcName.ToLower().Contains(item.txtMedicine.Text.ToLower()))
                            {
                                IfExcist = true;
                            }
                        }
                        
                    }
                    if (IfExcist == false)
                    {
                        if (DetailsMedicineStruct.MdcQty > 0)
                        {
                            objList.txtMedicine.Text = DetailsMedicineStruct.MdcName;
                            objList.TXTBatchId.Text = DetailsMedicineStruct.MdcBatch;
                            objList.txtExpiry.Text = DetailsMedicineStruct.MdcExp.ToString("MM/yyyy");
                            objList.txtRate.Text = DetailsMedicineStruct.MdcRate.ToString("0.00");
                            objList.AllQty = DetailsMedicineStruct.MdcQty;
                            objList.IdMedicine = DetailsMedicineStruct._Id;
                            //txtSupplier.Text = DetailsMedicineStruct.Supplier;
                            objList.QtyTxt.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Nuk ka sasi të mjafueshme të kësaj medicine '" + DetailsMedicineStruct.MdcName + "' në stock për të mundësuar shitjen.\nSasia e Medicines që ju zgjodhët është 0 në stock.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            objList.TXTBatchId.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Medicina me këtë Emër: '" + DetailsMedicineStruct.MdcName + "' është selektuar një here.\nJu lutem zgjedhni një medicinë tjetër.", "Kujdes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        objList.TXTBatchId.Focus();
                    }
                       
                }
                else
                    objList.QtyTxt.Focus();
            };
            objList.AmountTextChange = (ss, ee) =>
            {
                AllCalc();
            };
            objList.LabelNums = $"{num++}";

            syncContext.Post(new SendOrPostCallback(delegate {
                    Body.Controls.Add(objList);
            }), null);
            //if (Body.InvokeRequired)
            //{
            //    Body.BeginInvoke(new Action(() => {
            //        Body.Controls.Add(objList);
            //    }));
                  
            //}
            //else
            //    Body.Controls.Add(objList);
        }

        private void SortingofObjects()
        {
            int numCalc = 1;
            foreach (ListInvocieItem item in Body.Controls)
            {
                item.LabelNums =numCalc.ToString();
                numCalc++;
            }
        }

        void AllCalc()
        {

            double allTotal = 0;
            double nettotal = 0;
            double discount = 0;


            foreach (ListInvocieItem item in Body.Controls)
            {
                if (item.txtAmount.Text != "")
                {
                    nettotal += double.Parse(item.txtAmount.Text.Replace("€", ""));
                    if (item.QtyTxt.Text != "" && item.txtRate.Text != "")
                    {
                        if (item.txtdiscount.Text != "")
                        {
                            double calcnewValue = double.Parse(item.QtyTxt.Text) * double.Parse(item.txtRate.Text);
                            double firstval = double.Parse(item.txtdiscount.Text) / 100;
                            discount += (calcnewValue * firstval);
                        }
                        allTotal += (double.Parse(item.QtyTxt.Text) * double.Parse(item.txtRate.Text));
                    }


                }
            }
            if (txtAmountAll.InvokeRequired)
            {
                txtAmountAll.Invoke(new MethodInvoker(delegate () { txtAmountAll.Text = allTotal.ToString("0.00"); }));

            }
            else
                txtAmountAll.Text = allTotal.ToString("0.00");

            if (txtNetTotal.InvokeRequired)
            {
                txtNetTotal.Invoke(new MethodInvoker(delegate () { txtNetTotal.Text = nettotal.ToString("0.00"); }));

            }
            else
                txtNetTotal.Text = nettotal.ToString("0.00");

            if (txtDicount.InvokeRequired)
            {
                txtDicount.Invoke(new MethodInvoker(delegate () { txtDicount.Text = discount.ToString("0.00"); }));

            }
            else
                txtDicount.Text = discount.ToString("0.00");

            //txtNetTotal.Text = nettotal.ToString("0.00") + "€";
            //txtDicount.Text = discount.ToString("0.00") + "€";
        }
        private void CheckifControlsIsZero()
        {
           
            if (Body.Controls.Count == 0)
            {
                ListInvocieItem item = new ListInvocieItem();
                AddItemInBody(item);
                AllCalc();
            }
        }

        void EnterMouseinTextBoxElement(Object obj)
        {
            if (obj == null)
            {
                var objClass = (ListInvocieItem)obj;

                objClass.EnterAction = (ss, ee) =>
                {
                    DialogResult drs = VarClass.HelpFormResult("Selekto Medikamentin", new GetMedicineDetails(false));

                    if (drs == DialogResult.OK)
                    {
                        objClass.txtMedicine.Text = DetailsMedicineStruct.MdcName;
                        objClass.TXTBatchId.Text = DetailsMedicineStruct.MdcBatch;
                        objClass.txtExpiry.Text = DetailsMedicineStruct.MdcExp.ToString("MM/yyyy");
                        objClass.txtRate.Text = DetailsMedicineStruct.MdcRate.ToString();
                        objClass.AllQty = DetailsMedicineStruct.MdcQty;
                        //txtSupplier.Text = DetailsMedicineStruct.Supplier;
                        objClass.QtyTxt.Focus();
                    }
                    else
                        objClass.QtyTxt.Focus();
                };

            }
        }
        private void AddCostumer_Click(object sender, EventArgs e)
        {
            DialogResult dr = VarClass.HelpFormResult("Shto një klient të ri", new AddnewCustomer());
        }

        private void txtCustomer_Enter(object sender, EventArgs e)
        {
            kryptonLabel1.Visible = false;
            txtCustomer.Location = new Point(39, 10);
            pnlList.Visible = true;
        }

        private void txtCustomer_Leave(object sender, EventArgs e)
        {
            kryptonLabel1.Visible = true;
            txtCustomer.Location = new Point(39, 31);
            pnlList.Visible = false;
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            //
            if (txtCustomer.Text != "")
            {
                foreach (ListUsersItem item in pnlList.Controls)
                {
                    item.Visible = (item.NameSurname.ToLower().Contains(txtCustomer.Text.ToLower()));
                }
            }
            else
            {
                txtContact.Text = string.Empty;
                txtAddress.Text = string.Empty;
            }
          

        }

        private void pnlList_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlList.Visible)
            {
                DataTable dt = command.GetDataTable("Exec ListUsers");
                foreach (DataRow item in dt.Rows)
                {
                    var objList = new ListUsersItem();
                    objList.handler = (ss, ee) =>
                    {
                        txtCustomer.Text = objList.NameSurname;
                        txtContact.Text = objList.NrTel;
                        txtAddress.Text = objList.Adress;
                        pnlList.Visible = false;
                        PaymentType.Focus();
                    };
                    objList.NameSurname = item["Name_Surname"].ToString();
                    objList.NrTel = item["Contact_Number"].ToString();
                    objList.Adress = item["NameCity"].ToString();
                    pnlList.Controls.Add(objList);
                }


            }
            else
                pnlList.Controls.Clear();
        }
        int cashPayment = 0;
        private void AddList_Click(object sender, EventArgs e)
        {
            try
            {
                 cashPayment = GetNum(PaymentType.Text);
                //using (var objWait = new LoadingScreen(InsertWithLs, "Po Insertoen të dhënat\nJu lutem prisni..."))
                //{
                //    objWait.ShowDialog(this);
                //    if (objWait.DialogResult == DialogResult.OK)
                //    {
                //        CheckifControlsIsZero();
                //    }
                //}
                InsertWithLs();
                CheckifControlsIsZero();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertWithLs()
        {
            try
            {
                if (txtCustomer.Text != "" && txtAddress.Text != "")
                {

                    if (Body.Controls.Count > 0)
                    {
                        int numInserted = 0;
                        foreach (ListInvocieItem item in Body.Controls)
                        {
                            if (item.txtMedicine.Text != "" && item.TXTBatchId.Text != "" && item.txtExpiry.Text != "" && item.QtyTxt.Text != "" && item.txtRate.Text != "" && item.txtAmount.Text != "")
                            {
                                command.InsertDb("Exec AddInvoices @NameCustomer = '" + txtCustomer.Text + "',@Adress='" + txtAddress.Text + "', @Nr = '" + txtContact.Text + "',@IdMedicine = '" + item.IdMedicine + "',@Qty = '" + item.QtyTxt.Text + "',@Discount = '" + item.txtdiscount.Text + "%" + $"',@NetTot = {double.Parse(item.txtAmount.Text.Replace("€",""))},@DtCreate = '" + DateTime.Now.ToString("yyyy-MM-dd") + $"', @MethodPayment = {cashPayment};");
                                if (item.InvokeRequired)
                                {
                                    item.Invoke(new MethodInvoker(delegate () { item.Parent.Controls.Remove(item); }));
                                    num--;

                                }
                                else
                                {
                                    Body.Controls.Remove(item);
                                    num--;
                                  
                                }
                                numInserted++;

                            }
                            else
                            {
                                if (item.InvokeRequired)
                                {
                                    item.Invoke(new MethodInvoker(delegate () { item.err1.Visible = true; }));
                                    VarClass.ShowMsgBox("Duhet të plotësohen të gjitha fushat.", "Kujdes !", 2);
                                    txtCustomer.Text = "";
                                }
                            }

                        }
                        AllCalc();
                        SortingofObjects();
                        VarClass.ShowMsgBox("U Insertuan me sukses: " + numInserted, "Me sukses", 3);
                    }
                }
                else
                    VarClass.ShowMsgBox("Zgjedhni ose krijoni një klient të ri.", "Kujdes !", 2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void topPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
