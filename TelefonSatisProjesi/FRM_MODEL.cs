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
    public partial class FRM_MODEL : Form
    {
        // var for sqlcon
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public FRM_MODEL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXT_MODEL.Text != "")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TBMODEL (MODEL) VALUES (@MODEL)";
                cmd.Parameters.AddWithValue("@MODEL", TXT_MODEL.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form frm_add = new FRM_EKLENDI();
                frm_add.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Önce model yazın");
                con.Close();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
