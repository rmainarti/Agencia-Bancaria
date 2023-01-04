using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string titular = "";
        public string conta = "";
        public double saldo;


        // 2.0  para usar a classs cliente em Progam
        // comentar a String titular para usar essa parte 2.0
        // public Cliente titular;

        public void Depositar(double valor)
        {
            saldo += valor;
        }


        // método sacar abaixo
        /*  public bool Sacar(double valor)
          {
              if (valor <= saldo)
              {
                 this.saldo -= valor;
                  return true;

              }
              else
              {
                  return false;

              }
          }
        */
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

    }
}
