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

namespace PublicarTrabajo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3R14INI;Initial Catalog=BDTrabajos;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string correo = txtCorreo.Text;
            string pais = txtPais.Text;
            string region = txtRegion.Text;
            string ciudad = txtCiudad.Text;
            string oficio = txtOficio.Text;
            string descripcion = txtDescripcion.Text;
            SqlCommand comando = new SqlCommand("   ", conexion);

            comando.ExecuteNonQuery();
            MessageBox.Show("Se agrego publicacion");

            txtCiudad.Text = "";
            txtCorreo.Text = "";
            txtDescripcion.Text = "";
            txtOficio.Text = "";
            txtPais.Text = "";
            txtRegion.Text = "";

            conexion.Close();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
