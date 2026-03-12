// Crie um programa para verificar se um número é primo.

Console.Write("Digite um número para verificar se é primo: ");
int numero = Convert.ToInt32(Console.ReadLine());

bool numeroPrimo = true;

for (int i = 2; i < numero; i++)
{
    if (numero % i == 0)
        numeroPrimo = false;

}
if (numeroPrimo)
{
    Console.WriteLine($"{numero} é um número primo!");
}
else
{
    Console.WriteLine($"{numero} nao é um número primo!");
}
Console.ReadLine();