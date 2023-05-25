using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto0._4
{
    public partial class ganar : Form
    {

        public ganar()
        {
            InitializeComponent();

            string filePath = @"C:\Users\juan\Downloads\TAREAS\puntos.txt";
            using (StreamReader sr = new StreamReader(filePath))
            {
                string contenido = sr.ReadToEnd();


                label3.Text = contenido;
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

            Form juego = new Nivel1();
            juego.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form menu = new Form1();
            menu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
