using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiro_Ficha_3
{
    class Compras
    {
        public Compras(int idCliente)
        {
            IdCliente = idCliente;
        }

        public Compras(int idCliente, int idArtigo, string data)
        {
            IdCliente = idCliente;
            IdArtigo = idArtigo;
            Data = data;
        }

        public int IdCliente { get; set; }
        public int IdArtigo { get; set; }
        public string Data { get; set; }
    }
}
