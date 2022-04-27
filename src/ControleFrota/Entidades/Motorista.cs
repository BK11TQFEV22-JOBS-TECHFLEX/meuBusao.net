namespace ControleFrota.Entidades;

using ControleFrota.Entidades.Abstracoes;

public class Motorista : Pessoa
{
    public Motorista(string nome, int matricula, string cnh, string cpf)
        : base(nome, cpf)
    {
        Matricula = matricula;
        Cnh = cnh;
    }

    public int Matricula { get; }
    public string Cnh { get; }
    public Carro? Veiculo { get; set; }

    public override string GetTipo()
    {
        return "Motorista";
    }

    public override string ToString()
    {
        return base.ToString() + ":[matricula=" + Matricula + ", cnh=" + Cnh + ", carro=" + Veiculo + "]";
    }    

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
}