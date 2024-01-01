namespace Pharmacy_Menagment.UserControlsItem.HelpFormChildren
{
    partial class ListOfSupplier
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
            this.dtSupplier = new Krypton.Toolkit.KryptonDataGridView();
            this.SelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dtSupplier
            // 
            this.dtSupplier.AllowUserToAddRows = false;
            this.dtSupplier.AllowUserToResizeColumns = false;
            this.dtSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtSupplier.ColumnHeadersHeight = 60;
            this.dtSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectBtn});
            this.dtSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtSupplier.Location = new System.Drawing.Point(0, 0);
            this.dtSupplier.MultiSelect = false;
            this.dtSupplier.Name = "dtSupplier";
            this.dtSupplier.ReadOnly = true;
            this.dtSupplier.RowHeadersVisible = false;
            this.dtSupplier.RowTemplate.Height = 60;
            this.dtSupplier.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtSupplier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSupplier.Size = new System.Drawing.Size(609, 491);
            this.dtSupplier.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dtSupplier.StateCommon.Background.Color2 = System.Drawing.Color.Gray;
            this.dtSupplier.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dtSupplier.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.dtSupplier.StateCommon.DataCell.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtSupplier.StateCommon.DataCell.Border.Width = 2;
            this.dtSupplier.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtSupplier.StateCommon.DataCell.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtSupplier.StateCommon.DataCell.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtSupplier.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dtSupplier.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dtSupplier.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.DarkGray;
            this.dtSupplier.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Silver;
            this.dtSupplier.StateCommon.HeaderColumn.Border.ColorAngle = 20F;
            this.dtSupplier.StateCommon.HeaderColumn.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.dtSupplier.StateCommon.HeaderColumn.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtSupplier.StateCommon.HeaderColumn.Border.Width = 1;
            this.dtSupplier.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtSupplier.StateCommon.HeaderColumn.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.dtSupplier.StateCommon.HeaderColumn.Content.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.dtSupplier.TabIndex = 43;
            this.dtSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSupplier_CellContentClick);
            // 
            // SelectBtn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(175)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.SelectBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectBtn.HeaderText = "";
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.ReadOnly = true;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseColumnTextForButtonValue = true;
            // 
            // ListOfSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtSupplier);
            this.Name = "ListOfSupplier";
            this.Size = new System.Drawing.Size(609, 491);
            this.Load += new System.EventHandler(this.ListOfSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dtSupplier;
        private DataGridViewButtonColumn SelectBtn;
    }
}
