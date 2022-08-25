using System.Globalization;

namespace ProjetoBanco {
    internal class Conta {

        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numConta, string nome) {
            NumConta = numConta;
            Nome = nome;
        }

        public Conta(int numConta, string nome, double depositoInicial) : this(numConta, nome) {
            Depositar(depositoInicial);
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }
        public void Sacar(double valor) {
            Saldo -= valor + 5.0;
        }

        public override string ToString() {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
