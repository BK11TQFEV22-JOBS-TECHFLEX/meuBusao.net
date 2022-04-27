namespace ControleFrota.Entidades;

public class Motorista 
{
    public Motorista(string nome, int matricula, string cnh)
    {
        Nome = nome;
        Matricula = matricula;
        Cnh = cnh;
    }

    public string Nome { get; }
    public int Matricula { get; }
    public string Cnh { get; }
    public Carro? Veiculo { get; set; }

    public void Acelerar() 
    {
        if (Veiculo == null) 
        {
            throw new ArgumentNullException("Motorista não possui carro!");
        }
                
        Veiculo.Acelerar();
    }

    public void Acelerar(int limite) {
        if (Veiculo == null) {
            throw new ArgumentNullException("Motorista não possui carro!");
        }

        Veiculo.Acelerar(limite);
    }

    public override string ToString()
    {
        return "Motorista [nome=" + Nome + ", matricula=" + Matricula + ", cnh=" + Cnh + ", carro=" + Veiculo + "]";
    }
}