using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ruben
{
    class Ponto
    {

        private double x, y, z, w;
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }
        public double W { get => w; set => w = value; }

        public Ponto()
        {
            X = 0;
            Y = 0;
        }
        public Ponto(int x, int y)
        {
            this.x = x;//quando são iguais
            this.y = y;
        }
        
        public Ponto(int x,int y,int z) : this(x, y)
        {
            this.z = z;
        }
        public Ponto(int x, int y, int z, int w) : this(x, y,z)
        {
            this.w = w;
        }
        public Ponto(Ponto p1)
        {
           x= p1.x;
            y= p1.y;
        }

        public override string ToString()
        {
            return "Ponto: (" + x.ToString() + "," + y.ToString()+")";
        }
        
}
}
