namespace Pharmacy_Menagment.UserControlsItem.ItemChildren
{
    partial class ListItemMedicineDetails
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
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtGenericName = new Krypton.Toolkit.KryptonTextBox();
            this.txtMedicine = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.BatchId = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.QtyTxt = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtRate = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtAmount = new Krypton.Toolkit.KryptonTextBox();
            this.LabelNum = new System.Windows.Forms.Label();
            this.err1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtDate = new Krypton.Toolkit.KryptonTextBox();
            this.dt = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(483, 22);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(104, 20);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 20;
            this.kryptonLabel2.Values.Text = "Emri Gjenerik :";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(113, 22);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(99, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 19;
            this.kryptonLabel1.Values.Text = "Emri i Barnës :";
            // 
            // txtGenericName
            // 
            this.txtGenericName.CueHint.CueHintText = "Generic ";
            this.txtGenericName.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenericName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtGenericName.Location = new System.Drawing.Point(483, 48);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.ReadOnly = true;
            this.txtGenericName.Size = new System.Drawing.Size(204, 31);
            this.txtGenericName.StateCommon.Border.ColorAngle = 1F;
            this.txtGenericName.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGenericName.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtGenericName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGenericName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtGenericName.StateCommon.Border.Rounding = 7F;
            this.txtGenericName.StateCommon.Border.Width = 1;
            this.txtGenericName.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGenericName.TabIndex = 18;
            this.txtGenericName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicine_KeyPress);
            // 
            // txtMedicine
            // 
            this.txtMedicine.CueHint.CueHintText = "Emri";
            this.txtMedicine.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtMedicine.Location = new System.Drawing.Point(113, 48);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(338, 31);
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
            this.txtMedicine.TabIndex = 17;
            this.txtMedicine.Enter += new System.EventHandler(this.txtMedicine_Enter);
            this.txtMedicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedicine_KeyPress);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(713, 22);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 22;
            this.kryptonLabel3.Values.Text = "Batch ID :";
            // 
            // BatchId
            // 
            this.BatchId.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BatchId.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.BatchId.Location = new System.Drawing.Point(713, 48);
            this.BatchId.Name = "BatchId";
            this.BatchId.Size = new System.Drawing.Size(194, 31);
            this.BatchId.StateCommon.Border.ColorAngle = 1F;
            this.BatchId.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.BatchId.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.BatchId.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BatchId.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.BatchId.StateCommon.Border.Rounding = 7F;
            this.BatchId.StateCommon.Border.Width = 1;
            this.BatchId.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BatchId.TabIndex = 21;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(1065, 21);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 24;
            this.kryptonLabel4.Values.Text = "Qty :";
            // 
            // QtyTxt
            // 
            this.QtyTxt.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTxt.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.QtyTxt.Location = new System.Drawing.Point(1065, 47);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.Size = new System.Drawing.Size(73, 31);
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
            this.QtyTxt.TabIndex = 23;
            this.QtyTxt.TextChanged += new System.EventHandler(this.QtyTxt_TextChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(1163, 21);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 26;
            this.kryptonLabel5.Values.Text = "Rate : ";
            // 
            // txtRate
            // 
            this.txtRate.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRate.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtRate.Location = new System.Drawing.Point(1163, 47);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(88, 31);
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
            this.txtRate.TabIndex = 25;
            this.txtRate.Text = "0.0";
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(1281, 22);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(66, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 28;
            this.kryptonLabel6.Values.Text = "Amount: ";
            // 
            // txtAmount
            // 
            this.txtAmount.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAmount.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(1281, 48);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(105, 31);
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
            this.txtAmount.TabIndex = 27;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // LabelNum
            // 
            this.LabelNum.AutoSize = true;
            this.LabelNum.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelNum.Location = new System.Drawing.Point(16, 35);
            this.LabelNum.Name = "LabelNum";
            this.LabelNum.Size = new System.Drawing.Size(40, 44);
            this.LabelNum.TabIndex = 30;
            this.LabelNum.Text = "1";
            // 
            // err1
            // 
            this.err1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err1.Location = new System.Drawing.Point(556, 93);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(342, 20);
            this.err1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err1.TabIndex = 31;
            this.err1.Values.Text = "Kontrolloni fushat nëse janë të gjitha të plotësuara !";
            this.err1.Visible = false;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(34, 112);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(1384, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel7.Location = new System.Drawing.Point(931, 22);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(109, 20);
            this.kryptonLabel7.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel7.TabIndex = 33;
            this.kryptonLabel7.Values.Text = "Data Skadimit :";
            // 
            // txtDate
            // 
            this.txtDate.CueHint.CueHintText = "MM/YYYY";
            this.txtDate.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtDate.Location = new System.Drawing.Point(931, 48);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(109, 27);
            this.txtDate.StateActive.Content.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.StateCommon.Border.ColorAngle = 1F;
            this.txtDate.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtDate.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtDate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDate.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtDate.StateCommon.Border.Rounding = 7F;
            this.txtDate.StateCommon.Border.Width = 1;
            this.txtDate.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.TabIndex = 32;
            this.txtDate.TextChanged += new System.EventHandler(this.txtDate_TextChanged);
            this.txtDate.Enter += new System.EventHandler(this.txtDate_Enter);
            // 
            // dt
            // 
            this.dt.CornerRoundingRadius = 10F;
            this.dt.Location = new System.Drawing.Point(931, 48);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(109, 32);
            this.dt.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dt.StateCommon.Border.Rounding = 10F;
            this.dt.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dt.TabIndex = 35;
            this.dt.Visible = false;
            this.dt.ValueChanged += new System.EventHandler(this.kryptonDateTimePicker1_ValueChanged);
            this.dt.Leave += new System.EventHandler(this.kryptonDateTimePicker1_Leave);
            // 
            // ListItemMedicineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dt);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.err1);
            this.Controls.Add(this.LabelNum);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.BatchId);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtGenericName);
            this.Controls.Add(this.txtMedicine);
            this.Name = "ListItemMedicineDetails";
            this.Size = new System.Drawing.Size(1452, 117);
            this.Load += new System.EventHandler(this.ListItemMedicineDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtMedicine;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox BatchId;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtRate;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Label LabelNum;
        private Krypton.Toolkit.KryptonLabel err1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonDateTimePicker dt;
        public Krypton.Toolkit.KryptonTextBox txtGenericName;
        public Krypton.Toolkit.KryptonTextBox QtyTxt;
        public Krypton.Toolkit.KryptonTextBox txtAmount;
        public Krypton.Toolkit.KryptonTextBox txtDate;
    }
}
