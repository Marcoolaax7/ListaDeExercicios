// A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
// terreno e depois exibir a área do terreno.


Console.Write("Digite a largura do terreno: ");
decimal largura = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o comprimento do terreno: ");
decimal comprimento = Convert.ToDecimal(Console.ReadLine());

decimal area = largura * comprimento;

Console.WriteLine($"A area do terreno é: {area} metros quadrados ");

Console.ReadLine();