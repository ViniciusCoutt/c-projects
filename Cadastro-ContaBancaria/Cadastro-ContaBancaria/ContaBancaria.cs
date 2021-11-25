using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_ContaBancaria
{
    class ContaBancaria
    {
        //Atributos: Privados > publicos > propriedades autoimplementadas
        
        public int Numero { get; private set; }
        public string Nome { get; set; } 
        public double Saldo { get; private set; }
        public static double Taxa = 5.00;

        //Construtores
        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(numero, nome)
        {
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= (Taxa + valor);
        }

        public override string ToString()
        {
            return $"\nConta numero: {Numero}, Titular: {Nome}, $ Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
