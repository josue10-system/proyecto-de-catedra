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
    public partial class Devolucion : Form
    {
        public Devolucion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu CambioMenu = new Menu();
            CambioMenu.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        struct Datos_Devolucion
        {
            public String cu;
            public String cl;
            public String nc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Datos_Devolucion dev = new Datos_Devolucion();
            if (textBox1.Text == "")
            {
                MessageBox.Show("Debe introducir su código de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Debe introducir el código del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox6.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Debe introducir el número de copia del libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            double dp, de, m, mt=0;
            dp = Convert.ToDouble(dateTimePicker1.Value.Day);
            de = Convert.ToDouble(dateTimePicker3.Value.Day);
            m = de - dp;
            if (m > 3)
            {

                mt = (m - 3) * 0.35;
                m = m - 3;
                MessageBox.Show("Su mora es de $" + mt + " se pasó " + m + " días del tiempo estimado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Realizó su devolución a tiempo, no debe cancelar mora", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            dev.cu = Convert.ToString(textBox1.Text);
            dev.cl = Convert.ToString(textBox6.Text);
            dev.nc = Convert.ToString(comboBox1.Text);

            StreamWriter escribir = new StreamWriter("DevolucionesLibros.txt", true);
            try
            {
                escribir.WriteLine();
                escribir.WriteLine("Codigo Del Usuario: " + dev.cu);
                escribir.WriteLine("codigo de libro: " + dev.cl);
                escribir.WriteLine("codigo de copia: " +dev.nc);
                escribir.WriteLine("Fecha de prestamo " + dateTimePicker1.Text);
                escribir.WriteLine("Fecha de entrega: " + dateTimePicker2.Text);
                escribir.WriteLine("Fecha de devolcion: " + dateTimePicker3.Text);
                escribir.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            escribir.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox6.Clear();
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            dateTimePicker3.Text = "";
        }
    }
}
