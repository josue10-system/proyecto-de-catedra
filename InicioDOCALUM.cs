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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string password;

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = TexBox1.Text; //capturamos los valores de usuario y contraseña
            string contra = textBox2.Text;
            string url = usuario + ".txt";
            if (File.Exists(url)) //verifica si existe
            {
                password = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
                if (contra.Equals(password)) //verifica si contraseña es igual al archivo
                {
                    Menu CambioMenu = new Menu();
                    CambioMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(textBox2, "Contraseña Incorrecta");//login fallido
                }
            }
            else
            {
                MessageBox.Show(TexBox1, "Usuario Incorrecto"); //usuario incorrecto
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegUsu CambioRegistrarse = new RegUsu();
            CambioRegistrarse.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
