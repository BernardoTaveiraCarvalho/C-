using System;
using System.IO;
namespace LerFicheiros
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader rd = new StreamReader(@"Vencimentos.txt");
            StreamWriter wr = new StreamWriter(@"Supmil.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] partesLinha = linha.Split(" ");
                if (int.Parse(partesLinha[2]) > 1000)
                {
                    
                    wr.WriteLine(linha);
                }
            }
            wr.Close();
            
            if (new FileInfo(@"Supmil.txt").Length == 0)
            {
                wr = new StreamWriter(@"Supmil.txt");
                wr.WriteLine("vazio");
                wr.Close();
            }
            

        }
    }
}
