//Crie um programa para calcular a média harmônica das notas de um Aluno



Console.WriteLine("Digite a primeira nota: ");
decimal nota1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
decimal nota2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
decimal nota3 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quarta nota: ");
decimal nota4 = Convert.ToDecimal(Console.ReadLine());


decimal mediaHarmonica = 4 / ((1.0m / nota1) + (1.0m / nota2) + (1.0m / nota3) + (1.0m / nota4));


Console.WriteLine($"A media harmonica final do aluno é: {mediaHarmonica} ");

Console.ReadLine();