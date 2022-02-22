using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ficheiro_Ficha_3
{

    class Program
    {

        static List<Produtos> listaProdutos;
        static List<Clientes> listaClientes;
        static List<Compras> listaCompras;
        static void Main(string[] args)
        {
            criarListaProdutos();
            criarListaClientes();
            criarListaCompras();
            Console.WriteLine("saiu");
            criarFicheiroCliente();
            criarTopProdutosComprados();
        }

        private static void criarFicheiroCliente()
        {
            Console.WriteLine("Entrou");
            
            int valor=0;
            int quantidade = 0;
            Console.WriteLine(listaClientes.Count);
            Console.WriteLine(listaCompras.Count);
            for (int i = 0; i < listaClientes.Count; i++)
            {
                valor = 0;
                quantidade = 0;
                Console.WriteLine("i " + i);
                for (int j = 0; j < listaCompras.Count; j++)
                {
                    Console.WriteLine("j " + j);
                    if (listaCompras[j].IdCliente == i+1)
                    {
                      
                        
                        for(int x = 0; x < listaProdutos.Count; x++)
                        {
                            if (listaProdutos[x].ID == listaCompras[j].IdArtigo)
                            {
                                quantidade++;
                                valor += listaProdutos[x].Preco;
                                
                            }
                        }
                      
                    }

                }
                StreamWriter wr = new StreamWriter(listaClientes[i].Nome+".txt");
         
                wr.WriteLine("O cliente " + listaClientes[i].Nome + " comprou: " + quantidade + " produtos" + " e gastou " + valor + " euros");
                wr.Close();

            }    
        }
        private static void criarTopProdutosComprados()
        {
            int[] vet = new int[listaProdutos.Count];
            for (int j = 0; j < listaProdutos.Count; j++)
            {
                for (int i = 0; i < listaCompras.Count; i++)
                {
                    if (listaProdutos[j].ID == listaCompras[i].IdArtigo)
                    {
                        vet[j]++;
                    }
                }
            }
            int maior = 0;
           for(int i = 1; i < vet.Length; i++)
            {
                if (vet[i] > vet[maior])
                {
                    maior=i;
                }
            }
            StreamWriter wr = new StreamWriter("Produtos Mais vendidos.txt");
            for (int i = 1; i < listaProdutos.Count; i++)
            {
                if(vet[i]==vet[maior])
                wr.WriteLine("O produto " + listaProdutos[i].Artigo + " com o id: " + listaProdutos[i].ID + " foi vendido "+vet[i]+" veze(s)" );
                
            }
            wr.Close();
        }
  
        private static void criarListaClientes()
        {
            StreamReader rd = new StreamReader(@"clientes.csv");
            bool first = true;

            listaClientes = new List<Clientes>();
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] partesLinha = linha.Split(';');
                if (partesLinha[0] == "") break;
                if (first == true) first = false;
                else
                {
                    
                   listaClientes.Add(new Clientes(int.Parse(partesLinha[0]), partesLinha[1], partesLinha[2], int.Parse(partesLinha[3])));
                }
            }
        }

        private static void criarListaCompras()
        {
            StreamReader rd = new StreamReader(@"compras.csv");
            bool first = true;
            listaCompras = new List<Compras>();
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] partesLinha = linha.Split(';');
                if (partesLinha[0] == "") break;
                if (first == true) first = false;
                else
                {
                  
                   listaCompras.Add(new Compras(int.Parse(partesLinha[0]), int.Parse(partesLinha[1]),partesLinha[2]));
                }
            }
        }

        private static void criarListaProdutos()
        {
            StreamReader rd = new StreamReader(@"produtos.csv");
            bool first = true;
            listaProdutos = new List<Produtos>();
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                string[] partesLinha = linha.Split(';');
                if (partesLinha[0] == "") break;
                if (first == true) first = false;
                else
                {
                    listaProdutos.Add(new Produtos(int.Parse(partesLinha[0]), partesLinha[1], partesLinha[2], partesLinha[3], int.Parse(partesLinha[4])));
                }
            }
        }
    }
}
