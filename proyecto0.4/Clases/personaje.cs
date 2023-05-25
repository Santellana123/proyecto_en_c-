using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto0._4.Clases
{
    internal class personaje:Ichoque
    {
        public PictureBox Jugador { get; set; }
        public int VidaActual { get; set; }

        public personaje(PictureBox jugador)
        {
            Jugador = jugador;
            VidaActual = 100;
        }

        public void MoverJugador(Keys tecla)
        {
            switch (tecla)
            {
                case Keys.D:
                    Jugador.Location = new Point(Jugador.Location.X + 10, Jugador.Location.Y);
                    break;
                case Keys.A:
                    Jugador.Location = new Point(Jugador.Location.X - 10, Jugador.Location.Y);
                    break;
                case Keys.W:
                    Jugador.Location = new Point(Jugador.Location.X, Jugador.Location.Y - 10);
                    break;
                case Keys.S:
                    Jugador.Location = new Point(Jugador.Location.X, Jugador.Location.Y + 10);
                    break;
            }

            Rectangle[] rectangulos = new Rectangle[] { Jugador.Bounds };

        }

        public virtual void choque(int daño)
        {
            Jugador.Location = new Point(40, 395);
            Jugador.Size = new Size(30, 31);
            VidaActual -= daño;
        }

    }
}
