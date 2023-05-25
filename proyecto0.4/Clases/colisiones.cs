using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto0._4.Clases
{
    internal class colisiones
    {
        public bool DetectarColision(Rectangle[] rectangulos)
        {
            for (int i = 0; i < rectangulos.Length - 1; i++)
            {
                for (int j = i + 1; j < rectangulos.Length; j++)
                {
                    if (rectangulos[i].IntersectsWith(rectangulos[j]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
