using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Conta
    {
        public int numero;
        public String titular;
        public double saldo;

        public void Sacar(double valor)
        {
            this.saldo -= valor;
        }

        public void Deposita (double valor)
        {

            this.saldo += valor;
        }

        public void Traferencia ( double valor , Conta destino)
        {

            this.Sacar(valor);
            destino.Deposita(valor);

        }

    }
}
