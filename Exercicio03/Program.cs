
//Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
// O programa deve solicitar ao usuário:
//● A quilometragem inicial do veículo no início da viagem.
//● A quilometragem final ao término da viagem.
//● A quantidade de combustível consumida durante a viagem (em litros).


Console.WriteLine("Digite a quilometragem inicial do veiculo: ");
decimal kmInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quilometragem final do veiculo: ");
decimal kmFinal = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustivel consumida (litros): ");
decimal combustivelConsumido = Convert.ToDecimal(Console.ReadLine());

decimal distanciaPercorrida = kmFinal = kmInicial;

decimal consumoPorKm = distanciaPercorrida / combustivelConsumido;

Console.WriteLine($"O consumo de combustivel durante o percusso foi de ~: {consumoPorKm} km/");

Console.ReadLine();


