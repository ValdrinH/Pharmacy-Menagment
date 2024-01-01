namespace Pharmacy_Menagment
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.txtEmail = new Krypton.Toolkit.KryptonTextBox();
            this.txtPsw = new Krypton.Toolkit.KryptonTextBox();
            this.btnLoggin = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.picHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_user_601;
            this.pictureBox1.Location = new System.Drawing.Point(14, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_lock_screen_601;
            this.pictureBox2.Location = new System.Drawing.Point(14, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.CueHint.CueHintText = "Email";
            this.txtEmail.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtEmail.Location = new System.Drawing.Point(73, 108);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 31);
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.ColorAngle = 1F;
            this.txtEmail.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtEmail.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtEmail.StateCommon.Border.Rounding = 7F;
            this.txtEmail.StateCommon.Border.Width = 1;
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.TabIndex = 28;
            // 
            // txtPsw
            // 
            this.txtPsw.CueHint.CueHintText = "●●●●●●●●";
            this.txtPsw.CueHint.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPsw.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txtPsw.Location = new System.Drawing.Point(73, 184);
            this.txtPsw.Name = "txtPsw";
            this.txtPsw.PasswordChar = '●';
            this.txtPsw.Size = new System.Drawing.Size(274, 31);
            this.txtPsw.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtPsw.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtPsw.StateCommon.Border.ColorAngle = 1F;
            this.txtPsw.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidAllLine;
            this.txtPsw.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.txtPsw.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPsw.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighSpeed;
            this.txtPsw.StateCommon.Border.Rounding = 7F;
            this.txtPsw.StateCommon.Border.Width = 1;
            this.txtPsw.StateCommon.Content.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPsw.TabIndex = 29;
            // 
            // btnLoggin
            // 
            this.btnLoggin.CornerRoundingRadius = 10F;
            this.btnLoggin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoggin.Location = new System.Drawing.Point(14, 247);
            this.btnLoggin.Name = "btnLoggin";
            this.btnLoggin.Size = new System.Drawing.Size(333, 42);
            this.btnLoggin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.btnLoggin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.btnLoggin.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLoggin.StateCommon.Border.Rounding = 10F;
            this.btnLoggin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLoggin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoggin.TabIndex = 78;
            this.btnLoggin.Values.Text = "Kyqu";
            this.btnLoggin.Click += new System.EventHandler(this.btnLoggin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(58)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 84);
            this.panel1.TabIndex = 79;
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_close_window_40;
            this.Close.Location = new System.Drawing.Point(321, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(40, 40);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 80;
            this.Close.TabStop = false;
            this.Close.Tag = "1";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(76, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(216, 32);
            this.label18.TabIndex = 79;
            this.label18.Text = "Forma e Kyqjes";
            // 
            // picHide
            // 
            this.picHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHide.Image = global::Pharmacy_Menagment.Properties.Resources.icons8_eye_40;
            this.picHide.Location = new System.Drawing.Point(307, 181);
            this.picHide.Name = "picHide";
            this.picHide.Size = new System.Drawing.Size(40, 40);
            this.picHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHide.TabIndex = 80;
            this.picHide.TabStop = false;
            this.picHide.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 301);
            this.Controls.Add(this.picHide);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoggin);
            this.Controls.Add(this.txtPsw);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma e Kyqjes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonTextBox txtPsw;
        private Krypton.Toolkit.KryptonButton btnLoggin;
        private Panel panel1;
        private Label label18;
        private PictureBox picHide;
        private PictureBox Close;
    }
}