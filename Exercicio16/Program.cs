// Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.WriteLine("Informe um numero: ");
decimal numero = Convert.ToDecimal(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("O numero é Par!");
}
else
{
    Console.WriteLine("O numero é Ímpar!");
}