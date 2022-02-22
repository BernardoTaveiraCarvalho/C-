using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ruben
{
    class Reta
    {
        public Reta(Ponto ponto1, Ponto ponto2)
        {
            Ponto1 = ponto1;
            Ponto2 = ponto2;
        }
        public  static double  Distancia(Reta reta)
        {
            
            return Math.Sqrt(Math.Pow((reta.Ponto2.X - reta.Ponto1.X), 2) + Math.Pow((reta.Ponto2.Y - reta.Ponto1.Y), 2));
        }
        public double Distancia1()
        {

            return Math.Sqrt(Math.Pow((Ponto2.X - Ponto1.X), 2) + Math.Pow((Ponto2.Y - Ponto1.Y), 2));
        }

        public Ponto Ponto1 { get; set; }
        public Ponto Ponto2 { get; set; }

        public override string ToString()
        {
            return "Ponto1 ("+Ponto1.X+","+Ponto1.Y+")"+" Ponto2 ("+Ponto2.X+","+Ponto2.Y+")";
        }
    }
}
