using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiro_Ficha_3
{
    class Clientes
    {
        public Clientes(int idCliente)
        {
            IdCliente = idCliente;
        }

        public Clientes(string nome)
        {
            Nome = nome;
        }
      

        public Clientes(int idCliente, string nome, string localidade, int nif)
        {
            IdCliente = idCliente;
            Nome = nome;
            Localidade = localidade;
            Nif = nif;
        }

        public int IdCliente{ get; set; }
        public string Nome { get; set; }
        public string Localidade { get; set; }
        public int Nif { get; set; }

    }
}
