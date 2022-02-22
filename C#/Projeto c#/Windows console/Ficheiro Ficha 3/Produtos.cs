using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheiro_Ficha_3
{
    class Produtos
    {
        public Produtos(int iD, string categoria, string artigo, string estado, int preco)
        {
            ID = iD;
            Categoria = categoria;
            Artigo = artigo;
            Estado = estado;
            Preco = preco;
        }

        public int ID { get; set; }
        public string Categoria { get; set; }
        public string Artigo { get; set; }
        public string Estado { get; set; }
        public int Preco { get; set; }



    }

}

      
    

