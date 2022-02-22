using System;

namespace Function
{
    class Program
    {
        static  bool stringpalindromo(string palavra)//N
        {
            for (int i = 0; i < palavra.Length; i++)
            {
                if(palavra[i]!= palavra[(palavra.Length-1) - i]){
                    return false;
                }
            }
            return true;
        }
        static void vetorOrdenardo()//L
        {
            string troca;
            string[] vetor = new string[10] { "amor", "bagulho" ,"zoga","pilha","pocaontas","bife","arroz","porrada","abelha","piri"};
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (vetor[i].CompareTo(vetor[j]) == 1)
                    {
                        troca = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = troca;
                    }
                }
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vet[" + i + "]= "+vetor[i]);
            }
        }
        static string stringAlfabeitca(string palavra1,string palavra2)//K
        {
            if (palavra1.CompareTo(palavra2) == -1)
            {
                return palavra1;
            }
            return palavra2;
        }
        static bool temAlgarismos(string palavra) //I
        {
            int number;
            if (int.TryParse(palavra, out number)==false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool algrismosString(string palavra)//J
        {
            for(int i = 0; i < palavra.Length; i++)
            {
                //Console.WriteLine(palavra[i].ToString()+"\n");
                if (palavra[i] >= '0' && palavra[i]< '9')
                    return false;
            }
            return true;
        }
        static string substituirString(string palavra)//H
        {
           palavra= palavra.Replace("v", "b");
            palavra= palavra.Replace("ao", "om");
            return palavra;
        }
         static string  comprimentoString(string nome1,string nome2,string nome3)// E
        {
            if (nome1.Length > nome2.Length)
                if (nome1.Length > nome3.Length) return nome1;
                else if (nome2.Length > nome3.Length) return nome2;
                else return nome3;
            else if (nome2.Length > nome3.Length) return nome2;
            else return nome3;
       
        }
        static bool vetorComMesmoTamanho(string[] vetor) //F
        {
            int Tamanho = vetor[0].Length;
           for (int i = 1; i< vetor.Length; i++)
            {
                if (vetor[i].Length != Tamanho)
                {
                    return false;
                }
            }
            return true;
        }
        static int vetorValorTotalTamanho(string[] vetor)//G
        {
            int total=0;
            for (int i = 1; i < vetor.Length; i++)
            {
                total += vetor[i].Length;
                
            }
            return total;
        }
        static bool cavaloBrancoDeNapoleão(string palavra)//M
        {
           if(palavra.CompareTo("branco") == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            /*
             //E Inicio
            Console.WriteLine("Digite um nome");
            string nome1 = Console.ReadLine();
            Console.WriteLine("Digite um nome");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite um nome \n");
            string nome3 = Console.ReadLine();
           string maior= comprimentoString(nome1, nome2, nome3);
            Console.WriteLine("Maior comprimento "+ maior);
            //E Fim


            //F Inicio
            string[] vetor=new string[2] { "a", "bad" };
            Console.WriteLine("O vetor inserido tem tamanhos iguais? "+ vetorComMesmoTamanho(vetor));
            //F Fim



            //G Inicio
            Console.WriteLine("O valor total do tamanho das strings do vetor inserido é " + vetorValorTotalTamanho(vetor));
            //G Fim


            //H Inicio
            Console.WriteLine("Digite uma palavra");
            string palavra = Console.ReadLine();
            Console.WriteLine("Palavra transformada: "+ substituirString(palavra));
            //H Fim

            //I inicio
                Console.WriteLine("Palavra  "+palavra+" tem só algarismos: " + temAlgarismos(palavra));
            //I Fim

            //J Inico
            Console.WriteLine("Digite a palavra não tem algarismos: "+ algrismosString(palavra));
            //J Fim

            //K Inicio
            Console.WriteLine("Digite uma palavra1");
            string palavra1 = Console.ReadLine();
            Console.WriteLine("Digite uma palavr2");
            string palavra2 = Console.ReadLine();
            Console.WriteLine("Palavra maior: "+ stringAlfabeitca(palavra1, palavra2));
            //K Fim
            //L Inicio
            vetorOrdenardo();
            //L Fim

            //N Inicio
            Console.WriteLine("Digite uma palavra1");
            string palavra1 = Console.ReadLine();
            Console.WriteLine("A palavra é um palindromo "+ stringpalindromo(palavra1));
            //N Fim


            //M Inicio
            string palavra;
            do
            {
                Console.WriteLine("Qual é a cor do cavalo branco? ");
                palavra = Console.ReadLine();
            }while (cavaloBrancoDeNapoleão(palavra) != true) ;
            //M Fim
            */
        }
    }
}
