using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto0._4.Clases
{
    internal class PersonajeEspecial : personaje
    {
        private PictureBox disminuir;
        private Color colorInicial;

        public PersonajeEspecial(PictureBox jugador, PictureBox disminuir) : base(jugador)
        {
            this.disminuir = disminuir;
            colorInicial = jugador.BackColor;
        }

        public void Interactuar()
        {
            if (Jugador.Bounds.IntersectsWith(disminuir.Bounds))
            {
               
                Jugador.Location = new Point(355, 202);//reposicionamos al nuevo personaje
                Jugador.Size = new Size(15, 20);//cambiamos el tamaño a nuevo personaje
               
            }
        }

    }
}
