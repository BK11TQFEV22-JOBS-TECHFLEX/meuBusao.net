using ControleFrota.Entidades;

Motorista seuJuarez = new Motorista("Juarez", 1234567, "A1B2C3D4");
Carro fusca = new Carro("BKF1234", 7755443, seuJuarez);

Console.WriteLine("PASSAGEIRO: Motorista, acelera o carro até 100Km/h!");
Console.WriteLine("MOTORISTA: Ok! Vamos lá!");
fusca.Motorista.Acelerar(100);

Console.WriteLine($"Velocidade do carro: {fusca.VelocidadeAtual} Km/h\n");
