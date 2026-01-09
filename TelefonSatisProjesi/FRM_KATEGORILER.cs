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
    public partial class FRM_KATEGORILER : Form
    {
        int move;
        int movx;
        int movy;

        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();
        

        public FRM_KATEGORILER()
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
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database3;Integrated Security=True");                                                                                
            var sql = "SELECT ID,KAT FROM TBKAT";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "KATEGORI";
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            FRM_KAT_EKLE frm_ekle = new FRM_KAT_EKLE();
            frm_ekle.btn_ekle.Text = "Ekle";
            frm_ekle.state = 0;
            bunifuTransition1.ShowSync(frm_ekle);
        }

        private void btn_degis_Click(object sender, EventArgs e)
        {
            FRM_KAT_EKLE frm_ekle = new FRM_KAT_EKLE();
            frm_ekle.btn_ekle.Text = "Değiş";
            frm_ekle.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            bunifuTransition1.ShowSync(frm_ekle);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database3;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "KAT FROM TBKAT WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                frm_ekle.TXT_KAT.Text = List[0];
                con.Close();

                // Read image from database
                //con.Open();
                //cmd.CommandText = "SELECT RESIM FROM TBTELEFON WHERE ID=@IDRESIM";
                //cmd.Parameters.AddWithValue("@IDRESIM", dataGridView1.CurrentRow.Cells[0].Value);
                //byte[] img = (byte[])cmd.ExecuteScalar();
                MemoryStream ms = new MemoryStream();
                //ms.Write(img, 0, img.Length);
                //frm_ekle.resim.Image=Image.FromStream(ms);

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
            FRM_KAT_AYR frm_ayr = new FRM_KAT_AYR();
            bunifuTransition1.ShowSync(frm_ayr);
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database3;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "KAT FROM TBKAT WHERE ID=@ID";
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                frm_ayr.TXT_KAT.Text = List[0];
                con.Close();

                // Read image from database
                //con.Open();
                //cmd.CommandText = "SELECT RESIM FROM TBTELEFON WHERE ID=@IDRESIM";
                //cmd.Parameters.AddWithValue("@IDRESIM", dataGridView1.CurrentRow.Cells[0].Value);
                //byte[] img = (byte[])cmd.ExecuteScalar();
                //MemoryStream ms = new MemoryStream();
                //ms.Write(img, 0, img.Length);
                //frm_ayr.resim.Image = Image.FromStream(ms);

                


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
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Database3;Integrated Security=True");
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "DELETE FROM TBKAT WHERE ID=@ID";
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

