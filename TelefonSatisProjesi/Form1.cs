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
    public partial class Form1 : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ala\Desktop\CsharpTutorials\TelefonSatisProjesi\TelefonSatisProjesi\Database3.mdf;Integrated Security=True");
        //SqlDataAdapter da;
        //DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

            //da = new SqlDataAdapter("SELECT id,BELLEK FROM TBBELLEK", con);
           // da.Fill(dt);
            //combo_kat.DataSource = dt;
            //combo_kat.DisplayMember = "BELLEK";
            //combo_kat.ValueMember = "id";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database3DataSet13.TBKAT' table. You can move, or remove it, as needed.
            this.tBKATTableAdapter.Fill(this.database3DataSet13.TBKAT);

        }
    }
}
