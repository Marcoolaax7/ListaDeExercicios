// A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
//pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda
//dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi
//contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades
//de pães e de broas, e depois calcular os dados solicitados.

Console.Clear();

Console.Write("Quantidade de paes vendidas: ");
double quantidadePaes = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantidade de broas vendidas: ");
double quantidadeBroas = Convert.ToDouble(Console.ReadLine());

double precoPao = 0.12;
double precoBroa = 1.50;

double precoJunto = precoPao * quantidadePaes + precoBroa * quantidadeBroas;

double valorParaPoupanca = precoJunto * 0.10;

Console.Write($"Quantidade total ventida foi de: R${precoJunto} e o valor para guardar na poupança é de R${valorParaPoupanca.ToString("f2")} reais");