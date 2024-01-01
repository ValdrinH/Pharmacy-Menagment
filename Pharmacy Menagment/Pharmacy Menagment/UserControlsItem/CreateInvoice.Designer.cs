namespace Pharmacy_Menagment.UserControlsItem
{
    partial class CreateInvoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddList = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtNetTotal = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtDicount = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtAmountAll = new Krypton.Toolkit.KryptonTextBox();
            this.topPnl = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.CstPnl = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.FlowLayoutPanel();
            this.AddCostumer = new Krypton.Toolkit.KryptonButton();
            this.txtContact = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.DatePayment = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.PaymentType = new Krypton.Toolkit.KryptonComboBox();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtCustomer = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.Body = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.CstPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddList);
            this.panel1.Controls.Add(this.kryptonLabel8);
            this.panel1.Controls.Add(this.txtNetTotal);
            this.panel1.Controls.Add(this.kryptonLabel7);
            this.panel1.Controls.Add(this.txtDicount);
            this.panel1.Controls.Add(this.kryptonLabel6);
            this.panel1.Controls.Add(this.txtAmountAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 106);
            this.panel1.TabIndex = 15;
            // 
            // AddList
            // 
            this.AddList.CornerRoundingRadius = 10F;
            this.AddList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddList.Location = new System.Drawing.Point(24, 28);
            this.AddList.Name = "AddList";
            this.AddList.Size = new System.Drawing.Size(386, 55);
            this.AddList.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            this.AddList.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            this.AddList.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddList.StateCommon.Border.Rounding = 10F;
            this.AddList.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddList.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddList.TabIndex = 36;
            this.AddList.Values.Text = "Ruaj";
            this.AddList.Click += new System.EventHandler(this.AddList_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel8.Location = new System.Drawing.Point(1238, 11);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel8.TabIndex = 34;
            this.kryptonLabel8.Values.Text = "Net Total : ";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtNetTotal.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNetTotal.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtNetTotal.Enabled = false;
            this.txtNetTotal.Location = new System.Drawing.Point(1238, 37);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(217, 37);
            this.txtNetTotal.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtNetTotal.StateCommon.Border.ColorAngle = 1F;
            this.txtNetTotal.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtNetTotal.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtNetTotal.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNetTotal.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtNetTotal.StateCommon.Border.Rounding = 7F;
            this.txtNetTotal.StateCommon.Border.Width = 1;
            this.txtNetTotal.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNetTotal.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtNetTotal.TabIndex = 33;
            this.txtNetTotal.Text = "0.00€";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel7.Location = new System.Drawing.Point(1004, 11);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(108, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel7.TabIndex = 32;
            this.kryptonLabel7.Values.Text = "Total Discount : ";
            // 
            // txtDicount
            // 
            this.txtDicount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDicount.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDicount.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtDicount.Enabled = false;
            this.txtDicount.Location = new System.Drawing.Point(1004, 37);
            this.txtDicount.Name = "txtDicount";
            this.txtDicount.Size = new System.Drawing.Size(217, 37);
            this.txtDicount.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtDicount.StateCommon.Border.ColorAngle = 1F;
            this.txtDicount.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtDicount.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtDicount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDicount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtDicount.StateCommon.Border.Rounding = 7F;
            this.txtDicount.StateCommon.Border.Width = 1;
            this.txtDicount.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDicount.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtDicount.TabIndex = 31;
            this.txtDicount.Text = "0.00€";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(770, 11);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 30;
            this.kryptonLabel6.Values.Text = "Total : ";
            // 
            // txtAmountAll
            // 
            this.txtAmountAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtAmountAll.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmountAll.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAmountAll.Enabled = false;
            this.txtAmountAll.Location = new System.Drawing.Point(770, 37);
            this.txtAmountAll.Name = "txtAmountAll";
            this.txtAmountAll.Size = new System.Drawing.Size(217, 37);
            this.txtAmountAll.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAmountAll.StateCommon.Border.ColorAngle = 1F;
            this.txtAmountAll.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtAmountAll.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtAmountAll.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmountAll.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtAmountAll.StateCommon.Border.Rounding = 7F;
            this.txtAmountAll.StateCommon.Border.Width = 1;
            this.txtAmountAll.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtAmountAll.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAmountAll.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtAmountAll.TabIndex = 29;
            this.txtAmountAll.Text = "0€";
            // 
            // topPnl
            // 
            this.topPnl.Controls.Add(this.pictureBox7);
            this.topPnl.Controls.Add(this.label18);
            this.topPnl.Controls.Add(this.panel8);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(1478, 84);
            this.topPnl.TabIndex = 16;
            this.topPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.topPnl_Paint);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_paid_bill_60;
            this.pictureBox7.Location = new System.Drawing.Point(39, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(93, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(177, 32);
            this.label18.TabIndex = 15;
            this.label18.Text = "New Invoice";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel8.Location = new System.Drawing.Point(39, 64);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1400, 3);
            this.panel8.TabIndex = 16;
            // 
            // CstPnl
            // 
            this.CstPnl.Controls.Add(this.pnlList);
            this.CstPnl.Controls.Add(this.AddCostumer);
            this.CstPnl.Controls.Add(this.txtContact);
            this.CstPnl.Controls.Add(this.kryptonLabel5);
            this.CstPnl.Controls.Add(this.kryptonLabel3);
            this.CstPnl.Controls.Add(this.DatePayment);
            this.CstPnl.Controls.Add(this.kryptonLabel4);
            this.CstPnl.Controls.Add(this.PaymentType);
            this.CstPnl.Controls.Add(this.txtAddress);
            this.CstPnl.Controls.Add(this.kryptonLabel2);
            this.CstPnl.Controls.Add(this.kryptonLabel1);
            this.CstPnl.Controls.Add(this.txtCustomer);
            this.CstPnl.Controls.Add(this.kryptonBorderEdge1);
            this.CstPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.CstPnl.Location = new System.Drawing.Point(0, 84);
            this.CstPnl.Name = "CstPnl";
            this.CstPnl.Size = new System.Drawing.Size(1478, 135);
            this.CstPnl.TabIndex = 17;
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlList.Location = new System.Drawing.Point(39, 42);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(266, 95);
            this.pnlList.TabIndex = 49;
            this.pnlList.Visible = false;
            this.pnlList.VisibleChanged += new System.EventHandler(this.pnlList_VisibleChanged);
            // 
            // AddCostumer
            // 
            this.AddCostumer.CornerRoundingRadius = 10F;
            this.AddCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCostumer.Location = new System.Drawing.Point(39, 85);
            this.AddCostumer.Name = "AddCostumer";
            this.AddCostumer.Size = new System.Drawing.Size(159, 37);
            this.AddCostumer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.AddCostumer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.AddCostumer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddCostumer.StateCommon.Border.Rounding = 10F;
            this.AddCostumer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddCostumer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCostumer.TabIndex = 47;
            this.AddCostumer.Values.Text = "Shto Klient";
            this.AddCostumer.Click += new System.EventHandler(this.AddCostumer_Click);
            // 
            // txtContact
            // 
            this.txtContact.CueHint.Color1 = System.Drawing.Color.White;
            this.txtContact.CueHint.CueHintText = "+123";
            this.txtContact.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContact.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(568, 29);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(206, 31);
            this.txtContact.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtContact.StateCommon.Border.ColorAngle = 1F;
            this.txtContact.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtContact.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtContact.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtContact.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtContact.StateCommon.Border.Rounding = 7F;
            this.txtContact.StateCommon.Border.Width = 1;
            this.txtContact.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContact.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtContact.TabIndex = 46;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(568, 3);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(123, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 45;
            this.kryptonLabel5.Values.Text = "Numri kontaktus :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(1006, 5);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 44;
            this.kryptonLabel3.Values.Text = "Data :";
            // 
            // DatePayment
            // 
            this.DatePayment.CornerRoundingRadius = -1F;
            this.DatePayment.Location = new System.Drawing.Point(1006, 34);
            this.DatePayment.Name = "DatePayment";
            this.DatePayment.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.DatePayment.Size = new System.Drawing.Size(213, 26);
            this.DatePayment.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePayment.TabIndex = 43;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(812, 5);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(139, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 42;
            this.kryptonLabel4.Values.Text = "Mënyra e pagesës :";
            // 
            // PaymentType
            // 
            this.PaymentType.CornerRoundingRadius = 10F;
            this.PaymentType.DropDownWidth = 157;
            this.PaymentType.IntegralHeight = false;
            this.PaymentType.Items.AddRange(new object[] {
            "Cash Payment",
            "Net Banking",
            "Payment Due"});
            this.PaymentType.Location = new System.Drawing.Point(812, 34);
            this.PaymentType.Name = "PaymentType";
            this.PaymentType.PaletteMode = Krypton.Toolkit.PaletteMode.Office365White;
            this.PaymentType.Size = new System.Drawing.Size(163, 27);
            this.PaymentType.Sorted = true;
            this.PaymentType.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaymentType.StateCommon.ComboBox.Border.Rounding = 10F;
            this.PaymentType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.PaymentType.StateCommon.Item.Content.LongText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentType.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PaymentType.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentType.TabIndex = 41;
            this.PaymentType.Text = "Cash Payment";
            // 
            // txtAddress
            // 
            this.txtAddress.CueHint.Color1 = System.Drawing.Color.White;
            this.txtAddress.CueHint.CueHintText = "Adresa";
            this.txtAddress.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(336, 30);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(206, 31);
            this.txtAddress.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAddress.StateCommon.Border.ColorAngle = 1F;
            this.txtAddress.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtAddress.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtAddress.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtAddress.StateCommon.Border.Rounding = 7F;
            this.txtAddress.StateCommon.Border.Width = 1;
            this.txtAddress.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtAddress.TabIndex = 28;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(336, 4);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 23;
            this.kryptonLabel2.Values.Text = "Adresa :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(39, 5);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(98, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "Emri i klientit :";
            // 
            // txtCustomer
            // 
            this.txtCustomer.CueHint.CueHintText = "Emri klientit";
            this.txtCustomer.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtCustomer.Location = new System.Drawing.Point(39, 31);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(266, 31);
            this.txtCustomer.StateCommon.Border.ColorAngle = 1F;
            this.txtCustomer.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCustomer.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtCustomer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomer.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtCustomer.StateCommon.Border.Rounding = 7F;
            this.txtCustomer.StateCommon.Border.Width = 1;
            this.txtCustomer.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomer.TabIndex = 20;
            this.txtCustomer.TextChanged += new System.EventHandler(this.txtCustomer_TextChanged);
            this.txtCustomer.Enter += new System.EventHandler(this.txtCustomer_Enter);
            this.txtCustomer.Leave += new System.EventHandler(this.txtCustomer_Leave);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(39, 128);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(1400, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // Body
            // 
            this.Body.AutoScroll = true;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 219);
            this.Body.Name = "Body";
            this.Body.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.Body.Size = new System.Drawing.Size(1478, 317);
            this.Body.TabIndex = 18;
            // 
            // CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Body);
            this.Controls.Add(this.CstPnl);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.panel1);
            this.Name = "CreateInvoice";
            this.Size = new System.Drawing.Size(1478, 642);
            this.Load += new System.EventHandler(this.CreateInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.CstPnl.ResumeLayout(false);
            this.CstPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel topPnl;
        private PictureBox pictureBox7;
        private Label label18;
        private Panel panel8;
        private Panel CstPnl;
        private FlowLayoutPanel Body;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtCustomer;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonTextBox txtContact;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonDateTimePicker DatePayment;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox PaymentType;
        private Krypton.Toolkit.KryptonButton AddCostumer;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox txtNetTotal;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtDicount;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtAmountAll;
        private Krypton.Toolkit.KryptonButton AddList;
        private FlowLayoutPanel pnlList;
    }
}
