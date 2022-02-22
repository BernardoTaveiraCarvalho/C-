using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(new Pessoa("Maria", "marioa@atec.pt", 1.50, 2222));
            listaPessoas.Add(new Pessoa("Maria","marioa@atec.pt",1.50,2222));

            Turma tpsi = new Turma("TPSIP.10.21", listaPessoas);
            for (int i = 0; i < tpsi.listaPessoas.Count;i++){
            }





            //Pessoa p1= new Pessoa();
            //p1.Nome = "João";
            //p1.Email = "joao@atec.pt";
            //p1.Altura = 1.80;
            //p1.Telefone = 9323232;

            //Pessoa p2 = new Pessoa("João","ana@atec.pt",1.60,92222332);
            //Console.WriteLine(p1.Nome.Equals(p2.Email));
            //List<Pessoa> listaPessoas = new List<Pessoa>();
            //listaPessoas.Add(p1);
            //listaPessoas.Add(p2);
            //listaPessoas.Add(new Pessoa("Maria", "marioa@atec.pt", 1.50, 2222));
            //listaPessoas.Add(new Pessoa("Maria","marioa@atec.pt",1.50,2222));
            //Console.WriteLine("Lista de Pessoas");
            //for(int i = 0; i < listaPessoas.Count; i++)
            //{
            //    Console.WriteLine(listaPessoas[i].ToString());
            //}
        }
    }
}
