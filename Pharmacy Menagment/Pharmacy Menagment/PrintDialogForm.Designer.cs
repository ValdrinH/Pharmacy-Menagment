namespace Pharmacy_Menagment
{
    partial class PrintDialogForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtMedicineStock = new Krypton.Toolkit.KryptonDataGridView();
            this.Generate = new Krypton.Toolkit.KryptonButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.TopPanel.Controls.Add(this.lblTitle);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1325, 45);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(421, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 25);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Printo të dhënat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_close_window_40;
            this.pictureBox1.Location = new System.Drawing.Point(1282, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtMedicineStock
            // 
            this.dtMedicineStock.AllowUserToAddRows = false;
            this.dtMedicineStock.AllowUserToResizeColumns = false;
            this.dtMedicineStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtMedicineStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtMedicineStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMedicineStock.ColumnHeadersHeight = 60;
            this.dtMedicineStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtMedicineStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtMedicineStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtMedicineStock.Location = new System.Drawing.Point(0, 45);
            this.dtMedicineStock.MultiSelect = false;
            this.dtMedicineStock.Name = "dtMedicineStock";
            this.dtMedicineStock.RowHeadersVisible = false;
            this.dtMedicineStock.RowTemplate.Height = 60;
            this.dtMedicineStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMedicineStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtMedicineStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMedicineStock.Size = new System.Drawing.Size(1325, 495);
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
            this.dtMedicineStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtMedicineStock_CellFormatting);
            // 
            // Generate
            // 
            this.Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generate.CornerRoundingRadius = 10F;
            this.Generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Generate.Location = new System.Drawing.Point(509, 551);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(304, 57);
            this.Generate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.Generate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(217)))));
            this.Generate.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Generate.StateCommon.Border.Rounding = 10F;
            this.Generate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Generate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Generate.TabIndex = 104;
            this.Generate.Values.Text = "Printo Raportin";
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // PrintDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 620);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.dtMedicineStock);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintDialogForm";
            this.Load += new System.EventHandler(this.PrintDialogForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TopPanel;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonDataGridView dtMedicineStock;
        public Label lblTitle;
        private Krypton.Toolkit.KryptonButton Generate;
    }
}