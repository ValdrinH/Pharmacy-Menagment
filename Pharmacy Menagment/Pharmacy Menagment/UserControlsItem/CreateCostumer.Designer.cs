namespace Pharmacy_Menagment.UserControlsItem
{
    partial class CreateCostumer
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
            this.err1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.txtAddress = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txtNumber = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txtCustomerName = new Krypton.Toolkit.KryptonTextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtNameDoc = new Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddCostumer = new Krypton.Toolkit.KryptonButton();
            this.CitySelect = new Krypton.Toolkit.KryptonComboBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.txtNr = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtMedicineName = new Krypton.Toolkit.KryptonTextBox();
            this.totRows = new System.Windows.Forms.Label();
            this.btnDeleteRows = new Krypton.Toolkit.KryptonButton();
            this.dtMedicineStock = new Krypton.Toolkit.KryptonDataGridView();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Selekto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitySelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).BeginInit();
            this.SuspendLayout();
            // 
            // err1
            // 
            this.err1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.err1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.err1.Location = new System.Drawing.Point(71, 565);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(342, 20);
            this.err1.StateCommon.ShortText.Color1 = System.Drawing.Color.Maroon;
            this.err1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.err1.TabIndex = 33;
            this.err1.Values.Text = "Kontrolloni fushat nëse janë të gjitha të plotësuara !";
            this.err1.Visible = false;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(39, 312);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(65, 20);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 32;
            this.kryptonLabel4.Values.Text = "Adresa :";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddress.CueHint.CueHintText = "Address";
            this.txtAddress.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtAddress.Location = new System.Drawing.Point(39, 338);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(412, 60);
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
            this.txtAddress.TabIndex = 31;
            this.txtAddress.MouseEnter += new System.EventHandler(this.txtCustomerName_MouseEnter);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(39, 188);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 30;
            this.kryptonLabel3.Values.Text = "Numri Tel :";
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumber.CueHint.CueHintText = "+123";
            this.txtNumber.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtNumber.Location = new System.Drawing.Point(39, 214);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(412, 31);
            this.txtNumber.StateCommon.Border.ColorAngle = 1F;
            this.txtNumber.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtNumber.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtNumber.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNumber.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtNumber.StateCommon.Border.Rounding = 7F;
            this.txtNumber.StateCommon.Border.Width = 1;
            this.txtNumber.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.TabIndex = 29;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            this.txtNumber.MouseEnter += new System.EventHandler(this.txtCustomerName_MouseEnter);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(39, 114);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 28;
            this.kryptonLabel1.Values.Text = "Emri klientit :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerName.CueHint.CueHintText = "Emri";
            this.txtCustomerName.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtCustomerName.Location = new System.Drawing.Point(39, 140);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(412, 31);
            this.txtCustomerName.StateCommon.Border.ColorAngle = 1F;
            this.txtCustomerName.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtCustomerName.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtCustomerName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerName.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtCustomerName.StateCommon.Border.Rounding = 7F;
            this.txtCustomerName.StateCommon.Border.Width = 1;
            this.txtCustomerName.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerName.TabIndex = 27;
            this.txtCustomerName.MouseEnter += new System.EventHandler(this.txtCustomerName_MouseEnter);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_add_administrator_60;
            this.pictureBox7.Location = new System.Drawing.Point(39, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(93, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(322, 32);
            this.label18.TabIndex = 36;
            this.label18.Text = "Add/Remove Customer";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel8.Location = new System.Drawing.Point(39, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1400, 3);
            this.panel8.TabIndex = 37;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel6.Location = new System.Drawing.Point(39, 415);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(103, 20);
            this.kryptonLabel6.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 40;
            this.kryptonLabel6.Values.Text = "Emri Doktorrit :";
            // 
            // txtNameDoc
            // 
            this.txtNameDoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNameDoc.CueHint.CueHintText = "Emri D.";
            this.txtNameDoc.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameDoc.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtNameDoc.Location = new System.Drawing.Point(39, 441);
            this.txtNameDoc.Name = "txtNameDoc";
            this.txtNameDoc.Size = new System.Drawing.Size(412, 31);
            this.txtNameDoc.StateCommon.Border.ColorAngle = 1F;
            this.txtNameDoc.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtNameDoc.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtNameDoc.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNameDoc.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtNameDoc.StateCommon.Border.Rounding = 7F;
            this.txtNameDoc.StateCommon.Border.Width = 1;
            this.txtNameDoc.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameDoc.TabIndex = 39;
            this.txtNameDoc.MouseEnter += new System.EventHandler(this.txtCustomerName_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(49, 618);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 3);
            this.panel1.TabIndex = 44;
            // 
            // AddCostumer
            // 
            this.AddCostumer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddCostumer.CornerRoundingRadius = 10F;
            this.AddCostumer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddCostumer.Location = new System.Drawing.Point(39, 503);
            this.AddCostumer.Name = "AddCostumer";
            this.AddCostumer.Size = new System.Drawing.Size(412, 44);
            this.AddCostumer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.AddCostumer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.AddCostumer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.AddCostumer.StateCommon.Border.Rounding = 10F;
            this.AddCostumer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.AddCostumer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCostumer.TabIndex = 48;
            this.AddCostumer.Values.Text = "Shto Klientin";
            this.AddCostumer.Click += new System.EventHandler(this.AddCostumer_Click);
            // 
            // CitySelect
            // 
            this.CitySelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CitySelect.CornerRoundingRadius = 10F;
            this.CitySelect.DropDownWidth = 400;
            this.CitySelect.IntegralHeight = false;
            this.CitySelect.Items.AddRange(new object[] {
            "1 - Pristina",
            "2 - Prizren",
            "3 - Ferizaj",
            "4 - Pejë",
            "5 - Gjakovë",
            "6 - Gjilan",
            "7 - Podujevë",
            "8 - Mitrovicë",
            "9 - Vushtrri",
            "10 - Suharekë",
            "11 - Lipjan",
            "12 - Kojskë",
            "13 - Rahovec",
            "14 - Vranjak",
            "15 - Malishevë",
            "16 - Skenderaj",
            "17 - Viti",
            "18 - Deçan",
            "19 - Istog",
            "20 - Klinë",
            "21 - Kamenicë",
            "22 - Dragash",
            "23 - Fushë Kosovë",
            "24 - Kaçanik",
            "25 - Shtime",
            "26 - Obiliq",
            "27 - Leposaviq",
            "28 - Zveçan",
            "29 - Zubin Potok",
            "30 - Matiçan",
            "31 - Shtërpcë",
            "32 - Pozharan",
            "33 - Graçanicë",
            "34 - Novobërdë",
            "35 - Hani i Elezit",
            "36 - Dushanovë",
            "37 - Junik"});
            this.CitySelect.Location = new System.Drawing.Point(39, 266);
            this.CitySelect.Name = "CitySelect";
            this.CitySelect.Size = new System.Drawing.Size(412, 31);
            this.CitySelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CitySelect.StateCommon.ComboBox.Border.Rounding = 10F;
            this.CitySelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CitySelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CitySelect.TabIndex = 60;
            this.CitySelect.Text = "Zgjedh Qytetin e banimit";
            // 
            // Refresh
            // 
            this.Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_repeat_40;
            this.Refresh.Location = new System.Drawing.Point(1249, 94);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(40, 40);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Refresh.TabIndex = 68;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // txtNr
            // 
            this.txtNr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNr.CueHint.CueHintText = "+123";
            this.txtNr.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNr.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtNr.Location = new System.Drawing.Point(1111, 103);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(132, 31);
            this.txtNr.StateCommon.Border.ColorAngle = 1F;
            this.txtNr.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtNr.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtNr.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNr.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtNr.StateCommon.Border.Rounding = 7F;
            this.txtNr.StateCommon.Border.Width = 1;
            this.txtNr.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNr.TabIndex = 66;
            this.txtNr.TextChanged += new System.EventHandler(this.txtNr_TextChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonLabel5.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel5.Location = new System.Drawing.Point(867, 109);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(106, 20);
            this.kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 65;
            this.kryptonLabel5.Values.Text = "Kërko Klientin :";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMedicineName.CueHint.CueHintText = "Emri";
            this.txtMedicineName.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicineName.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtMedicineName.Location = new System.Drawing.Point(973, 103);
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
            this.txtMedicineName.TabIndex = 64;
            this.txtMedicineName.TextChanged += new System.EventHandler(this.txtMedicineName_TextChanged);
            // 
            // totRows
            // 
            this.totRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totRows.AutoSize = true;
            this.totRows.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totRows.Location = new System.Drawing.Point(742, 572);
            this.totRows.Name = "totRows";
            this.totRows.Size = new System.Drawing.Size(165, 19);
            this.totRows.TabIndex = 63;
            this.totRows.Text = "Total i Rreshtave : 0";
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRows.CornerRoundingRadius = 10F;
            this.btnDeleteRows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteRows.Location = new System.Drawing.Point(1362, 559);
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
            this.btnDeleteRows.TabIndex = 62;
            this.btnDeleteRows.Values.Text = "Fshi";
            this.btnDeleteRows.Click += new System.EventHandler(this.btnDeleteRows_Click);
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
            this.Check,
            this.Selekto});
            this.dtMedicineStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtMedicineStock.Location = new System.Drawing.Point(742, 140);
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
            this.dtMedicineStock.TabIndex = 61;
            this.dtMedicineStock.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtMedicineStock_CellBeginEdit);
            this.dtMedicineStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtMedicineStock_CellFormatting);
            this.dtMedicineStock.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMedicineStock_CellValueChanged);
            this.dtMedicineStock.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtMedicineStock_RowsAdded);
            this.dtMedicineStock.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtMedicineStock_RowsRemoved);
            // 
            // Check
            // 
            this.Check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Check.HeaderText = "";
            this.Check.Name = "Check";
            this.Check.ReadOnly = true;
            this.Check.Visible = false;
            this.Check.Width = 50;
            // 
            // Selekto
            // 
            this.Selekto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Selekto.HeaderText = "Selekto";
            this.Selekto.Name = "Selekto";
            this.Selekto.Width = 80;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CornerRoundingRadius = 10F;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(1279, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 33);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 10F;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.TabIndex = 69;
            this.btnSave.Values.Text = "Ruaj";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CreateCostumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.txtNr);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.totRows);
            this.Controls.Add(this.btnDeleteRows);
            this.Controls.Add(this.dtMedicineStock);
            this.Controls.Add(this.CitySelect);
            this.Controls.Add(this.AddCostumer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtNameDoc);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.err1);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "CreateCostumer";
            this.Size = new System.Drawing.Size(1478, 642);
            this.Load += new System.EventHandler(this.CreateCostumer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitySelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel err1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonTextBox txtAddress;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox txtNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtCustomerName;
        private PictureBox pictureBox7;
        private Label label18;
        private Panel panel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtNameDoc;
        private Panel panel1;
        private Krypton.Toolkit.KryptonButton AddCostumer;
        private Krypton.Toolkit.KryptonComboBox CitySelect;
        private PictureBox Refresh;
        private Krypton.Toolkit.KryptonTextBox txtNr;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtMedicineName;
        private Label totRows;
        private Krypton.Toolkit.KryptonButton btnDeleteRows;
        private Krypton.Toolkit.KryptonDataGridView dtMedicineStock;
        private Krypton.Toolkit.KryptonButton btnSave;
        private DataGridViewCheckBoxColumn Check;
        private DataGridViewCheckBoxColumn Selekto;
    }
}
