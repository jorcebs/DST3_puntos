using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puntos
{
    class Punto
    {
        public int x;
        public int y;

        public Punto()
        {
            x = y = 5;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double calculaDistancia(int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
        }

        public double calculaDistancia(Punto punto)
        {
            return calculaDistancia(punto.x, punto.y);
        }

        public override string ToString()
        {
            return "(" + x.ToString() + "," + y.ToString() + ")";
        }
    }
}