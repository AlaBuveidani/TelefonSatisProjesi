using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.ClipboardSource.SpreadsheetML;
using BunifuAnimatorNS;
using DevExpress.Export.Xl;

namespace TelefonSatisProjesi
{
    public partial class FRM_CALISANLAR : Form
    {
        int move;
        int movx;
        int movy;

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        
        

        public FRM_CALISANLAR()
        {
            InitializeComponent();
        }
        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
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

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        
        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }
        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }
        
        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
            var sql = "SELECT ID,ADISOYADI,NUMARA,KULADI,SIFRE,KIMLIK,DOGUM,EMAIL FROM TBSALISAN";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ADI SOYADI";
            dataGridView1.Columns[2].HeaderText = "NUMARA";
            dataGridView1.Columns[3].HeaderText = "KULLANICI ADI";
            dataGridView1.Columns[4].HeaderText = "ŞİFRE";
            dataGridView1.Columns[5].HeaderText = "TC KIMLIK";
            dataGridView1.Columns[6].HeaderText = "DOĞÜM GÜNÜ";
            dataGridView1.Columns[7].HeaderText = "EMAIL";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            FRM_CALISAN_EKLE2 frm_ekle = new FRM_CALISAN_EKLE2();
            frm_ekle.btn_ekle.Text = "Ekle";
            frm_ekle.state = 0;
            bunifuTransition1.ShowSync(frm_ekle);
        }

        private void btn_degis_Click(object sender, EventArgs e)
        {
            FRM_CALISAN_EKLE2 frm_calisan_ekle = new FRM_CALISAN_EKLE2();
            frm_calisan_ekle.btn_ekle.Text = "Değiş";
            frm_calisan_ekle.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_calisan_ekle);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT ADISOYADI,NUMARA,KULADI,SIFRE,KIMLIK,DOGUM,EMAIL FROM TBSALISAN WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                    List.Add(Convert.ToString(rd[6]));
                }
                frm_calisan_ekle.txt_adi.Text = List[0];
                frm_calisan_ekle.txt_num.Text = List[1];
                frm_calisan_ekle.txt_kul.Text = List[2];
                frm_calisan_ekle.txt_sif.Text = List[3];
                frm_calisan_ekle.txt_tck.Text = List[4];
                frm_calisan_ekle.txt_dateEdit1.Text = List[5];
                frm_calisan_ekle.txt_ema.Text = List[6];

                con.Close();

              
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }

        private void btn_ayr_Click(object sender, EventArgs e)
        {
            FRM_CALISAN_AYRINT frm_calisan_ayrint = new FRM_CALISAN_AYRINT();
            bunifuTransition1.ShowSync(frm_calisan_ayrint);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT ADISOYADI,NUMARA,KULADI,DOGUM,EMAIL,KIMLIK,SIFRE FROM TBSALISAN WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                    List.Add(Convert.ToString(rd[1]));
                    List.Add(Convert.ToString(rd[2]));
                    List.Add(Convert.ToString(rd[3]));
                    List.Add(Convert.ToString(rd[4]));
                    List.Add(Convert.ToString(rd[5]));
                    List.Add(Convert.ToString(rd[6]));
                }
                frm_calisan_ayrint.txt_adi.Text = List[0];
                frm_calisan_ayrint.txt_num.Text = List[1];
                frm_calisan_ayrint.txt_kul.Text = List[2];
                frm_calisan_ayrint.txt_dog.Text = List[3];
                frm_calisan_ayrint.txt_ema.Text = List[4];
                frm_calisan_ayrint.txt_tck.Text = List[5];
                frm_calisan_ayrint.txt_sif.Text = List[6];
                con.Close();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
            cmd.Parameters.Clear();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM TBSALISAN WHERE ID=@ID";
            cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            con.Close();
            FRM_SILINDI frms = new FRM_SILINDI();
            frms.Show();
            cmd.Parameters.Clear();
        }

        private void btn_ana_Click(object sender, EventArgs e)
        {
            FRM_MAIN frm_ana_sayfa = new FRM_MAIN();
            bunifuTransition1.ShowSync(frm_ana_sayfa);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

