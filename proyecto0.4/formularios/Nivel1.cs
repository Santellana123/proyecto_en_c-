using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto0._4.Clases;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto0._4
{
    public partial class Nivel1 : Form
    {
        private colisiones colisionDetector;
        private Rectangle[] rectangulos;
        private bool colisionando = false;
        private personaje Personaje;
        private victoria Victoria;
        private perder Perder;
        private PictureBox[] puntos;
        private int puntuacion = 0;
        private PersonajeEspecial personajeEspecial;
        private perder f2;
        public Nivel1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            colisionDetector = new colisiones();
            rectangulos = new Rectangle[] { Jugador.Bounds, obstaculo.Bounds, obstaculo2.Bounds, obstaculo3.Bounds, obstaculo4.Bounds, obstaculo5.Bounds, obstaculo6.Bounds, obstaculo7.Bounds, obstaculo8.Bounds, obstaculo9.Bounds, obstaculo10.Bounds, obstaculo11.Bounds, obstaculo12.Bounds, obstaculo13.Bounds, obstaculo14.Bounds, obstaculo15.Bounds, obstaculo16.Bounds, obstaculo17.Bounds, obstaculo18.Bounds, obstaculo19.Bounds, PBganar.Bounds };
            Personaje = new personaje(Jugador);
            Victoria = new victoria();
            Perder = new perder();
            puntos = new PictureBox[] { punto1, punto2,punto3,punto4 };
            personajeEspecial = new PersonajeEspecial(Jugador, disminuir);
        }
        private void Nivel1_KeyDown(object sender, KeyEventArgs e)
        {
            rectangulos[0] = Jugador.Bounds;
            rectangulos[1] = obstaculo.Bounds;
            rectangulos[2] = obstaculo2.Bounds;
            rectangulos[3] = obstaculo3.Bounds;
            rectangulos[4] = obstaculo4.Bounds;
            rectangulos[5] = obstaculo5.Bounds;
            rectangulos[6] = obstaculo6.Bounds;
            rectangulos[7] = obstaculo7.Bounds;
            rectangulos[8] = obstaculo8.Bounds;
            rectangulos[9] = obstaculo9.Bounds;
            rectangulos[10] = obstaculo10.Bounds;
            rectangulos[11] = obstaculo11.Bounds;
            rectangulos[12] = obstaculo12.Bounds;
            rectangulos[13] = obstaculo13.Bounds;
            rectangulos[14] = obstaculo14.Bounds;
            rectangulos[15] = obstaculo15.Bounds;
            rectangulos[16] = obstaculo16.Bounds;
            rectangulos[17] = obstaculo17.Bounds;
            rectangulos[18] = obstaculo18.Bounds;
            rectangulos[19] = obstaculo19.Bounds;
            Personaje.MoverJugador(e.KeyCode);
            personajeEspecial.Interactuar();

            if (colisionDetector.DetectarColision(rectangulos))
            {
                if (!colisionando)
                {
                    colisionando = true;
                    Personaje.choque(25);
                    progressBar1.Value = Personaje.VidaActual;

                    if (progressBar1.Value == 0)
                    {
                        if (f2 == null)
                        {
                            f2 = new perder();
                        }
                        f2.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                colisionando = false;
            }

            if (rectangulos[0].IntersectsWith(PBganar.Bounds))
            {
                Form a = new ganar();
                a.Show();
                this.Close();
                Form b = new perder();
                b.Close();
            }

            foreach (PictureBox punto in puntos)
            {
                if (rectangulos[0].IntersectsWith(punto.Bounds) && punto.Visible)
                {
                    punto.Visible = false;
                    puntuacion += 100;

                    using (StreamWriter writer = new StreamWriter(@"C:\Users\juan\Downloads\TAREAS\puntos.txt"))
                    {
                        writer.WriteLine("Puntuación: " + puntuacion);
                    }
                }
            }
        }
    }
}
