namespace Pharmacy_Menagment.UserControlsItem.HelpFormChildren
{
    partial class GetMedicineDetails
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
            this.dtMedicineStock = new Krypton.Toolkit.KryptonDataGridView();
            this.SelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Done = new System.Windows.Forms.DataGridViewButtonColumn();
            this.slc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).BeginInit();
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
            this.dtMedicineStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtMedicineStock.ColumnHeadersHeight = 60;
            this.dtMedicineStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtMedicineStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectBtn,
            this.Done,
            this.slc});
            this.dtMedicineStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtMedicineStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMedicineStock.Location = new System.Drawing.Point(0, 0);
            this.dtMedicineStock.MultiSelect = false;
            this.dtMedicineStock.Name = "dtMedicineStock";
            this.dtMedicineStock.ReadOnly = true;
            this.dtMedicineStock.RowHeadersVisible = false;
            this.dtMedicineStock.RowTemplate.Height = 60;
            this.dtMedicineStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtMedicineStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtMedicineStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtMedicineStock.Size = new System.Drawing.Size(609, 491);
            this.dtMedicineStock.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dtMedicineStock.StateCommon.Background.Color2 = System.Drawing.Color.Gray;
            this.dtMedicineStock.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtMedicineStock.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dtMedicineStock.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtMedicineStock.StateCommon.DataCell.Border.Width = 2;
            this.dtMedicineStock.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtMedicineStock.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtMedicineStock.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtMedicineStock.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dtMedicineStock.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DarkGray;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Silver;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.ColorAngle = 20F;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtMedicineStock.StateCommon.HeaderColumn.Border.Width = 1;
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtMedicineStock.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtMedicineStock.TabIndex = 42;
            this.dtMedicineStock.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dtMedicineStock_CellBeginEdit);
            this.dtMedicineStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtMedicineStock_CellContentClick);
            this.dtMedicineStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtMedicineStock_CellFormatting);
            // 
            // SelectBtn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(170)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.SelectBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBtn.HeaderText = "";
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.ReadOnly = true;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseColumnTextForButtonValue = true;
            // 
            // Done
            // 
            this.Done.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Done.HeaderText = "Përfundo";
            this.Done.Name = "Done";
            this.Done.ReadOnly = true;
            this.Done.Text = "Përfundo";
            this.Done.UseColumnTextForButtonValue = true;
            this.Done.Visible = false;
            this.Done.Width = 90;
            // 
            // slc
            // 
            this.slc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.slc.HeaderText = "";
            this.slc.Name = "slc";
            this.slc.ReadOnly = true;
            this.slc.Visible = false;
            this.slc.Width = 30;
            // 
            // GetMedicineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtMedicineStock);
            this.Name = "GetMedicineDetails";
            this.Size = new System.Drawing.Size(609, 491);
            this.Load += new System.EventHandler(this.GetMedicineDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtMedicineStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dtMedicineStock;
        private DataGridViewButtonColumn SelectBtn;
        private DataGridViewButtonColumn Done;
        private DataGridViewCheckBoxColumn slc;
    }
}
