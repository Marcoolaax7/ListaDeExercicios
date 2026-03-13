// O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) 2. Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
//● IMC em adultos Condição
//● Abaixo de 18,5
//● Abaixo do peso
//● Entre 18,5 e 25 Peso normal
//● Entre 25 e 30
//● Acima do peso
//● Acima de 30 obeso

Console.Write("Digite seu peso (kg): ");
decimal peso = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite sua altura (m): ");
decimal altura = Convert.ToDecimal(Console.ReadLine());

decimal imc = peso / (altura * altura); 

if (imc < 18.5m)
{
    Console.WriteLine("Voce esta a baixo do peso: ");
}
else if (imc >= 18.5m && imc < 25)
{
    Console.WriteLine("Voce esta com o peso normal!");
}
else if (imc >= 25 && imc < 30)
{
    Console.WriteLine("Voce esta acima do peso!");
}
else
{
    Console.WriteLine("Voce esta obeso");
}
