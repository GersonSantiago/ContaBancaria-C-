using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entities
{
    internal class ContaPoupanca : Conta
    {
        public double TaxaDeJuros { get; set; }

        public ContaPoupanca(int numero, string titular, double saldo, double taxadejuros)
            : base(numero, titular, saldo)
        {
            TaxaDeJuros = taxadejuros;
        }

        public void AtualizarSaldo()
        {
            Saldo += Saldo * TaxaDeJuros;
        }

        public override void Saque(double quantia)
        {
            Saldo -= quantia;
        }


    }

}
