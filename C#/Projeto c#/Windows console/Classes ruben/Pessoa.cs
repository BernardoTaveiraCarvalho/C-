using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ruben
{
    class Pessoa
    {
        string nome;
        int idade;

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return "Nome:"+Nome+" Idade: "+idade;
        }

        public string Nome { get => nome; 
            set
            {
                if (value != null)
                {
                    nome = value;
                }
                else
                {
                    nome = "X";
                }
            } }
        public int Idade { get => idade; 
            set
            {
                if (value > 0 && value < 100)
                {
                    idade = value;
                }
                else
                {
                    idade = 0;
                }
            }
        }


    }
}
