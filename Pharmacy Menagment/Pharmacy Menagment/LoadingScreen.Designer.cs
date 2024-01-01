namespace Pharmacy_Menagment
{
    partial class LoadingScreen
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
            this.lblnotify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnotify
            // 
            this.lblnotify.AutoSize = true;
            this.lblnotify.BackColor = System.Drawing.Color.Transparent;
            this.lblnotify.Font = new System.Drawing.Font("Century Gothic", 20.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblnotify.Location = new System.Drawing.Point(130, 280);
            this.lblnotify.Name = "lblnotify";
            this.lblnotify.Size = new System.Drawing.Size(337, 68);
            this.lblnotify.TabIndex = 52;
            this.lblnotify.Text = "Po Insertohen të dhënat\r\nJu lutem prisni...";
            this.lblnotify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pharmacy_Menagment.Properties.Resources.loading_4;
            this.ClientSize = new System.Drawing.Size(591, 421);
            this.Controls.Add(this.lblnotify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingScreen";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblnotify;
    }
}