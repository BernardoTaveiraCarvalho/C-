using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Turma
    {
        public Turma(string nome, List<Pessoa> listaPessoas)
        {
            Nome = nome;
            this.listaPessoas = listaPessoas;
        }

        public string Nome { get; set; }
        public List<Pessoa> listaPessoas { get; set; }

    }
}
