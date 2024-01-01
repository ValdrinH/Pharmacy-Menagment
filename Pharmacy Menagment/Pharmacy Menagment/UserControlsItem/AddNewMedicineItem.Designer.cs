namespace Pharmacy_Menagment.UserControlsItem
{
    partial class AddNewMedicineItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMedicine = new Krypton.Toolkit.KryptonTextBox();
            this.txtPacking = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtGeneric = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtSupplier = new Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddMedicine = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.err1 = new Krypton.Toolkit.KryptonLabel();
            this.err2 = new Krypton.Toolkit.KryptonLabel();
            this.err3 = new Krypton.Toolkit.KryptonLabel();
            this.dtMedicineStock = new Krypton.Toolkit.KryptonDataGridView();
            this.Slc = new Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeleteRows = new Krypton.Toolkit.KryptonButton();
            this.totRows = new System.Windows.Forms.Label();
            this.txtMedicineName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtgnrc = new Krypton.Toolkit.KryptonTextBox();
            this.txtSupp = new Krypton.Toolkit.KryptonTextBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.err4 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedicine
            // 
            this.txtMedicine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMedicine.CueHint.CueHintText = "Emri medikamentit";
            this.txtMedicine.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtMedicine.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.txtMedicine.Location = new System.Drawing.Point(39, 147);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(412, 44);
            this.txtMedicine.StateCommon.Border.ColorAngle = 1F;
            this.txtMedicine.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtMedicine.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtMedicine.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMedicine.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtMedicine.StateCommon.Border.Rounding = 7F;
            this.txtMedicine.StateCommon.Border.Width = 1;
            this.txtMedicine.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.TabIndex = 0;
            this.txtMedicine.TextChanged += new System.EventHandler(this.txtMedicine_TextChanged);
            // 
            // txtPacking
            // 
            this.txtPacking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPacking.CueHint.CueHintText = "Packing e.g. 10 TAB / 100 ML";
            this.txtPacking.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPacking.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtPacking.Location = new System.Drawing.Point(484, 147);
            this.txtPacking.Name = "txtPacking";
            this.txtPacking.Size = new System.Drawing.Size(188, 44);
            this.txtPacking.StateCommon.Border.ColorAngle = 1F;
            this.txtPacking.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtPacking.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtPacking.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPacking.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtPacking.StateCommon.Border.Rounding = 7F;
            this.txtPacking.StateCommon.Border.Width = 1;
            this.txtPacking.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPacking.TabIndex = 1;
            this.txtPacking.TextChanged += new System.EventHandler(this.txtPacking_TextChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_caduceus_60;
            this.pictureBox7.Location = new System.Drawing.Point(39, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 14;
            this.pictureBox7.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(93, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(318, 32);
            this.label18.TabIndex = 12;
            this.label18.Text = "Add/Remove Medicine";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel8.Location = new System.Drawing.Point(39, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1400, 3);
            this.panel8.TabIndex = 13;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(39, 121);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(180, 25);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 15;
            this.kryptonLabel1.Values.Text = "Emri medikamentit :";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(484, 121);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(91, 25);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 16;
            this.kryptonLabel2.Values.Text = "Packing :";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(39, 213);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(131, 25);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Emri gjenerik :";
            // 
            // txtGeneric
            // 
            this.txtGeneric.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGeneric.CueHint.CueHintText = "Emri gjenerik";
            this.txtGeneric.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGeneric.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtGeneric.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.txtGeneric.Location = new System.Drawing.Point(39, 239);
            this.txtGeneric.Name = "txtGeneric";
            this.txtGeneric.Size = new System.Drawing.Size(412, 44);
            this.txtGeneric.StateCommon.Border.ColorAngle = 1F;
            this.txtGeneric.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtGeneric.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtGeneric.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtGeneric.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtGeneric.StateCommon.Border.Rounding = 7F;
            this.txtGeneric.StateCommon.Border.Width = 1;
            this.txtGeneric.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGeneric.TabIndex = 17;
            this.txtGeneric.TextChanged += new System.EventHandler(this.txtGeneric_TextChanged);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(39, 305);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(103, 25);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 20;
            this.kryptonLabel4.Values.Text = "Furnizuesi :";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSupplier.CueHint.CueHintText = "Emri Furnizuesit";
            this.txtSupplier.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplier.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSupplier.CueHint.TextV = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.txtSupplier.Location = new System.Drawing.Point(39, 331);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(412, 44);
            this.txtSupplier.StateCommon.Border.ColorAngle = 1F;
            this.txtSupplier.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtSupplier.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtSupplier.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSupplier.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtSupplier.StateCommon.Border.Rounding = 7F;
            this.txtSupplier.StateCommon.Border.Width = 1;
            this.txtSupplier.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupplier.TabIndex = 19;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            this.txtSupplier.Enter += new System.EventHandler(this.txtSupplier_Enter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(39, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 3);
            this.panel1.TabIndex = 21;
            // 
            // AddMedicine
            // 
            this.AddMedicine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddMedicine.CornerRoundingRadius = 10F;
            this.AddMedicine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddMedicine.Location = new System.Drawing.Point(39, 489);
            this.AddMedicine.Name = "AddMedicine";
            this.AddMedicine.Size = new System.Drawing.Size(408, 47);
            this.AddMedicine.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.AddMedicine.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.AddMedicine.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddMedicine.StateCommon.Border.Rounding = 10F;
            this.AddMedicine.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddMedicine.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddMedicine.TabIndex = 22;
            this.AddMedicine.Values.Text = "Shto";
            this.AddMedicine.Click += new System.EventHandler(this.AddMedicine_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(39, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "+Shto furnizues të ri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // err1
            // 
            this.err1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err1.Location = new System.Drawing.Point(187, 197);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(218, 20);
            this.err1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err1.TabIndex = 24;
            this.err1.Values.Text = "Kjo fush duhet të jetë e mbushur";
            this.err1.Visible = false;
            // 
            // err2
            // 
            this.err2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err2.Location = new System.Drawing.Point(187, 289);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(218, 20);
            this.err2.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err2.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err2.TabIndex = 25;
            this.err2.Values.Text = "Kjo fush duhet të jetë e mbushur";
            this.err2.Visible = false;
            // 
            // err3
            // 
            this.err3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err3.Location = new System.Drawing.Point(187, 381);
            this.err3.Name = "err3";
            this.err3.Size = new System.Drawing.Size(260, 20);
            this.err3.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err3.TabIndex = 26;
            this.err3.Values.Text = "Ju lutem zgedhni një furznizues nga list";
            this.err3.Visible = false;
            // 
            // dtMedicineStock
            // 
            this.dtMedicineStock.AllowUserToAddRows = false;
            this.dtMedicineStock.AllowUserToResizeColumns = false;
            this.dtMedicineStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtMedicineStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMedicineStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtMedicineStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMedicineStock.ColumnHeadersHeight = 60;
            this.dtMedicineStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtMedicineStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Slc,
            this.Delete});
            this.dtMedicineStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtMedicineStock.Location = new System.Drawing.Point(742, 137);
            this.dtMedicineStock.MultiSelect = false;
            this.dtMedicineStock.Name = "dtMedicineStock";
            this.dtMedicineStock.RowHeadersVisible = false;
            this.dtMedicineStock.RowTemplate.Height = 60;
            this.dtMedicineStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMedicineStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtMedicineStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMedicineStock.Size = new System.Drawing.Size(697, 410);
            this.dtMedicineStock.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dtMedicineStock.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtMedicineStock.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dtMedicineStock.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtMedicineStock.StateCommon.DataCell.Border.Width = 2;
            this.dtMedicineStock.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtMedicineStock.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtMedicineStock.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtMedicineStock.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.White;
            this.dtMedicineStock.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.White;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DarkGray;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Silver;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.ColorAngle = 20F;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.Width = 1;
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtMedicineStock.TabIndex = 42;
            this.dtMedicineStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMedicineStock_CellContentClick);
            this.dtMedicineStock.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtMedicineStock_RowsAdded);
            this.dtMedicineStock.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtMedicineStock_RowsRemoved);
            // 
            // Slc
            // 
            this.Slc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            this.Slc.DefaultCellStyle = dataGridViewCellStyle2;
            this.Slc.FalseValue = null;
            this.Slc.HeaderText = "Select";
            this.Slc.IndeterminateValue = null;
            this.Slc.Name = "Slc";
            this.Slc.TrueValue = null;
            this.Slc.Visible = false;
            this.Slc.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "Selekto";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 50;
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRows.CornerRoundingRadius = 10F;
            this.btnDeleteRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRows.Location = new System.Drawing.Point(1362, 556);
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(77, 33);
            this.btnDeleteRows.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(106)))), ((int)(((byte)(119)))));
            this.btnDeleteRows.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(106)))), ((int)(((byte)(119)))));
            this.btnDeleteRows.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeleteRows.StateCommon.Border.Rounding = 10F;
            this.btnDeleteRows.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDeleteRows.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRows.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteRows.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteRows.TabIndex = 43;
            this.btnDeleteRows.Values.Text = "Fshi";
            this.btnDeleteRows.Click += new System.EventHandler(this.btnDeleteRows_Click);
            // 
            // totRows
            // 
            this.totRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totRows.AutoSize = true;
            this.totRows.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totRows.Location = new System.Drawing.Point(742, 569);
            this.totRows.Name = "totRows";
            this.totRows.Size = new System.Drawing.Size(165, 19);
            this.totRows.TabIndex = 47;
            this.totRows.Text = "Total i Rreshtave : 0";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMedicineName.CueHint.CueHintText = "Emri";
            this.txtMedicineName.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicineName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtMedicineName.Location = new System.Drawing.Point(895, 100);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(132, 31);
            this.txtMedicineName.StateCommon.Border.ColorAngle = 1F;
            this.txtMedicineName.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtMedicineName.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtMedicineName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMedicineName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtMedicineName.StateCommon.Border.Rounding = 7F;
            this.txtMedicineName.StateCommon.Border.Width = 1;
            this.txtMedicineName.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicineName.TabIndex = 48;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(839, 105);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(56, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 49;
            this.kryptonLabel5.Values.Text = "Kërko :";
            // 
            // txtgnrc
            // 
            this.txtgnrc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtgnrc.CueHint.CueHintText = "Emri Generic";
            this.txtgnrc.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgnrc.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtgnrc.Location = new System.Drawing.Point(1033, 100);
            this.txtgnrc.Name = "txtgnrc";
            this.txtgnrc.Size = new System.Drawing.Size(132, 31);
            this.txtgnrc.StateCommon.Border.ColorAngle = 1F;
            this.txtgnrc.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtgnrc.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtgnrc.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtgnrc.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtgnrc.StateCommon.Border.Rounding = 7F;
            this.txtgnrc.StateCommon.Border.Width = 1;
            this.txtgnrc.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtgnrc.TabIndex = 50;
            this.txtgnrc.TextChanged += new System.EventHandler(this.txtgnrc_TextChanged);
            // 
            // txtSupp
            // 
            this.txtSupp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSupp.CueHint.CueHintText = "Emri Generic";
            this.txtSupp.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupp.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtSupp.Location = new System.Drawing.Point(1171, 100);
            this.txtSupp.Name = "txtSupp";
            this.txtSupp.Size = new System.Drawing.Size(132, 31);
            this.txtSupp.StateCommon.Border.ColorAngle = 1F;
            this.txtSupp.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtSupp.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtSupp.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSupp.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtSupp.StateCommon.Border.Rounding = 7F;
            this.txtSupp.StateCommon.Border.Width = 1;
            this.txtSupp.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSupp.TabIndex = 51;
            this.txtSupp.TextChanged += new System.EventHandler(this.txtSupp_TextChanged);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_repeat_40;
            this.Refresh.Location = new System.Drawing.Point(1309, 91);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(40, 40);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Refresh.TabIndex = 52;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // err4
            // 
            this.err4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err4.Location = new System.Drawing.Point(484, 197);
            this.err4.Name = "err4";
            this.err4.Size = new System.Drawing.Size(160, 36);
            this.err4.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err4.TabIndex = 53;
            this.err4.Values.Text = "Përshembull 10 Tableta\r\nose 100 ML";
            this.err4.Visible = false;
            // 
            // AddNewMedicineItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.err4);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.txtSupp);
            this.Controls.Add(this.txtgnrc);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.totRows);
            this.Controls.Add(this.btnDeleteRows);
            this.Controls.Add(this.dtMedicineStock);
            this.Controls.Add(this.err3);
            this.Controls.Add(this.err2);
            this.Controls.Add(this.err1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddMedicine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtGeneric);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtPacking);
            this.Controls.Add(this.txtMedicine);
            this.Name = "AddNewMedicineItem";
            this.Size = new System.Drawing.Size(1478, 642);
            this.Load += new System.EventHandler(this.AddNewMedicineItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtMedicine;
        private Krypton.Toolkit.KryptonTextBox txtPacking;
        private PictureBox pictureBox7;
        private Label label18;
        private Panel panel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtGeneric;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtSupplier;
        private Panel panel1;
        private Krypton.Toolkit.KryptonButton AddMedicine;
        private Label label1;
        private Krypton.Toolkit.KryptonLabel err1;
        private Krypton.Toolkit.KryptonLabel err2;
        private Krypton.Toolkit.KryptonLabel err3;
        private Krypton.Toolkit.KryptonDataGridView dtMedicineStock;
        private Krypton.Toolkit.KryptonButton btnDeleteRows;
        private Label totRows;
        private Krypton.Toolkit.KryptonTextBox txtMedicineName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtgnrc;
        private Krypton.Toolkit.KryptonTextBox txtSupp;
        private PictureBox Refresh;
        private Krypton.Toolkit.KryptonDataGridViewCheckBoxColumn Slc;
        private DataGridViewCheckBoxColumn Delete;
        private Krypton.Toolkit.KryptonLabel err4;
    }
}
