using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entities
{
    internal class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get;  set; }

        public Conta()
        {
        }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }


        public virtual void Saque(double quantia)
        {
            Saldo -= quantia +5.0;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

    }
}
