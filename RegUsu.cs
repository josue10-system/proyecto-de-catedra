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
    public partial class RegUsu : Form
    {
        public RegUsu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAp.Text == "")
            {
                MessageBox.Show("Debe introducir sus apellidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAp.Focus();
            }
            else if (txtNo.Text == "")
            {
                MessageBox.Show("Debe introducir sus nombres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNo.Focus();
            }
            else if (txtDir.Text == "")
            {
                MessageBox.Show("Debe introducir su dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDir.Focus();
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Debe introducir su número de teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTel.Focus();
            }
            else if (txtCo.Text == "")
            {
                MessageBox.Show("Debe introducir su correo eléctronico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCo.Focus();
            }
            else if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe introducir su código de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            else if (txtContra.Text == "")
            {
                MessageBox.Show("Debe introducir su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContra.Focus();
            }
            else
            {
                string usuario = txtCodigo.Text;
                string contra = txtContra.Text;
                string url = usuario + ".txt"; //usted elige ubicación de carpeta, laque hizo en el paso 3, pero esta debe existir
                if (File.Exists(url)) //verifica que el archive exista
                {
                    MessageBox.Show("ERROR. ¡Usuario ya existe!"); //usuario registrado
                }
                else
                {
                    File.WriteAllText(url, contra); /*Crea un Nuevo archivo con ese nombre y guardadentro del archivo el valor del segundo parámetro*/
                    MessageBox.Show("El usuario fue registrado con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    StreamWriter escribir = new StreamWriter("RegistroUsuario.txt", true);
                    try
                    {
                        escribir.WriteLine();
                        escribir.WriteLine("Apellido del Usuario: " + txtAp.Text);
                        escribir.WriteLine("Nombre del Usuario: " + txtNo.Text);
                        escribir.WriteLine("Dirección del Usuario: " + txtDir.Text);
                        escribir.WriteLine("Numero del Usuario: " + txtTel.Text);
                        escribir.WriteLine("Correo del Usuario: " + txtCo.Text);
                        escribir.WriteLine("Codigo del Usuario: " + txtCodigo.Text);
                        escribir.WriteLine("Contraseña del Usuario: " + txtContra.Text);
                        escribir.Close();
                        Form3 CambioMenu = new Form3();
                        CambioMenu.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                    escribir.Close();
                }
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
