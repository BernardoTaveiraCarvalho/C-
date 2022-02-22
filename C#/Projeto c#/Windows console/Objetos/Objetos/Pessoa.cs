using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Pessoa
    {
        //Encapsulamento
      
        public string Nome { get ; set ; }
        public string Email { get ; set; }
        public double Altura { get ; set ; }
        public int Telefone { get ; set; }
        //Construtores
        public Pessoa()
        {
            Nome = "";
            Email = "";
            Altura = 0;
            Telefone = 0;
        }

        public Pessoa(string nome, string email, double altura, int telefone)
        {
            Nome = nome;
            Email = email;
            Altura = altura;
            Telefone = telefone;
        }
        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
            
           
        }
        public Pessoa(Pessoa p)
        {
            Nome = p.Nome;
            Email = p.Email;
            Altura = p.Altura;
            Telefone = p.Telefone;
        }
        //Override Methods 
        public override string ToString()
        {
            return "Pessoa : \t Nome: " + Nome + "\tEmail: " + Email+"\tAltura:"+Altura+"\tTelefone: "+Telefone;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

       

    }
}
