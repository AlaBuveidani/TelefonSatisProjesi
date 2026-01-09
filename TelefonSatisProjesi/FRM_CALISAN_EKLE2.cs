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

namespace TelefonSatisProjesi
{
    public partial class FRM_CALISAN_EKLE2 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<String>();
        public int state;

        public FRM_CALISAN_EKLE2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (txt_adi.Text == "" || txt_num.Text == "" || txt_dateEdit1.Text == "" || txt_tck.Text == "" || txt_ema.Text == "" ||
                txt_kul.Text == "" || txt_sif.Text == "")
            {
                MessageBox.Show("Eksik bilgileri tamamlayın");
                con.Close();
            }
            else
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TBSALISAN (ADISOYADI,NUMARA,KULADI,SIFRE,KIMLIK,DOGUM,EMAIL) VALUES (@ADISOYADI,@NUMARA,@KULADI,@SIFRE,@KIMLIK,@DOGUM,@EMAIL)";
                cmd.Parameters.AddWithValue("@ADISOYADI", txt_adi.Text);
                cmd.Parameters.AddWithValue("@NUMARA", txt_num.Text);
                cmd.Parameters.AddWithValue("@KULADI", txt_kul.Text);
                cmd.Parameters.AddWithValue("@SIFRE", txt_sif.Text);
                cmd.Parameters.AddWithValue("@KIMLIK", txt_tck.Text);
                cmd.Parameters.AddWithValue("@DOGUM", txt_dateEdit1.Text);
                cmd.Parameters.AddWithValue("@EMAIL", txt_ema.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form frm_add = new FRM_EKLENDI();
                frm_add.Show();
                this.Close();
                
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
/*if (state == 0)
                {
                    
                }

                else
                {
                    //sql
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE TBSALISAN SET ADISOYADI=@ADISOYADI,NUMARA=@NUMARA,KULADI=@KULADI,SIFRE=@SIFRE,KIMLIK=@KIMLIK,DOGUM=@RESIM,EMAIL=@EMAIL";
                    cmd.Parameters.AddWithValue("@ADISOYADI", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@NUMARA", txt_num.Text);
                    cmd.Parameters.AddWithValue("@KULADI", txt_kul.Text);
                    cmd.Parameters.AddWithValue("@SIFRE", txt_sif.Text);
                    cmd.Parameters.AddWithValue("@KIMLIK", txt_tck.Text);
                    cmd.Parameters.AddWithValue("@DOGUM", txt_dateEdit1.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_ema.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_degistir = new FRM_DEGISTIRDI();
                    frm_degistir.Show();
                    this.Close();
                }*/