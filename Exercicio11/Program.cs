// Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
//Considere sempre anos completos, e que um ano possui 365 dias. Ex: uma pessoa com 19 anos possui 6935 dias
//de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.

Console.WriteLine("Digite o seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade: ");
int idade = Convert.ToInt32(Console.ReadLine());

decimal diasDeVida = idade * 365m;

Console.WriteLine($"{nome} voce ja viveu {diasDeVida} dias!");