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
    public partial class FRM_MUSTERI_EKLE : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public int state;

        public FRM_MUSTERI_EKLE()
        {
            InitializeComponent();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_adi.Text == "" || txt_num.Text == "" || txt_dateEdit1.Text == "" || txt_ema.Text == "" || txt_tck.Text == "" || txt_kul.Text == "" || txt_sif.Text == "")
            {
                MessageBox.Show("Eksik bilgileri tamamlayın");
            }
            else
            {
                if (state == 0)
                {
                    

                    //sql
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO TBMUSTERI (ADISOYADI,NUMARA,KULADI,DOGUM,SIFRE,EMAIL,KIMLIK) VALUES (@ADISOYADI,@NUMARA,@KULADI,@SIFRE,@DOGUM,@EMAIL,@KIMLIK)";
                    cmd.Parameters.AddWithValue("@ADISOYADI", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@NUMARA", txt_num.Text);
                    cmd.Parameters.AddWithValue("@KULADI", txt_kul.Text);
                    cmd.Parameters.AddWithValue("@DOGUM", txt_dateEdit1.Text);
                    cmd.Parameters.AddWithValue("@SIFRE", txt_sif.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_ema.Text);
                    cmd.Parameters.AddWithValue("@KIMLIK", txt_tck.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_add = new FRM_EKLENDI();
                    frm_add.Show();
                    this.Close();
                }
                else
                {
                    //Değişterme
                    /*MemoryStream ms = new MemoryStream();
                    resim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _resim = ms.ToArray();
                    */

                    //sql
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE TBMUSTERI SET ADISOYADI=@ADISOYADI,NUMARA=@NUMARA,KULADI=@KULADI," +
                        "DOGUM=@DOGUM,SIFRE=@SIFRE,EMAIL=@EMAIL,KIMLIK=@KIMLIK";
                    cmd.Parameters.AddWithValue("@ADISOYADI", txt_adi.Text);
                    cmd.Parameters.AddWithValue("@NUMARA", txt_num.Text);
                    cmd.Parameters.AddWithValue("@KULADI", txt_kul.Text);
                    cmd.Parameters.AddWithValue("@DOGUM", txt_dateEdit1.Text);
                    cmd.Parameters.AddWithValue("@SIFRE", txt_sif.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_ema.Text);
                    cmd.Parameters.AddWithValue("@KIMLIK", txt_tck.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_degistir = new FRM_DEGISTIRDI();
                    frm_degistir.Show();
                    this.Close();
                }

            }
        }
    }
}
