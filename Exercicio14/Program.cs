//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.




Console.Clear();

Console.WriteLine("Digite o primeiro valor: ");
decimal v1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");
decimal v2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o terceiro valor: ");
decimal v3 = Convert.ToDecimal(Console.ReadLine());

if (v1 > v2 && v1 > v3)
{
    if (v2 > v3)
        Console.WriteLine($"Ordem decescente: {v1},{v2},{v3}.");
    else
        Console.WriteLine($"Ordem decescente: {v1},{v3},{v2}.");

}
else if (v2 > v1 && v2 > v3)
{
    if (v1 > v3)
        Console.WriteLine($"Ordem decescente: {v2},{v1},{v3}.");
    else
        Console.WriteLine($"Ordem decescente: {v2},{v3},{v1}.");

}
else
{
    if (v1 > v2)
        Console.WriteLine($"Ordem decescente: {v3},{v1},{v2}.");
    else
        Console.WriteLine($"Ordem decescente: {v3},{v2},{v1}.");

}


