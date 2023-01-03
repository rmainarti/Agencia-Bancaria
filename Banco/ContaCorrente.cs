﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public string titular;
        public double saldo;

        public void Depositar(double valor)
        {
            this.saldo += valor;
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
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

    }
}
