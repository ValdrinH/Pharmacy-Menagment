namespace Pharmacy_Menagment.UserControlsItem.HelpFormChildren
{
    partial class ListUsersItem
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
            this.Name = new Krypton.Toolkit.KryptonLabel();
            this.Nr = new Krypton.Toolkit.KryptonLabel();
            this.kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.Name.Location = new System.Drawing.Point(18, 12);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(94, 20);
            this.Name.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name.TabIndex = 22;
            this.Name.Values.Text = "Emri Mbiemri";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            this.Name.MouseLeave += new System.EventHandler(this.ListUsers_MouseLeave);
            this.Name.MouseHover += new System.EventHandler(this.ListUsers_MouseHover);
            // 
            // Nr
            // 
            this.Nr.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.Nr.Location = new System.Drawing.Point(135, 12);
            this.Nr.Name = "Nr";
            this.Nr.Size = new System.Drawing.Size(78, 20);
            this.Nr.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nr.StateCommon.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nr.TabIndex = 23;
            this.Nr.Values.Text = "044512816";
            this.Nr.Click += new System.EventHandler(this.Name_Click);
            this.Nr.MouseLeave += new System.EventHandler(this.ListUsers_MouseLeave);
            this.Nr.MouseHover += new System.EventHandler(this.ListUsers_MouseHover);
            // 
            // kryptonBorderEdge1
            // 
            this.kryptonBorderEdge1.Location = new System.Drawing.Point(24, 41);
            this.kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            this.kryptonBorderEdge1.Size = new System.Drawing.Size(189, 1);
            this.kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // ListUsersItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.kryptonBorderEdge1);
            this.Controls.Add(this.Nr);
            this.Controls.Add(this.Name);
            this.Size = new System.Drawing.Size(231, 45);
            this.Click += new System.EventHandler(this.Name_Click);
            this.MouseLeave += new System.EventHandler(this.ListUsers_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ListUsers_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel Name;
        private Krypton.Toolkit.KryptonLabel Nr;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
    }
}
