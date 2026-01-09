namespace TelefonSatisProjesi
{
    partial class TST
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TST));
            this.pic_tst = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_tst = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tst)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_tst
            // 
            this.pic_tst.BackColor = System.Drawing.Color.DimGray;
            this.pic_tst.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_tst.Image = ((System.Drawing.Image)(resources.GetObject("pic_tst.Image")));
            this.pic_tst.ImageActive = null;
            this.pic_tst.Location = new System.Drawing.Point(0, 0);
            this.pic_tst.Margin = new System.Windows.Forms.Padding(4);
            this.pic_tst.Name = "pic_tst";
            this.pic_tst.Size = new System.Drawing.Size(41, 38);
            this.pic_tst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_tst.TabIndex = 5;
            this.pic_tst.TabStop = false;
            this.pic_tst.Zoom = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(292, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 38);
            this.panel1.TabIndex = 6;
            // 
            // txt_tst
            // 
            this.txt_tst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tst.ForeColor = System.Drawing.Color.Transparent;
            this.txt_tst.Location = new System.Drawing.Point(48, 6);
            this.txt_tst.Name = "txt_tst";
            this.txt_tst.Size = new System.Drawing.Size(223, 27);
            this.txt_tst.TabIndex = 7;
            this.txt_tst.Text = "Metin";
            this.txt_tst.Click += new System.EventHandler(this.txt_tst_Click);
            // 
            // TST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(300, 38);
            this.Controls.Add(this.txt_tst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_tst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TST";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dialog";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pic_tst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuImageButton pic_tst;
        public System.Windows.Forms.Label txt_tst;
    }
}