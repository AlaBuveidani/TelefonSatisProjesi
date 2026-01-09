namespace TelefonSatisProjesi
{
    partial class Form1
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
            this.combo_kat = new System.Windows.Forms.ComboBox();
            this.database3DataSet13 = new TelefonSatisProjesi.Database3DataSet13();
            this.tBKATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBKATTableAdapter = new TelefonSatisProjesi.Database3DataSet13TableAdapters.TBKATTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBKATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_kat
            // 
            this.combo_kat.DataSource = this.tBKATBindingSource;
            this.combo_kat.DisplayMember = "KAT";
            this.combo_kat.FormattingEnabled = true;
            this.combo_kat.Location = new System.Drawing.Point(254, 107);
            this.combo_kat.Name = "combo_kat";
            this.combo_kat.Size = new System.Drawing.Size(121, 21);
            this.combo_kat.TabIndex = 0;
            this.combo_kat.ValueMember = "id";
            // 
            // database3DataSet13
            // 
            this.database3DataSet13.DataSetName = "Database3DataSet13";
            this.database3DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBKATBindingSource
            // 
            this.tBKATBindingSource.DataMember = "TBKAT";
            this.tBKATBindingSource.DataSource = this.database3DataSet13;
            // 
            // tBKATTableAdapter
            // 
            this.tBKATTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_kat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database3DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBKATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox combo_kat;
        private Database3DataSet13 database3DataSet13;
        private System.Windows.Forms.BindingSource tBKATBindingSource;
        private Database3DataSet13TableAdapters.TBKATTableAdapter tBKATTableAdapter;
    }
}