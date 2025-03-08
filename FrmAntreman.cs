using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace GYM
{
    public partial class FrmAntreman : Form
    {
        public FrmAntreman()
        {
            InitializeComponent();
        }


        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-H6SIL9M\\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True;");


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            bgl.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Degerler (Set_Sayisi, Agirlik, Hareket) values (@p1,@p2,@p3)",bgl);

            komut.Parameters.AddWithValue("@p1",cmbHareket.Text);


        }
    }
}
