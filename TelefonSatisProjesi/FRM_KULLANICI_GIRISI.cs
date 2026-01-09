using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisProjesi
{
    public partial class FRM_KULLANICI_GIRISI : Form
    {
        public FRM_KULLANICI_GIRISI()
        {
            InitializeComponent();
        }

        private void FRM_KULLANICI_GIRISI_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRM_KULL_EKLE yeni_kull = new FRM_KULL_EKLE();
            yeni_kull.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                txt_sifre2.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                txt_sifre2.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }
    }
}
