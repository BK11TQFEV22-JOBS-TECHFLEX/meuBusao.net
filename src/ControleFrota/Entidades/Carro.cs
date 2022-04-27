using System.Text.RegularExpressions;

namespace ControleFrota.Entidades;

public class Carro
{
    public Carro(String placa, int chassi, Motorista motorista) 
        : this(chassi, motorista)
    {
        ValidarPlaca(placa);
        Placa = placa;
    }

    public Carro(int chassi, Motorista motorista) {
        ValidarChassi(chassi);

        Chassi = chassi;
        VelocidadeAtual = 0;
        Motorista = motorista;
        Motorista.Veiculo = this;
    }

    public String? Placa { get; }
    public int Chassi { get; }
    public int VelocidadeAtual { get; private set; }
    public Motorista Motorista { get; }

    internal void Acelerar() 
    {
        VelocidadeAtual++;
    }

    internal void Acelerar(int limite) {  
        for (int i = VelocidadeAtual; i < limite; i++) {
            Acelerar();
        }
    }

    public void Frear() {
        VelocidadeAtual--;
    }

    public override string ToString()
    {
        return "Carro [placa=" + Placa + ", chassi=" + Chassi + ", velocidadeAtual=" + VelocidadeAtual + "]";
    }

    private void ValidarPlaca(String placa) 
    {
        Regex regex = new Regex("[A-Z]{3}[0-9]{4}", RegexOptions.IgnoreCase);

        if (placa.Length != 7 || !regex.IsMatch(placa)) {
            throw new ArgumentException("Placa inválida");
        }
    }

    private void ValidarChassi(int chassi)
    {
        if (chassi < 1000000 || chassi > 9999999) {
            throw new ArgumentException("Chassi inválido");
        }
    }    
}
