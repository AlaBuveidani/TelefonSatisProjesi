using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;

namespace TelefonSatisProjesi
{
    public partial class FRM_MAIN : Form
    {
        FRM_HOME frm_home = new FRM_HOME();
        FRM_KATEGORILER frm_kate = new FRM_KATEGORILER();
        int move;
        int movx;
        int movy;


        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();

        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void btn_calisan_Click(object sender, EventArgs e)
        {
            FRM_CALISANLAR frm_calisan = new FRM_CALISANLAR();
            frm_calisan.ShowDialog();
        }

        private void btn_mus_Click(object sender, EventArgs e)
        {
            FRM_MUSTERILER frm_musteriler   = new FRM_MUSTERILER();
            frm_musteriler.ShowDialog();
        }

        private void btn_tlf_Click(object sender, EventArgs e)
        {
            FRM_TELEFONLAR frm_tlf = new FRM_TELEFONLAR();
            frm_tlf.ShowDialog();
        }

        private void FORM_GETIR(Form frm)
        {
            pn_main.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Left;
            pn_main.Controls.Add(frm);
            frm.Show();
        }

        private void btn_mus_ekle_Click(object sender, EventArgs e)
        {
            FRM_MUSTERI_EKLE frm_musteri = new FRM_MUSTERI_EKLE();
            frm_musteri.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        
        private void Button7_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void btn_calisan_ekle_Click(object sender, EventArgs e)
        {
           // FRM_CALISANLAR frm_calisan = new FRM_CALISANLAR();
            //frm_calisan.ShowDialog();
            //FRM_CALISAN_EKLE2 frm_calisan_ekle = new FRM_CALISAN_EKLE2();
            //frm_calisan_ekle.ShowDialog();
        }


        private void btn_tlf_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_TELEFONLAR frm_telefon_ekle = new FRM_TELEFONLAR();
            frm_telefon_ekle.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FRM_MUSTERILER frm_mus = new FRM_MUSTERILER();
            frm_mus.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_CALISANLAR frm_cal = new FRM_CALISANLAR();
            frm_cal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_HOME frm_home = new FRM_HOME();    
            frm_home.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //collapse
        private void btn_collapse_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 142)
            {
                pn_navbar.Width = 35;
                pn_titlenav.Visible = false;
                pn_headernavbar.Height = 165;
            }
            else
            {
                pn_navbar.Width = 142;
                pn_titlenav.Visible = true;
                pn_headernavbar.Height = 165;
            }
        }

        //load kategori
        private void btn_kat_Click(object sender, EventArgs e)
        {
            FRM_KATEGORILER frm_kat = new FRM_KATEGORILER();
            frm_kat.ShowDialog();
            //pn_main.Controls.Clear();
            //pn_main.Controls.Add(frm_kate.pn_kate);
        }

        private void btn_mus_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_calisan_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_sat_Click(object sender, EventArgs e)
        {

        }

        private void btn_sat_yap_Click(object sender, EventArgs e)
        {

        }

        //load home page
        private void btn_ana_Click(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();
            pn_main.Controls.Add(frm_home.pn_home);
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            pn_main.Controls.Clear();
            pn_main.Controls.Add(frm_home.pn_home);
        }
    }
}
