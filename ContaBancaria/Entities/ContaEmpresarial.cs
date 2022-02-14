using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entities
{
    internal class ContaEmpresarial : Conta
    {
        public double LimiteDeEmprestimo { get; set; }

        public ContaEmpresarial()
        {
        }

        public ContaEmpresarial(int numero, string titular, double saldo, double limiteDeEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteDeEmprestimo)
            {
                Saldo += quantia;
            }

        }
    }


}
