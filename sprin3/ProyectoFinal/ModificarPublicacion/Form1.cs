
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

namespace ModificarPublicacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-3R14INI;Initial Catalog=BDTrabajos;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            conexion.Open();

            //falta validad el codigo(automatico)

            string ID = textBox6.Text;
            string pais = textBox1.Text;
            string region = textBox2.Text;
            string ciudad = textBox3.Text;
            string oficio = textBox4.Text;
            string descripcion = textBox5.Text;
            SqlCommand comando = new SqlCommand("modificarTrabajo", conexion);//+ codigo;
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@pais", pais);
            comando.Parameters.AddWithValue("@region", region);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@oficio", oficio);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@IDtrabajo", ID);


            comando.ExecuteNonQuery();
          
                MessageBox.Show("Se modificaron los datos de la publicacion");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            //}
            //else
            //    MessageBox.Show("No existe esta publicacion con el código ingresado");
            conexion.Close();
            btnGuardar.Enabled = false;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
