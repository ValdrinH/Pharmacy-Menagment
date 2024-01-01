namespace Pharmacy_Menagment.UserControlsItem
{
    partial class InoviceManage
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
            this.dtMedicineStock = new Krypton.Toolkit.KryptonDataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtMedicine = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.lblnum = new System.Windows.Forms.Label();
            this.backmove = new Krypton.Toolkit.KryptonButton();
            this.forwardmove = new Krypton.Toolkit.KryptonButton();
            this.totRows = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFillimit = new Krypton.Toolkit.KryptonDateTimePicker();
            this.Refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.SuspendLayout();
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
            this.Delete});
            this.dtMedicineStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtMedicineStock.Location = new System.Drawing.Point(39, 172);
            this.dtMedicineStock.MultiSelect = false;
            this.dtMedicineStock.Name = "dtMedicineStock";
            this.dtMedicineStock.RowHeadersVisible = false;
            this.dtMedicineStock.RowTemplate.Height = 60;
            this.dtMedicineStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMedicineStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtMedicineStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMedicineStock.Size = new System.Drawing.Size(1384, 401);
            this.dtMedicineStock.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dtMedicineStock.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtMedicineStock.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dtMedicineStock.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtMedicineStock.StateCommon.DataCell.Border.Width = 2;
            this.dtMedicineStock.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtMedicineStock.TabIndex = 42;
            this.dtMedicineStock.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtMedicineStock_RowsAdded);
            this.dtMedicineStock.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtMedicineStock_RowsRemoved);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_remove_40;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Delete.Name = "Delete";
            this.Delete.Width = 70;
            // 
            // txtMedicine
            // 
            this.txtMedicine.CueHint.CueHintText = "Emri Klientit";
            this.txtMedicine.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtMedicine.CueHint.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.txtMedicine.Location = new System.Drawing.Point(163, 108);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(213, 36);
            this.txtMedicine.StateCommon.Border.ColorAngle = 1F;
            this.txtMedicine.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtMedicine.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtMedicine.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMedicine.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtMedicine.StateCommon.Border.Rounding = 7F;
            this.txtMedicine.StateCommon.Border.Width = 1;
            this.txtMedicine.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicine.TabIndex = 44;
            this.txtMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(41, 113);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(128, 28);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 43;
            this.kryptonLabel1.Values.Text = "Kërko sipas :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(97, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Manage Existing Inovice";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_stocks_60;
            this.pictureBox7.Location = new System.Drawing.Point(39, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(60, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(93, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(229, 32);
            this.label18.TabIndex = 46;
            this.label18.Text = "Manage Invoice";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel8.Location = new System.Drawing.Point(39, 65);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1400, 3);
            this.panel8.TabIndex = 47;
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(39, 161);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(1384, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // lblnum
            // 
            this.lblnum.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblnum.Location = new System.Drawing.Point(698, 602);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(57, 19);
            this.lblnum.TabIndex = 59;
            this.lblnum.Text = "0/100";
            // 
            // backmove
            // 
            this.backmove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.backmove.CornerRoundingRadius = 10F;
            this.backmove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backmove.Location = new System.Drawing.Point(620, 579);
            this.backmove.Name = "backmove";
            this.backmove.Size = new System.Drawing.Size(52, 45);
            this.backmove.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(139)))), ((int)(((byte)(221)))));
            this.backmove.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(139)))), ((int)(((byte)(221)))));
            this.backmove.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backmove.StateCommon.Border.Rounding = 10F;
            this.backmove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backmove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backmove.TabIndex = 58;
            this.backmove.Values.Text = "<";
            // 
            // forwardmove
            // 
            this.forwardmove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.forwardmove.CornerRoundingRadius = 10F;
            this.forwardmove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forwardmove.Location = new System.Drawing.Point(780, 579);
            this.forwardmove.Name = "forwardmove";
            this.forwardmove.Size = new System.Drawing.Size(52, 45);
            this.forwardmove.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(139)))), ((int)(((byte)(221)))));
            this.forwardmove.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(139)))), ((int)(((byte)(221)))));
            this.forwardmove.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.forwardmove.StateCommon.Border.Rounding = 10F;
            this.forwardmove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.forwardmove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forwardmove.TabIndex = 57;
            this.forwardmove.Values.Text = ">";
            // 
            // totRows
            // 
            this.totRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totRows.AutoSize = true;
            this.totRows.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totRows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totRows.Location = new System.Drawing.Point(23, 601);
            this.totRows.Name = "totRows";
            this.totRows.Size = new System.Drawing.Size(165, 19);
            this.totRows.TabIndex = 56;
            this.totRows.Text = "Total i Rreshtave : 0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.panel1.Location = new System.Drawing.Point(23, 626);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 3);
            this.panel1.TabIndex = 55;
            // 
            // dtFillimit
            // 
            this.dtFillimit.CornerRoundingRadius = 10F;
            this.dtFillimit.Location = new System.Drawing.Point(393, 112);
            this.dtFillimit.Name = "dtFillimit";
            this.dtFillimit.Size = new System.Drawing.Size(272, 32);
            this.dtFillimit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtFillimit.StateCommon.Border.Rounding = 10F;
            this.dtFillimit.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtFillimit.TabIndex = 104;
            this.dtFillimit.Tag = "2";
            // 
            // Refresh
            // 
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_repeat_40;
            this.Refresh.Location = new System.Drawing.Point(679, 108);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(40, 40);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Refresh.TabIndex = 105;
            this.Refresh.TabStop = false;
            // 
            // InoviceManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dtFillimit);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.backmove);
            this.Controls.Add(this.forwardmove);
            this.Controls.Add(this.totRows);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtMedicine);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.dtMedicineStock);
            this.Name = "InoviceManage";
            this.Size = new System.Drawing.Size(1478, 642);
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dtMedicineStock;
        private Krypton.Toolkit.KryptonTextBox txtMedicine;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Label label1;
        private PictureBox pictureBox7;
        private Label label18;
        private Panel panel8;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Label lblnum;
        private Krypton.Toolkit.KryptonButton backmove;
        private Krypton.Toolkit.KryptonButton forwardmove;
        private Label totRows;
        private Panel panel1;
        private Krypton.Toolkit.KryptonDateTimePicker dtFillimit;
        private DataGridViewImageColumn Delete;
        private PictureBox Refresh;
    }
}
