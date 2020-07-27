using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarCorreo
{
    public partial class Form1 : Form
    {
        Correo c = new Correo();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            c.enviarCorreo(txtEmisor.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, txtReceptor.Text, txtRutaArchivo.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    txtRutaArchivo.Text = this.openFileDialog1.FileName;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: " + ex.ToString());
            }

        }

        private void txtEmisor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
