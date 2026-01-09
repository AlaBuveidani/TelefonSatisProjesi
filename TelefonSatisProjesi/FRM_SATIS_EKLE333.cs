using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
using DevExpress.XtraLayout.Resizing;


namespace TelefonSatisProjesi
{
    public partial class FRM_SATIS_EKLE333 : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<String>();
        public int state;
        
        public FRM_SATIS_EKLE333()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_kat = new FRM_KAT_EKLE();
            bunifuTransition1.ShowSync(frm_kat);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_marka = new FRM_MARKA();
            bunifuTransition2.ShowSync(frm_marka);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_model = new FRM_MODEL();
            bunifuTransition3.ShowSync(frm_model);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_ram = new FRM_RAM();
            bunifuTransition4.ShowSync(frm_ram);
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm_bellek = new FRM_BELLEK();
            bunifuTransition4.ShowSync(frm_bellek);
        }
        private void FRM_ADD_Load(object sender, EventArgs e)
        {
            
            //{
            //    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
            //    cmd.Connection = con;
            //    con.Open();
            //    cmd.CommandText = "SELECT KAT FROM TBKAT";
            //    var rd = cmd.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        List.Add(Convert.ToString(rd[0]));
            //    }
            //    int i = 0;
            //    while (i < List.LongCount())
            //    {
            //        comboBox1.Items.Add(List[i]);
            //        i++;
            //    }
            //}
            //catch (Exception EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT KAT FROM TBKAT";
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                int i = 0;
                while (i < List.LongCount())
                {
                    comboBox1.Items.Add(List[i]);
                    i++;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }*/
        }

        private void FRM_TEL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database3DataSet12.TBTELEFON' table. You can move, or remove it, as needed.
            this.tBTELEFONTableAdapter1.Fill(this.database3DataSet12.TBTELEFON);
            // TODO: This line of code loads data into the 'database3DataSet111.TBBELLEK' table. You can move, or remove it, as needed.
            this.tBBELLEKTableAdapter1.Fill(this.database3DataSet111.TBBELLEK);
            // TODO: This line of code loads data into the 'database3DataSet10.TBRAM' table. You can move, or remove it, as needed.
            this.tBRAMTableAdapter1.Fill(this.database3DataSet10.TBRAM);
            // TODO: This line of code loads data into the 'database3DataSet9.TBMODEL' table. You can move, or remove it, as needed.
            this.tBMODELTableAdapter1.Fill(this.database3DataSet9.TBMODEL);
            // TODO: This line of code loads data into the 'database3DataSet8.TBMARKA' table. You can move, or remove it, as needed.
            this.tBMARKATableAdapter1.Fill(this.database3DataSet8.TBMARKA);
            // TODO: This line of code loads data into the 'database3DataSet7.TBKAT' table. You can move, or remove it, as needed.
            this.tBKATTableAdapter2.Fill(this.database3DataSet7.TBKAT);
            // TODO: This line of code loads data into the 'database3DataSet6.TBBELLEK' table. You can move, or remove it, as needed.
            this.tBBELLEKTableAdapter.Fill(this.database3DataSet6.TBBELLEK);
            // TODO: This line of code loads data into the 'database3DataSet5.TBKAT' table. You can move, or remove it, as needed.
            this.tBKATTableAdapter1.Fill(this.database3DataSet5.TBKAT);
            // TODO: This line of code loads data into the 'database3DataSet4.TBTELEFON' table. You can move, or remove it, as needed.
            this.tBTELEFONTableAdapter.Fill(this.database3DataSet4.TBTELEFON);
            // TODO: This line of code loads data into the 'database3DataSet3.TBRAM' table. You can move, or remove it, as needed.
            this.tBRAMTableAdapter.Fill(this.database3DataSet3.TBRAM);
            // TODO: This line of code loads data into the 'database3DataSet2.TBMODEL' table. You can move, or remove it, as needed.
            this.tBMODELTableAdapter.Fill(this.database3DataSet2.TBMODEL);
            // TODO: This line of code loads data into the 'database3DataSet11.TBMARKA' table. You can move, or remove it, as needed.
            this.tBMARKATableAdapter.Fill(this.database3DataSet11.TBMARKA);
            // TODO: This line of code loads data into the 'database3DataSet1.TBKAT' table. You can move, or remove it, as needed.
            this.tBKATTableAdapter.Fill(this.database3DataSet1.TBKAT);
            // TODO: This line of code loads data into the 'database3DataSet.TBKAT' table. You can move, or remove it, as needed.
            this.tBKATTableAdapter.Fill(this.database3DataSet.TBKAT);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tBKATTableAdapter.FillBy(this.database3DataSet.TBKAT);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtbox_bel.Text == "" || txt_fiy.Text == "" || txt_gar.Text == "" || txt_isl.Text == "" || txtbox_kat.Text == "" || txtbox_mar.Text == "" || txtbox_mod.Text == "" || txtbox_ram.Text == "" || txt_ren.Text == "" || txt_sto.Text == "")
            {
                MessageBox.Show("Eksik bilgileri tamamlayın");
                //con.Close();
            }
            else
            {
                if(state == 0)
                {
                    //Ekleme
                    //resim to pinary
                    MemoryStream ms = new MemoryStream();
                    resim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _resim = ms.ToArray();


                    //sql
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO TBTELEFON (BELLEK,ISLEMCI,PRICE,GARANTI,STOK,RENK,RESIM,KAT,MARKA,MODEL) VALUES (@BELLEK,@ISLEMCI,@PRICE,@GARANTI,@STOK,@RENK,@RESIM,@KAT,@MARKA,@MODEL)";
                    cmd.Parameters.AddWithValue("@BELLEK", txtbox_bel.Text);
                    cmd.Parameters.AddWithValue("@ISLEMCI", txt_isl.Text);
                    cmd.Parameters.AddWithValue("@PRICE", txt_fiy.Text);
                    cmd.Parameters.AddWithValue("@GARANTI", txt_gar.Text);
                    cmd.Parameters.AddWithValue("@STOK", txt_sto.Text);
                    cmd.Parameters.AddWithValue("@RENK", txt_ren.Text);
                    cmd.Parameters.AddWithValue("@RESIM", _resim);
                    cmd.Parameters.AddWithValue("@KAT", txtbox_kat.Text);
                    cmd.Parameters.AddWithValue("@MARKA", txtbox_mar.Text);
                    cmd.Parameters.AddWithValue("@MODEL", txtbox_mod.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_add = new FRM_EKLENDI();
                    frm_add.Show();
                    this.Close();
                }
                else
                {
                    //Değişterme
                    MemoryStream ms = new MemoryStream();
                    resim.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _resim = ms.ToArray();


                    //sql
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE TBTELEFON SET BELLEK=@BELLEK,ISLEMCI=@ISLEMCI,PRICE=@PRICE,GARANTI=@GARANTI,STOK=@STOK,RENK=@RENK,RESIM=@RESIM,KAT=@KAT,MARKA=@MARKA,MODEL=@MODEL";
                    cmd.Parameters.AddWithValue("@BELLEK", txtbox_bel.Text);
                    cmd.Parameters.AddWithValue("@ISLEMCI", txt_isl.Text);
                    cmd.Parameters.AddWithValue("@PRICE", txt_fiy.Text);
                    cmd.Parameters.AddWithValue("@GARANTI", txt_gar.Text);
                    cmd.Parameters.AddWithValue("@STOK", txt_sto.Text);
                    cmd.Parameters.AddWithValue("@RENK", txt_ren.Text);
                    cmd.Parameters.AddWithValue("@RESIM", _resim);
                    cmd.Parameters.AddWithValue("@KAT", txtbox_kat.Text);
                    cmd.Parameters.AddWithValue("@MARKA", txtbox_mar.Text);
                    cmd.Parameters.AddWithValue("@MODEL", txtbox_mod.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_degistir = new FRM_DEGISTIRDI();
                    frm_degistir.Show();
                    this.Close();
                }
            }
            
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if(result == DialogResult.OK)
            {
                resim.Image = Image.FromFile(dia.FileName); 
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
