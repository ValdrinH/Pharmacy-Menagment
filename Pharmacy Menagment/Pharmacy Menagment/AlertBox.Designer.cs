namespace Pharmacy_Menagment
{
    partial class AlertBox
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
            components = new System.ComponentModel.Container();
            IconMsg = new PictureBox();
            lblMessagetit = new Label();
            Close = new PictureBox();
            lblDesc = new Label();
            progressBar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)IconMsg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // IconMsg
            // 
            IconMsg.Image = Properties.Resources.icons8_ok_80;
            IconMsg.Location = new Point(22, 14);
            IconMsg.Name = "IconMsg";
            IconMsg.Size = new Size(80, 80);
            IconMsg.SizeMode = PictureBoxSizeMode.AutoSize;
            IconMsg.TabIndex = 0;
            IconMsg.TabStop = false;
            IconMsg.Click += AlertBox_Click;
            // 
            // lblMessagetit
            // 
            lblMessagetit.AutoSize = true;
            lblMessagetit.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessagetit.ForeColor = Color.FromArgb(64, 64, 64);
            lblMessagetit.Location = new Point(128, 14);
            lblMessagetit.Name = "lblMessagetit";
            lblMessagetit.Size = new Size(134, 23);
            lblMessagetit.TabIndex = 2;
            lblMessagetit.Text = "Message Title";
            lblMessagetit.Click += AlertBox_Click;
            // 
            // Close
            // 
            Close.Cursor = Cursors.Hand;
            Close.Image = Properties.Resources.icons8_close_window_40;
            Close.Location = new Point(458, 4);
            Close.Name = "Close";
            Close.Size = new Size(40, 40);
            Close.SizeMode = PictureBoxSizeMode.AutoSize;
            Close.TabIndex = 3;
            Close.TabStop = false;
            Close.ClientSizeChanged += Close_ClientSizeChanged;
            Close.Click += Close_Click;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Century Gothic", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = Color.FromArgb(64, 64, 64);
            lblDesc.Location = new Point(3, 0);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(98, 19);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Message Title";
            lblDesc.TextAlign = ContentAlignment.MiddleLeft;
            lblDesc.Click += AlertBox_Click;
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.ActiveCaptionText;
            progressBar.ForeColor = SystemColors.Desktop;
            progressBar.Location = new Point(2, 111);
            progressBar.Maximum = 111;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(496, 3);
            progressBar.TabIndex = 5;
            progressBar.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(lblDesc);
            flowLayoutPanel1.Location = new Point(128, 40);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(370, 74);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // AlertBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 117);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(progressBar);
            Controls.Add(Close);
            Controls.Add(lblMessagetit);
            Controls.Add(IconMsg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlertBox";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += AlertBox_Load;
            Click += AlertBox_Click;
            ((System.ComponentModel.ISupportInitialize)IconMsg).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox IconMsg;
        private Label lblMessagetit;
        private PictureBox Close;
        private Label lblDesc;
        private ProgressBar progressBar;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}