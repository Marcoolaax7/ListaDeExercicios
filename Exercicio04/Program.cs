// Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
// multiplique a temperatura(C) por 1,8 e some 32

Console.WriteLine("Digite qual a temperatura inicial: ");
decimal temperaturaInicial = Convert.ToDecimal(Console.ReadLine());

decimal temperaturaConvertida = temperaturaInicial * 1.8m + 32;

Console.WriteLine($"Sua temperatura covertida para Fahrenheit agora é: {temperaturaConvertida} °F ");
Console.ReadLine();