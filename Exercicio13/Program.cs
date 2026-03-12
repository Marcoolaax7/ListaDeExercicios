//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.

Console.WriteLine("Digite o valor de A: ");
decimal vA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
decimal vB = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
decimal vC = Convert.ToDecimal(Console.ReadLine());

if (vA + vB < vC)
{
    Console.WriteLine("A soma de a + b é menor que c.");
}
else
{
    Console.WriteLine("A soma de a + b nao é menor que c!");
}