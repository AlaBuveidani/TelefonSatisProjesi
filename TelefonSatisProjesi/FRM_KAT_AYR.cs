using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using TelefonSatisProjesi.Classlar;

namespace TelefonSatisProjesi
{
    public partial class FRM_KAT_AYR : Form
    {
        //Database3Entities db = new Database3Entities();
        //TBKAT tbkat = new TBKAT();
        //Methods methods = new Methods();
        //TST tst2 = new TST();
        //Dialog dialog = new Dialog();

        public int id;

        // var for sqlcon
        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd = new SqlCommand();
        public int state;

        public FRM_KAT_AYR()
        {
            InitializeComponent();
        }

        //add or edit

        private void button1_Click(object sender, EventArgs e)
        {


            /*if (TXT_KAT.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TBKAT (KAT) VALUES (@KAT)";
                cmd.Parameters.AddWithValue("@KAT", TXT_KAT.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form frm_add = new FRM_EKLENDI();
                frm_add.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Önce kategori ismi yazın");
                con.Close();
            }

            // Check if add or edit
            /*if (TXT_KAT.Text == "")
            {
                dialog.Width = this.Width;
                dialog.txt_dialog.Text = "Önce kategori ismi yazın";
                dialog.Show();
            }
            else
            {
                // check if add or edit
                if (id == 0)
                {
                    // Add
                    tbkat.KAT = TXT_KAT.Text;
                    db.TBKAT.Add(tbkat);
                    db.SaveChanges();
                    tst2.txt_tst.Text = "Yeni Kategori Eklendi";
                    //tst2.ShowDialog();

                }
                else
                {
                    // Edit
                }
            }*/

        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
