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
    public partial class FRM_HOME : Form
    {
        public FRM_HOME()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_KAT_EKLE frm_kat = new FRM_KAT_EKLE();
            frm_kat.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_TELEFON_EKLE frm_tel = new FRM_TELEFON_EKLE();
            frm_tel.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_MUSTERI_EKLE frm_mus = new FRM_MUSTERI_EKLE();
            frm_mus.ShowDialog();
        }
    }
}
