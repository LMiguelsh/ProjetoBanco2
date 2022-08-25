using ProjetoBanco;
using System.Globalization;

Conta c1;

Console.Write("Entre o numero da Conta: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Entre o nome do Titular: ");
string n = Console.ReadLine();
Console.Write("Havera deposito inicial(S/N)? ");
char opcao = char.Parse(Console.ReadLine());
if (opcao == 'S' || opcao == 's') {
    Console.Write("Entre com o valor a ser depositado: ");
     double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
     c1 = new Conta(num, n, deposito);
} else {
    c1 = new Conta(num, n);
}

Console.WriteLine();
Console.WriteLine("Dados da conta");
Console.WriteLine(c1);
Console.Write("Entre um valor para depósito: ");
double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c1.Depositar(v);
Console.WriteLine("Dados atualizados da conta: ");
Console.WriteLine(c1);
Console.Write("Entre um valor para saque: ");
v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
c1.Sacar(v);
Console.WriteLine("Dados atualizados da conta: ");
Console.WriteLine(c1);
