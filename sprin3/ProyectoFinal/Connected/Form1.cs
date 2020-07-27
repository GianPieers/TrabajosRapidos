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
namespace Connected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=prueba;Integrated Security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if(con.State==System.Data.ConnectionState.Open)
            {
                string q = "insert into datos(id,nombre) values('" + txtid.Text.ToString() 
                    + "','" + txtname.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Conexion establecida");
            }


        }
    }
}
