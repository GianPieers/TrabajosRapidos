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

namespace QuitarTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3R14INI;Initial Catalog=BDTrabajos;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            conexion.Open();

            //falta validad el codigo(automatico)
            
            string salario = textBox1.Text;
            SqlCommand comando = new SqlCommand("SELECT * FROM oficioP WHERE salarioEsp like('" + salario+ "%') ORDER BY IDoficio DESC", conexion);
           
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            dataGridView1.DataSource = dt; 
            conexion.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // rango 0-30
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM oficioP WHERE salarioEsp >= 0 and salarioEsp<=30 ORDER BY IDoficio DESC", conexion);

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //rango 30-60
            conexion.Open();
            SqlCommand comando = new SqlCommand(" SELECT * FROM oficioP WHERE salarioEsp > 30 and salarioEsp<=60 ORDER BY IDoficio DESC", conexion);

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //RANGO MAS DE  60
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM oficioP WHERE salarioEsp >60 ORDER BY IDoficio DESC", conexion);

            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(comando);

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }
    }
}
