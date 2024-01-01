namespace Pharmacy_Menagment
{
    partial class HelpFormDialog
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
            this.Body = new System.Windows.Forms.Panel();
            this.TopPnl = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.PictureBox();
            this.TopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.Color.White;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 45);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(800, 452);
            this.Body.TabIndex = 3;
            // 
            // TopPnl
            // 
            this.TopPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.TopPnl.Controls.Add(this.lblTitle);
            this.TopPnl.Controls.Add(this.Close);
            this.TopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPnl.Location = new System.Drawing.Point(0, 0);
            this.TopPnl.Name = "TopPnl";
            this.TopPnl.Size = new System.Drawing.Size(800, 45);
            this.TopPnl.TabIndex = 2;
            this.TopPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseDown);
            this.TopPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseMove);
            this.TopPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(233, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Select Medicine ";
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_close_window_40;
            this.Close.Location = new System.Drawing.Point(748, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 2;
            this.Close.TabStop = false;
            this.Close.Tag = "1";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // HelpFormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.TopPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpFormDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpFormDialog";
            this.Load += new System.EventHandler(this.HelpFormDialog_Load);
            this.TopPnl.ResumeLayout(false);
            this.TopPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Body;
        private Panel TopPnl;
        public Label lblTitle;
        private PictureBox Close;
    }
}