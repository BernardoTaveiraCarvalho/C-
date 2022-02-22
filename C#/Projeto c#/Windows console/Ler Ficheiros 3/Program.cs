using System ;
using System.IO;
using Microsoft.VisualBasic.FileIO;
namespace Ler_Ficheiros_3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int quantidadeclient = 0;
            int quantidadeprod = 0;
            
            StreamReader rdprod = new StreamReader(@"produtos.csv");
            StreamReader rdcompra = new StreamReader(@"compras.csv");
            StreamReader rdcliente = new StreamReader(@"clientes.csv");
            while (!rdcliente.EndOfStream)
            {
                quantidadeclient++;
               
            }
            while (!rdprod.EndOfStream)
            {
                quantidadeprod++;
            }
            string[,] vet = new string[quantidadeclient,quantidadeprod];
            while (!rdcompra.EndOfStream)
            {
                string linha = rdcliente.ReadLine();
                string[] partesLinha = linha.Split(";");
                vet[int.Parse(partesLinha[0]),0] = partesLinha[1];
            }
           
        }
    }
}
