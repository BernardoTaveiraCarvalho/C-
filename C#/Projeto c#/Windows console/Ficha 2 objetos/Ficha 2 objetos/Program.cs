using System;
using System.Collections.Generic;

namespace Ficha_2_objetos
{
    class Program
    {
        static List<Conta> listaContas;

        private static bool encontraConta(int id)
        {
            Console.Clear();
            for (int i = 0; i < listaContas.Count; i++)
            {
                if (listaContas[i].Numero == id)
                    return true;
            }
            return false;
        }
        private static void trasnferenciaConta(Conta conta)
        {
            Console.Clear();
            Console.WriteLine("Indique o numero da conta que quer transfência: ");
            int id = int.Parse(Console.ReadLine());
            if (listaContas.Count < id || encontraConta(id) == false) { Console.WriteLine("Não foi encontrada esta conta"); Console.ReadLine(); return; }

            Console.WriteLine("Indique o valor que quer transfência: ");
            double valor = double.Parse(Console.ReadLine());
            if (valor > conta.Saldo)
            {
                Console.WriteLine("Não tem saldo: ");
                Console.ReadLine();
            }
            else
            {
                conta.Saldo -= valor;
                for (int i = 0; i < listaContas.Count; i++)
                {
                    if (listaContas[i].Numero == id)
                    {
                        listaContas[i].Saldo += valor;
                        Console.WriteLine("Insire a decrição da movimentação");
                        string descricao = Console.ReadLine();

                        string tipo = Console.ReadLine();
                        listaContas[i].ListaMovimentos.Add(new Movimentação(descricao, valor, "debito"));
                        conta.ListaMovimentos.Add(new Movimentação(descricao, valor, "credito"));
                    }
                }

            }
        }
        private static void emissaoextratoConta(Conta conta)
        {
            Console.Clear();
            Console.WriteLine("Extrado da conta numero: " + conta.Numero + " \n");
            if (conta.ListaMovimentos.Count > 0)
                for (int i = 0; i < conta.ListaMovimentos.Count; i++)
                {
                    Console.WriteLine("Movimento " + i + "\n" + conta.ListaMovimentos[i].ToString());
                }
            else Console.WriteLine("Não tem movimentos");
            Console.ReadLine();
        }
        private static void emissaoSaldoConta(Conta conta)
        {
            Console.Clear();
            Console.WriteLine("O seu saldo é: " + conta.Saldo);
            Console.ReadLine();
        }
        private static void depositoConta(Conta conta)
        {
            Console.Clear();
            Console.WriteLine("Digite o valor que pretende depositar");
            double valor = double.Parse(Console.ReadLine());
            conta.Saldo += valor;


        }
        private static void levantamentoConta(Conta conta)
        {
            Console.Clear();
            Console.WriteLine("Digite o valor que pretende levantar");
            double valor = double.Parse(Console.ReadLine());
            if (conta.Limite > valor)
            {
                conta.Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Passou o limite");
                Console.ReadLine();
            }
        }
        static void menuconta(Conta conta)
        {
            Console.Clear();
            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Conta numero: " + conta.Numero + "\n");
                Console.WriteLine("0---Levantamento\n");
                Console.WriteLine("1--Deposito\n");
                Console.WriteLine("2---Emissão saldo\n");
                Console.WriteLine("3--Emissão extrato\n");
                Console.WriteLine("4--Transferência\n");
                Console.WriteLine("5---Sair\n");
                op = int.Parse(Console.ReadLine());
                if (op == 0)
                {
                    levantamentoConta(conta);
                }
                else if (op == 1)
                {
                    depositoConta(conta);
                }
                else if (op == 2)
                {
                    emissaoSaldoConta(conta);
                }
                else if (op == 3)
                {
                    emissaoextratoConta(conta);
                }
                else if (op == 4)
                {
                    trasnferenciaConta(conta);
                }
            } while (op != 5);
        }
        static void entrarConta()
        {
            Console.Clear();
            Console.WriteLine("Insira o numero da conta que quer entrar ");
            int id = int.Parse(Console.ReadLine());
            if (listaContas.Count < id || encontraConta(id) == false)
            {
                Console.WriteLine("Não foi encontrada esta conta"); Console.ReadLine(); return;
            }

            for (int i = 0; i < listaContas.Count; i++)
            {
                if (listaContas[i].Numero == id)
                {
                    menuconta(listaContas[i]);
                }
            }
        }
        static void escreverContas()
        {
            Console.Clear();
            for (int i = 0; i < listaContas.Count; i++)
            {
                Console.WriteLine(listaContas[i].ToString());
            }
            Console.ReadKey();
        }
        static void criarConta()
        {
            Console.Clear();
            string estado = "";
            Console.WriteLine("Insira o numero conta");
            int numero = int.Parse(Console.ReadLine());
            if (encontraConta(numero) == true)
            {
                Console.WriteLine("Já existe essa conta"); Console.ReadLine(); return;
            }
            Console.WriteLine("Insira o valor do saldo da conta");
            double saldo = double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Insira o estado(normal/especial) da conta");
                estado = Console.ReadLine();
            } while (estado != "normal" && estado != "especial");

            Console.WriteLine("Insira o limite da conta");
            int limite = int.Parse(Console.ReadLine());
            listaContas.Add(new Conta(numero, saldo, estado, limite));

        }
        static void eliminarConta()
        {
            Console.Clear();
            Console.WriteLine("Escreva o numero da conta a eliminar ");
            int id = int.Parse(Console.ReadLine());
            if (listaContas.Count < id || encontraConta(id) == false) { Console.WriteLine("Não foi encontrada esta conta"); Console.ReadLine(); return; }

            for (int i = 0; i < listaContas.Count; i++)
            {
                if (listaContas[i].Numero == id)
                {
                    listaContas.RemoveAt(i);
                }
            }
        }
        static void criarLista()
        {

            listaContas.Add(new Conta(1, 1200, "normal", 4000));
            listaContas.Add(new Conta(2, 5200, "normal", 8000));
            listaContas.Add(new Conta(3, 4200, "normal", 8000));
            listaContas.Add(new Conta(4, 3200, "normal", 7000));
            listaContas.Add(new Conta(5, 2200, "normal", 5000));
            listaContas[0].ListaMovimentos.Add(new Movimentação("Pagamento de serviços", 200, "crédito"));

        }
        static void criarMovimentacao()
        {
            Console.Clear();
            string tipo = "";
            Console.WriteLine("Escreva o numero da conta que quer adicionar movimentacao ");
            int id = int.Parse(Console.ReadLine());
            if (listaContas.Count < id || encontraConta(id) == false) { Console.WriteLine("Não foi encontrada esta conta"); Console.ReadLine(); return; }
            for (int i = 0; i < listaContas.Count; i++)
            {
                if (listaContas[i].Numero == id)
                {
                    Console.WriteLine("Quantas movimentações vão ser adicionadas");
                    int tamanho = int.Parse(Console.ReadLine());
                    for (int j = 0; j < tamanho; j++)
                    {
                        Console.WriteLine("Indique a descrição da movimentação:");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("Indique o valor da movimentação:");
                        double valor = double.Parse(Console.ReadLine());
                        do
                        {
                            Console.WriteLine("Indique o tipo de movimentação(credito/debito):");
                            tipo = Console.ReadLine();
                        } while (tipo != "credito" && tipo != "debito");
                        listaContas[i].ListaMovimentos.Add(new Movimentação(descricao, valor, tipo));
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            listaContas = new List<Conta>();
            criarLista();

            int op = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("0---Ver Contas\n");
                Console.WriteLine("1--Inserir Conta\n");
                Console.WriteLine("2---Eliminar Conta\n");
                Console.WriteLine("3--Inserir Movimentação numa Conta\n");
                Console.WriteLine("4--Entrar numa conta\n");
                Console.WriteLine("5---Sair\n");
                op = int.Parse(Console.ReadLine());
                if (op == 0)
                {
                    escreverContas();
                }
                else if (op == 1)
                {
                    criarConta();
                }
                else if (op == 2)
                {
                    eliminarConta();
                }
                else if (op == 3)
                {
                    criarMovimentacao();
                }
                else if (op == 4)
                {
                    entrarConta();
                }
            } while (op != 5);
        }
    }
}
