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
    public partial class txtAdmiBase : Form
    {
        public txtAdmiBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void txtUsuario_Load(object sender, EventArgs e)
        {
            Mostrar("RegistroUsuario.txt", UsuariosList);
            Mostrar("DevolucionesLibros.txt", DevolucionesList);
            Mostrar("Prestamos.txt", Registrolist);
           
        }
        public void Mostrar(string NombreArchivo, ListBox Listado)
        {
            try
            {
                Listado.Items.Clear();
                StreamReader leer = new StreamReader(NombreArchivo);
                string linea;
                try
                {
                    linea = leer.ReadLine();
                    while (linea != null)
                    {
                        Listado.Items.Add(linea);
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
            MenuAdmi CambioMenu = new MenuAdmi();
            CambioMenu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu CambioMenu = new Menu();
            CambioMenu.Show();
            this.Hide();
        }
    }
}
