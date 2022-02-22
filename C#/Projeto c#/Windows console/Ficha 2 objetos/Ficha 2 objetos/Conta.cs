using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_2_objetos
{
    class Conta
    {
        public Conta(int numero, double saldo, string estado, int limite)
        {
            Numero = numero;
            Saldo = saldo;
            Estado = estado;
            Limite = limite;
            ListaMovimentos = new List < Movimentação >();
        }
        public Conta(int numero, double saldo, string estado, int limite, List<Movimentação> listaMovimentos)
        {
            Numero = numero;
            Saldo = saldo;
            Estado = estado;
            Limite = limite;
            ListaMovimentos = listaMovimentos;
        }

        public int Numero { get; set; }
        public double Saldo { get; set; }
        public string Estado { get; set; }
        public int Limite { get; set; }
        public List<Movimentação> ListaMovimentos { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string texto= "\n----------Conta----------\nNumero: " + Numero + "\tSaldo: " + Saldo + "\tEstado:" + Estado + "\tLimite: " + Limite+"\n";
            texto += "\n----Lista de Movimentações---\n";
            if (ListaMovimentos.Count == 0)
            {
                texto += "\n Não tem movimentações\n";
            }
            else for (int i = 0; i < ListaMovimentos.Count; i++)
            {
                texto+= ListaMovimentos[i].ToString();
            }
            return texto;
        }

    }
}
