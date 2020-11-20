using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp4
{
    public partial class Prestamo : Form
    {
        public Prestamo()
        {
            InitializeComponent();
        }

        string password;

        private void button3_Click(object sender, EventArgs e)
        {
            Menu CambioMenu = new Menu();
            CambioMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigoUsuario.Clear();
            textBox5.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }
        struct Datos_Prestamo
        {
            public String cu;
            public String cl;
            public String nl;
            public String nc;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Datos_Prestamo pres = new Datos_Prestamo();
            if (txtCodigoUsuario.Text == "")
            {
                MessageBox.Show("Debe introducir su código de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoUsuario.Focus();
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Debe introducir el código del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe introducir el nombre del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe introducir el número de copia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            pres.cu = Convert.ToString(txtCodigoUsuario.Text);
            pres.cl = Convert.ToString(textBox5.Text);
            pres. nl = Convert.ToString(textBox2.Text);
            pres.nc = Convert.ToString(comboBox1.Text);

            string codigoLibro = textBox2.Text;
       
            string url = codigoLibro + ".txt"; //usted elige ubicación de carpeta, laque hizo en el paso 3, pero esta debe existir
            if (File.Exists(url)) //verifica que el archive exista
            {
                StreamWriter escribir = new StreamWriter("Prestamos.txt", true);
                try
                {
                    escribir.WriteLine();
                    escribir.WriteLine("Codigo Del Usuario: " + pres.cu);
                    escribir.WriteLine("codigo de libro: " + pres.cl);
                    escribir.WriteLine("Nombre del libro: " + pres.nl);
                    escribir.WriteLine("codigo de copia: " + pres.nc);
                    escribir.WriteLine("Fecha de prestamo " + dateTimePicker1.Text);
                    escribir.WriteLine("Fecha de devolucion: " + dateTimePicker2.Text);
                    escribir.Close();

                    MessageBox.Show("El registro de realizao correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error");
                }
                escribir.Close();
            }
            else
            {
                MessageBox.Show("El Libro no se encuentra en la base de datos o no esta disponible");

              

            }


            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Ingresa los datos");
            toolTip1.SetToolTip(button2, "elimina datos");
        }
    }
}
