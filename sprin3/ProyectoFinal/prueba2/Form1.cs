using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bd.SelectDataTable("select * from datos");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string consultar = bd.selectstring("select * from datos where id ='" + txtID.Text + "'");
            string agregar = "insert into datos values (" + txtID.Text + ",'" + txtNombre.Text + "')";
               

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Error");
            }
            else
            {
                if (consultar == txtID.Text)
                {
                    MessageBox.Show("Esta DNI ya existe");
                }
                else
                {
                    if (bd.executecommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente");
                        dataGridView1.DataSource = bd.SelectDataTable("select * from datos");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar");
                    }
                }
            }
        }
    }
}
