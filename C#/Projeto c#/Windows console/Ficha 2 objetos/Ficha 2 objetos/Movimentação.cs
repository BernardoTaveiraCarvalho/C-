using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2_objetos
{
    class Movimentação
    {
        

        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }

        public Movimentação(string descricao, double valor, string tipo)
        {
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return "Descrição: "+Descricao+"\tValor: "+Valor+"\tTipo:  "+Tipo;
        }

        public override bool Equals(object obj)
        {
            Movimentação m = obj as Movimentação;
            if ((m.Descricao == Descricao)  && (m.Valor == Valor ) && (m.Tipo == Tipo)) 
                return true;
            return false;


        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
