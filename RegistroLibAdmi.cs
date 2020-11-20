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
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp4
{
    public partial class RegistroLibAdmi : Form
    {
        public RegistroLibAdmi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("El libro fue eliminado con éxito", "Eliminar libro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        struct Registro_Libro
        {
            public String tl;
            public String nc;
            public String cl;
            public String s;
            public String e;
            public String ne;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Menu CambioMenu = new Menu();
            CambioMenu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro_Libro reg = new Registro_Libro();
            if (txtTitulo.Text == "")
            {
                MessageBox.Show("Debe introducir el Titutlo del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo.Focus();
            }
            else if (NdeCopia.Text == "")
            {
                MessageBox.Show("Debe introducir el numero del copia del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NdeCopia.Focus();
            }
            else if (txtCodLib.Text == "")
            {
                MessageBox.Show("Debe introducir el código del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodLib.Focus();
            }
            else if (Sector.Text == "")
            {
                MessageBox.Show("Debe introducir el sector donde se encuentra el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Sector.Focus();
            }
            else if (Estante.Text == "")
            {
                MessageBox.Show("Debe introducir el estante donde se encuentra el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Estante.Focus();
            }
            else if (NivEstante.Text == "")
            {
                MessageBox.Show("Debe introducir el nivel de estante del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NivEstante.Focus();
            }
            else
            {

                string codigoLibro = txtTitulo.Text;
                string CantidadDisponible = NdeCopia.Text;
                string url = codigoLibro + ".txt"; //usted elige ubicación de carpeta, laque hizo en el paso 3, pero esta debe existir
                if (File.Exists(url)) //verifica que el archive exista
                {
                    MessageBox.Show("ERROR. ¡EL  Codigo del Libro ya existe!"); //usuario registrado
                }
                else
                {
                    File.WriteAllText(url, CantidadDisponible); /*Crea un Nuevo archivo con ese nombre y guardadentro del archivo el valor del segundo parámetro*/
                    reg.tl = Convert.ToString(txtTitulo.Text);
                    reg.nc = Convert.ToString(NdeCopia.Text);
                    reg.cl = Convert.ToString(txtCodLib.Text);
                    reg.s = Convert.ToString(Sector.Text);
                    reg.e = Convert.ToString(Estante.Text);
                    reg.ne = Convert.ToString(NivEstante.Text);
                    StreamWriter escribir = new StreamWriter("Libros.txt", true);
                    try
                    {
                        escribir.WriteLine();
                        escribir.WriteLine("titulo del libro: " + reg.tl);
                        escribir.WriteLine("Nª de Copia: " + reg.nc);
                        escribir.WriteLine("codigo de Libro: " + reg.cl);
                        escribir.WriteLine("Sector:" + reg.s);
                        escribir.WriteLine("Estante: " + reg.e);
                        escribir.WriteLine("Nivel De estante : " + reg.ne);
                        escribir.Close();
                        MessageBox.Show("El libro fue registrado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }

                    escribir.Close();

                    StreamWriter escribir2 = new StreamWriter(codigoLibro + ".txt", true);
                    try
                    {
                        escribir2.WriteLine();
                        escribir2.WriteLine(CantidadDisponible);
                        escribir2.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    escribir2.Close();
                }




                

            }
        }
        public void Mostrar()
        {
            try
            {
                listBox1.Items.Clear();
                StreamReader leer = new StreamReader("Libros.txt");
                string linea;
                try
                {
                    linea = leer.ReadLine();
                    while (linea != null)
                    {
                        listBox1.Items.Add(linea);
                        linea = leer.ReadLine();
                    }
                    leer.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("No Hay Ningun dato ingresado");
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtCodLib.Clear();
            NdeCopia.Text = "";
            Sector.Text = "";
            Estante.Text = "";
            NivEstante.Text = "";
        }

        private void RegistroLibAdmi_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MenuAdmi CambioMenu = new MenuAdmi();
            CambioMenu.Show();
            this.Hide();
        }
    }
}
