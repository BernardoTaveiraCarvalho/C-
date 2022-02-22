using System;

namespace _5089ConsoleAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome ");
            string nome = Console.ReadLine();
            string letra1 = "";
            if (nome.Length >= 2) { 
                 letra1 = nome.Substring(nome.Length - 2, 2);
             }
            if (letra1 == "eu")
            {
                Console.Write("Dá cá o meu! \n");
            } else
            {
                Console.Write("Olá " + nome+"\n");
            }
            Console.WriteLine("Digite o seu nome completo \n");
            string nomecomp = Console.ReadLine();
            string[] partestexto = nomecomp.Split(' ');
            Console.WriteLine("Olá " + partestexto[0] + " "+partestexto[partestexto.Length-1]);

        }
    }
}
