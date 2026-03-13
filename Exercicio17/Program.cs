//Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//variável C e mostrar seu conteúdo na tela.

Console.Write("Digite o valor de A: ");
decimal vA = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o valor de B: ");
decimal vB = Convert.ToDecimal(Console.ReadLine());

decimal vC;

if (vA == vB)
{
    vC = vA + vB;
}
else
{
    vC = vA * vB;
}
Console.WriteLine($"O valor de C é: {vC} ");