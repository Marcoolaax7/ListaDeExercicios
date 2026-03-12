// Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
//impostos. Imprima o salário inicial, o salário com o aumento e o salário final.


Console.Write("Digite o salario inicial: ");
decimal salarioInicial = Convert.ToDecimal(Console.ReadLine());

decimal aumentoSalario = salarioInicial + (salarioInicial * 0.15m);

decimal salarioFinal = aumentoSalario - (aumentoSalario * 0.08m);

Console.WriteLine($"O salario inicial é de R${salarioInicial},o aumento do salario em 15% ficou em R${aumentoSalario} e o salario final ja tirando o 8% de imposto é de R${salarioFinal}.");

Console.ReadLine();