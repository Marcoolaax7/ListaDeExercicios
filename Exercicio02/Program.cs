// Crie um programa para calcular o volume de um Cilindro
// 

Console.Clear();

Console.WriteLine("Digite o raio do cilindro: ");
double raio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a altura do cilindro: ");
double altura = Convert.ToDouble(Console.ReadLine());
 

double areaBase = Math.PI * Math.Pow(raio, 2);

double volume = areaBase * altura;

Console.WriteLine($"O volume do cilindro é: {volume} cm3");


Console.ReadLine();