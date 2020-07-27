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


namespace RegistrarUsuario
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
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "insert into tblRegistroUsuario(DNI,Nombre,reApPaterno,reApMaterno,reCorreo,username,userpassword) values('" + txtDNI.Text.ToString()
                    + "','" + txtNombre.Text.ToString() + "','" + txtApPaterno.Text.ToString() + "','" +
                    txtApMaterno.Text.ToString() + "','" + txtCorreo.Text.ToString() + "','"
                    + txtUsername.Text.ToString() + "','" + txtContra.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado");
            }

            //string consultar = bd.selectstring("select * from datos1 where id ='" + txtDNI.Text + "'");
            //string agregar = "insert into datos1 values ('" + txtDNI.Text + "','" + txtNombre.Text + "','"
            //    + txtApPaterno.Text + "','" + txtApMaterno.Text + "','" + txtCorreo.Text + "','" + txtUsername.Text + "')";


            //if (string.IsNullOrWhiteSpace(txtDNI.Text))
            //{
            //    MessageBox.Show("Error");
            //}
            //else
            //{
            //    if (consultar == txtDNI.Text)
            //    {
            //        MessageBox.Show("Esta DNI ya existe");
            //    }
            //    else
            //    {
            //        if (bd.executecommand(agregar))
            //        {
            //            MessageBox.Show("Registro agregado correctamente");
            //            dataGridView1.DataSource = bd.SelectDataTable("select * from datos1");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Error al agregar");
            //        }
            //    }
            //}

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
