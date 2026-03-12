// Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

Console.WriteLine("Digite a primeira nota: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o peso da primeira nota: ");
decimal peso1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o peso da segunda nota: ");
decimal peso2 = Convert.ToDecimal(Console.ReadLine());


decimal mediaPonderada = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);


Console.WriteLine($"Digite a media ponderada do aluno {mediaPonderada}");

Console.ReadLine();