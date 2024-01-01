namespace Pharmacy_Menagment.UserControlsItem.ItemChildren
{
    partial class ListInvocieItem
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
            this.err1 = new Krypton.Toolkit.KryptonLabel();
            this.LabelNum = new System.Windows.Forms.Label();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtAmount = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.QtyTxt = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.TXTBatchId = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtMedicine = new Krypton.Toolkit.KryptonTextBox();
            this.txtAvgQty = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtExpiry = new Krypton.Toolkit.KryptonTextBox();
            this.txtRate = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtdiscount = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.AddNew = new System.Windows.Forms.PictureBox();
            this.Remove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // err1
            // 
            this.err1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err1.Location = new System.Drawing.Point(542, 99);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(342, 20);
            this.err1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err1.TabIndex = 45;
            this.err1.Values.Text = "Kontrolloni fushat nëse janë të gjitha të plotësuara !";
            this.err1.Visible = false;
            // 
            // LabelNum
            // 
            this.LabelNum.AutoSize = true;
            this.LabelNum.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelNum.Location = new System.Drawing.Point(24, 45);
            this.LabelNum.Name = "LabelNum";
            this.LabelNum.Size = new System.Drawing.Size(40, 44);
            this.LabelNum.TabIndex = 44;
            this.LabelNum.Text = "1";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(1216, 32);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(49, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 43;
            this.kryptonLabel6.Values.Text = "Total : ";
            // 
            // txtAmount
            // 
            this.txtAmount.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(1216, 58);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(107, 31);
            this.txtAmount.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAmount.StateCommon.Border.ColorAngle = 1F;
            this.txtAmount.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtAmount.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtAmount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAmount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtAmount.StateCommon.Border.Rounding = 7F;
            this.txtAmount.StateCommon.Border.Width = 1;
            this.txtAmount.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtAmount.TabIndex = 42;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(963, 32);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 41;
            this.kryptonLabel5.Values.Text = "Rate : ";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(835, 32);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(52, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 39;
            this.kryptonLabel4.Values.Text = "Sasia :";
            // 
            // QtyTxt
            // 
            this.QtyTxt.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTxt.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.QtyTxt.Location = new System.Drawing.Point(835, 58);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(109, 31);
            this.QtyTxt.StateCommon.Border.ColorAngle = 1F;
            this.QtyTxt.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.QtyTxt.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.QtyTxt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.QtyTxt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.QtyTxt.StateCommon.Border.Rounding = 7F;
            this.QtyTxt.StateCommon.Border.Width = 1;
            this.QtyTxt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTxt.TabIndex = 38;
            this.QtyTxt.TextChanged += new System.EventHandler(this.QtyTxt_TextChanged);
            this.QtyTxt.Leave += new System.EventHandler(this.QtyTxt_Leave);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(382, 32);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 37;
            this.kryptonLabel3.Values.Text = "Batch ID :";
            // 
            // TXTBatchId
            // 
            this.TXTBatchId.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTBatchId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.TXTBatchId.Location = new System.Drawing.Point(382, 58);
            this.TXTBatchId.Name = "TXTBatchId";
            this.TXTBatchId.Size = new System.Drawing.Size(194, 31);
            this.TXTBatchId.StateCommon.Border.ColorAngle = 1F;
            this.TXTBatchId.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.TXTBatchId.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.TXTBatchId.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TXTBatchId.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.TXTBatchId.StateCommon.Border.Rounding = 7F;
            this.TXTBatchId.StateCommon.Border.Width = 1;
            this.TXTBatchId.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTBatchId.TabIndex = 36;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(589, 32);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(75, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 35;
            this.kryptonLabel2.Values.Text = "Avg. Qty :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(80, 32);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(99, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 34;
            this.kryptonLabel1.Values.Text = "Emri i Barnes :";
            // 
            // txtMedicine
            // 
            this.txtMedicine.CueHint.CueHintText = "Emri i Barnës";
            this.txtMedicine.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtMedicine.Location = new System.Drawing.Point(80, 58);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(283, 31);
            this.txtMedicine.StateCommon.Border.ColorAngle = 1F;
            this.txtMedicine.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtMedicine.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtMedicine.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMedicine.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtMedicine.StateCommon.Border.Rounding = 7F;
            this.txtMedicine.StateCommon.Border.Width = 1;
            this.txtMedicine.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.TabIndex = 32;
            this.txtMedicine.Enter += new System.EventHandler(this.txtMedicine_Enter);
            // 
            // txtAvgQty
            // 
            this.txtAvgQty.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAvgQty.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAvgQty.Enabled = false;
            this.txtAvgQty.Location = new System.Drawing.Point(589, 58);
            this.txtAvgQty.Name = "txtAvgQty";
            this.txtAvgQty.Size = new System.Drawing.Size(106, 31);
            this.txtAvgQty.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAvgQty.StateCommon.Border.ColorAngle = 1F;
            this.txtAvgQty.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtAvgQty.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtAvgQty.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAvgQty.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtAvgQty.StateCommon.Border.Rounding = 7F;
            this.txtAvgQty.StateCommon.Border.Width = 1;
            this.txtAvgQty.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAvgQty.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtAvgQty.TabIndex = 46;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel7.Location = new System.Drawing.Point(708, 32);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(120, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel7.TabIndex = 48;
            this.kryptonLabel7.Values.Text = "Data e skadimit :";
            // 
            // txtExpiry
            // 
            this.txtExpiry.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpiry.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtExpiry.Enabled = false;
            this.txtExpiry.Location = new System.Drawing.Point(711, 58);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(106, 31);
            this.txtExpiry.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtExpiry.StateCommon.Border.ColorAngle = 1F;
            this.txtExpiry.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtExpiry.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtExpiry.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtExpiry.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtExpiry.StateCommon.Border.Rounding = 7F;
            this.txtExpiry.StateCommon.Border.Width = 1;
            this.txtExpiry.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExpiry.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtExpiry.TabIndex = 49;
            // 
            // txtRate
            // 
            this.txtRate.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRate.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRate.Enabled = false;
            this.txtRate.Location = new System.Drawing.Point(963, 58);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(106, 31);
            this.txtRate.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtRate.StateCommon.Border.ColorAngle = 1F;
            this.txtRate.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtRate.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtRate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtRate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtRate.StateCommon.Border.Rounding = 7F;
            this.txtRate.StateCommon.Border.Width = 1;
            this.txtRate.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRate.StateDisabled.Content.Color1 = System.Drawing.Color.White;
            this.txtRate.TabIndex = 50;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel8.Location = new System.Drawing.Point(1088, 32);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel8.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel8.TabIndex = 52;
            this.kryptonLabel8.Values.Text = "Discount % :";
            // 
            // txtdiscount
            // 
            this.txtdiscount.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdiscount.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtdiscount.Location = new System.Drawing.Point(1088, 58);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(109, 31);
            this.txtdiscount.StateCommon.Border.ColorAngle = 1F;
            this.txtdiscount.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtdiscount.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtdiscount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtdiscount.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtdiscount.StateCommon.Border.Rounding = 7F;
            this.txtdiscount.StateCommon.Border.Width = 1;
            this.txtdiscount.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtdiscount.TabIndex = 51;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.kryptonTextBox4_TextChanged);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(28, 125);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(1384, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // AddNew
            // 
            this.AddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNew.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_add_new_40;
            this.AddNew.Location = new System.Drawing.Point(1331, 51);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(40, 40);
            this.AddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AddNew.TabIndex = 55;
            this.AddNew.TabStop = false;
            this.AddNew.Click += new System.EventHandler(this.ActionForm);
            // 
            // Remove
            // 
            this.Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_remove_40;
            this.Remove.Location = new System.Drawing.Point(1377, 51);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(40, 40);
            this.Remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Remove.TabIndex = 56;
            this.Remove.TabStop = false;
            this.Remove.Click += new System.EventHandler(this.ActionForm);
            // 
            // ListInvocieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtExpiry);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtAvgQty);
            this.Controls.Add(this.err1);
            this.Controls.Add(this.LabelNum);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.TXTBatchId);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtMedicine);
            this.Name = "ListInvocieItem";
            this.Size = new System.Drawing.Size(1439, 129);
            ((System.ComponentModel.ISupportInitialize)(this.AddNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label LabelNum;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private PictureBox AddNew;
        private PictureBox Remove;
        public Krypton.Toolkit.KryptonTextBox txtAmount;
        public Krypton.Toolkit.KryptonTextBox QtyTxt;
        public Krypton.Toolkit.KryptonTextBox TXTBatchId;
        public Krypton.Toolkit.KryptonTextBox txtMedicine;
        public Krypton.Toolkit.KryptonTextBox txtAvgQty;
        public Krypton.Toolkit.KryptonTextBox txtExpiry;
        public Krypton.Toolkit.KryptonTextBox txtRate;
        public Krypton.Toolkit.KryptonTextBox txtdiscount;
        public Krypton.Toolkit.KryptonLabel err1;
    }
}
