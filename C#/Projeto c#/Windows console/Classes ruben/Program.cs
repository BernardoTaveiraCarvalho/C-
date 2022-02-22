using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ruben
{
    class Program
    {
        static void Main()
        {
            Ponto p1 = new Ponto(1, 2);
            Ponto p2 = new Ponto(3, 4);
            Reta r1 = new Reta(p1, p2);
           
           Console.WriteLine("A distância é: " + Reta.Distancia(r1));
            Console.WriteLine("A reta é: " + r1.ToString());
            Console.WriteLine("A distância é: " + r1.Distancia1());

            Pessoa p3 = new Pessoa(null, -1);
            Console.WriteLine(p3.ToString());
        }
    }
}
