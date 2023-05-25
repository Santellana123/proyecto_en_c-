using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto0._4.Clases
{
    internal class victoria
    {
        public bool ComprobarVictoria(Rectangle[] rectangulos, Rectangle[] puntos)
        {
            foreach (Rectangle puntoRectangulo in puntos)
            {
                if (rectangulos[0].IntersectsWith(puntoRectangulo))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
