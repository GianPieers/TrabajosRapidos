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
using System.Drawing.Imaging;

namespace Loggin
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            this.txtContra.PasswordChar = '*';
            MessageBox.Show("La contrasena debe contener como maximo 8 cararteres");
            this.txtContra.MaxLength = 8;
           
           

        }
        public string conString = "Data Source=localhost\\MSSQLSERVER01;Initial Catalog=prueba;Integrated Security=True";

        private void btnIngresar_Click(object sender, EventArgs e)

        {
            int contador = 0;


            //if(txtUsuario.Text.Trim()=="Admin" && txtContra.Text.Trim()=="Admin" )
            //{
            //    MessageBox.Show("Bienvendido al sistema");

            //}
            //else
            //{
            //    if (contador > 2)
            //    {
            //        MessageBox.Show("Los intentos maximos son 3");
            //    }
            //    else
            //    {
            //        MessageBox.Show("El nombre  de usuario o contraseña son incorrectos");
            //        txtUsuario.Text = "";
            //        txtContra.Text = "";
            //        contador += 1;
            //        MessageBox.Show("Intenro:" + contador);


            //    }


            //}
            

            SqlConnection con = new SqlConnection(conString);

            string query = "Select *from tbl_login where username = '" + txtUsuario.Text.Trim() + "' and password='" + txtContra.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Notificacion objFrmMain = new Notificacion();
                this.Hide();
                objFrmMain.Show();

            }
            else
            {

                txtUsuario.Text = "";
                txtContra.Text = "";
                MessageBox.Show("Verifica el username y el password");


            }

            //if (this.txtUsuario.Text == "oscar" && this.txtContra.Text == "123")
            //{
            //    Notificacion llamar = new Notificacion();
            //    llamar.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Intento "+ i);
            //    this.txtUsuario.Text = " ";
            //    this.txtContra.Text = " ";

            //}





            //if (this.txtUsuario.Text=="oscar" &&  this.txtContra.Text=="123")
            //{
            //    Notificacion llamar = new Notificacion();
            //    llamar.Show();

            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
