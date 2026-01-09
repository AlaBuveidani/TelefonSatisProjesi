using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonSatisProjesi
{
    public partial class FRM_CALISAN : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<String>();
        public int state;

        public FRM_CALISAN()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_isim.Text == "" || txt_soy.Text == "" || txt_num.Text == "" || txt_dateEdit1.Text == "" || txt_tc.Text == "" || txt_ema.Text == "" || txt_kul.Text == "" || txt_sif.Text == "" )
            {
                MessageBox.Show("Eksik bilgileri tamamlayın");
            }
            else
            {
                if (state == 0)
                {
                    /*//Ekleme
                    //resim to pinary
                    MemoryStream ms = new MemoryStream();
                    resim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _resim = ms.ToArray();
                    */

                    //sql
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO TBMUSTERI (MUSADI,SOYADI,NUMARA,DOGUM,KIMLIK,EMAIL,KULADI,SIFRE) VALUES (@MUSADI,@SOYADI,@NUMARA,@DOGUM,@KIMLIK,@EMAIL,@KULADI,@SIFRE)";
                    cmd.Parameters.AddWithValue("@MUSADI", txt_isim.Text);
                    cmd.Parameters.AddWithValue("@SOYADI", txt_soy.Text);
                    cmd.Parameters.AddWithValue("@NUMARA", txt_num.Text);
                    cmd.Parameters.AddWithValue("@DOGUM", txt_dateEdit1.Text);
                    cmd.Parameters.AddWithValue("@KIMLIK", txt_tc.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", txt_ema.Text);
                    cmd.Parameters.AddWithValue("@KULADI", txt_kul.Text);
                    cmd.Parameters.AddWithValue("@SIFRE", txt_sif.Text);
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
                    cmd.CommandText = "UPDATE TBMUSTERI SET MUSADI=@MUSADI,SOYADI=@SOYADI,NUMARA=@NUMARA,DOGUM=@DOGUM,KIMLIK=@KIMLIK,EMAIL=@EMAIL,KULADI=@KULADI,SIFRE=@SIFRE,MARKA=@MARKA,MODEL=@MODEL";
                    cmd.Parameters.AddWithValue("@MUSADI", txt_isim.Text);
                    cmd.Parameters.AddWithValue("@SOYADI", txt_soy.Text);
                    cmd.Parameters.AddWithValue("@NUMARA", txt_num.Text);
                    cmd.Parameters.AddWithValue("@DOGUM", txt_dateEdit1.Text);
                    cmd.Parameters.AddWithValue("@KIMLIK", txt_tc.Text);
                    cmd.Parameters.AddWithValue("@KULADI", txt_kul.Text);
                    cmd.Parameters.AddWithValue("@SIFRE", txt_sif.Text);
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
