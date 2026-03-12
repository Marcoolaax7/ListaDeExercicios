// Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
// vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.



Console.WriteLine("Digite o salario do vendedor: ");
decimal salarioBase = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o total de vendas do vendedor: ");
decimal totalVendas = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o percentual do vendedor por cada venda: ");
decimal percentualVenda = Convert.ToDecimal(Console.ReadLine());


decimal comissaoFinal = totalVendas * (percentualVenda / 100);

Console.WriteLine($"A porcentagem do vendedor pelas vendas foi de: R$ {comissaoFinal} ");
decimal salarioTotal = comissaoFinal + salarioBase;

Console.WriteLine($"O salario total do vendedor é de: R$ {salarioTotal} ");


Console.ReadLine();