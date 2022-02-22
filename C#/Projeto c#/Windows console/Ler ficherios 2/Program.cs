using System;
using System.IO;

namespace Ler_ficherios_2
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                StreamReader rd = new StreamReader(@"Notas.txt");
            StreamWriter wr1 = new StreamWriter(@"Aprovados.txt");
            StreamWriter wr2 = new StreamWriter(@"Reprovados.txt");
            while (!rd.EndOfStream)
            {
                
                string linha = rd.ReadLine();
                string[] partesLinha = linha.Split(" ");
                if (double.Parse(partesLinha[2])> double.Parse("9,5"))
                {
                    
                    wr1.WriteLine(linha);
                }
                else
                {
                    wr2.WriteLine(linha);
                }
            }
            wr1.Close();
            wr2.Close();
            if (new FileInfo(@"Aprovados.txt").Length == 0)
            {
                wr1 = new StreamWriter(@"Supmil.txt");
                wr1.WriteLine("não contém registos");
                wr1.Close();
            }
            else if (new FileInfo(@"Reprovados.txt").Length == 0)
            {
                wr2 = new StreamWriter(@"Reprovados.txt");
                wr2.WriteLine("não contém registos");
                wr2.Close();
            }
                Console.WriteLine("Feito com sucesso");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não existe o ficheiros Notas");
            }
        }
    }
}

