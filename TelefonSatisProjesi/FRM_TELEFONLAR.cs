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

namespace TelefonSatisProjesi
{
    public partial class FRM_TELEFONLAR : Form
    {
        int move;
        int movx;
        int movy;

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        

        public FRM_TELEFONLAR()
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
            var sql = "SELECT ID,KAT,MARKA,MODEL,BELLEK,PRICE,ISLEMCI,RENK,STOK FROM TBTELEFON";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "KATEGORI";
            dataGridView1.Columns[2].HeaderText = "MARKA";
            dataGridView1.Columns[3].HeaderText = "MODEL";
            dataGridView1.Columns[4].HeaderText = "BELLEK KAPASİTESİ";
            dataGridView1.Columns[5].HeaderText = "FİYAT";
            dataGridView1.Columns[6].HeaderText = "IŞLEMCI HIZI";
            dataGridView1.Columns[7].HeaderText = "TELEFON RENGI";
            dataGridView1.Columns[8].HeaderText = "STOK";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            FRM_TELEFON_EKLE frm_ekle = new FRM_TELEFON_EKLE();
            frm_ekle.btn_ekle.Text = "Ekle";
            frm_ekle.state = 0;
            bunifuTransition1.ShowSync(frm_ekle);
        }

        private void btn_degis_Click(object sender, EventArgs e)
        {
            FRM_TELEFON_EKLE frm_ekle = new FRM_TELEFON_EKLE();
            frm_ekle.btn_ekle.Text = "Değiş";
            frm_ekle.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_ekle);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT BELLEK,ISLEMCI,PRICE,GARANTI,STOK,RENK,KAT,MARKA,MODEL,RAM FROM TBTELEFON WHERE ID=@ID";
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
                    List.Add(Convert.ToString(rd[7]));
                    List.Add(Convert.ToString(rd[8]));
                    List.Add(Convert.ToString(rd[9]));
                }
                frm_ekle.txtbox_bel.Text = List[0];
                frm_ekle.txt_isl.Text = List[1];
                frm_ekle.txt_fiy.Text = List[2];
                frm_ekle.txt_gar.Text = List[3];
                frm_ekle.txt_sto.Text = List[4];
                frm_ekle.txt_ren.Text = List[5];
                frm_ekle.txtbox_kat.Text = List[6];
                frm_ekle.txtbox_mar.Text = List[7];
                frm_ekle.txtbox_mod.Text = List[8];
                frm_ekle.txtbox_ram.Text = List[9];
                con.Close();

                // Read image from database
                con.Open();
                cmd.CommandText = "SELECT RESIM FROM TBTELEFON WHERE ID=@IDRESIM";
                cmd.Parameters.AddWithValue("@IDRESIM", dataGridView1.CurrentRow.Cells[0].Value);
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream();
                ms.Write(img, 0, img.Length);
                frm_ekle.resim.Image=Image.FromStream(ms);

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
            FRM_TEL_AYRINT frm_ayr = new FRM_TEL_AYRINT();
            bunifuTransition1.ShowSync(frm_ayr);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT BELLEK,ISLEMCI,PRICE,GARANTI,STOK,RENK,KAT,MARKA,MODEL,RAM FROM TBTELEFON WHERE ID=@ID";
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
                    List.Add(Convert.ToString(rd[7]));
                    List.Add(Convert.ToString(rd[8]));
                    List.Add(Convert.ToString(rd[9]));
                }
                frm_ayr.txt_bel.Text = List[0];
                frm_ayr.txt_isl.Text = List[1];
                frm_ayr.txt_fiy.Text = List[2];
                frm_ayr.txt_gar.Text = List[3];
                frm_ayr.txt_sto.Text = List[4];
                frm_ayr.txt_ren.Text = List[5];
                frm_ayr.txt_kat.Text = List[6];
                frm_ayr.txt_mar.Text = List[7];
                frm_ayr.txt_mod.Text = List[8];
                frm_ayr.txt_ram.Text = List[9];
                con.Close();

                // Read image from database
                con.Open();
                cmd.CommandText = "SELECT RESIM FROM TBTELEFON WHERE ID=@IDRESIM";
                cmd.Parameters.AddWithValue("@IDRESIM", dataGridView1.CurrentRow.Cells[0].Value);
                byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream();
                ms.Write(img, 0, img.Length);
                frm_ayr.resim.Image = Image.FromStream(ms);

                


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
            cmd.CommandText = "DELETE FROM TBTELEFON WHERE ID=@ID";
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
    }
}

