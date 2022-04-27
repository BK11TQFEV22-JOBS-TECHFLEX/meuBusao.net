namespace ControleFrota.Entidades.Abstracoes;

public abstract class Pessoa 
{
    protected Pessoa(string nome, string cpf)
    {
        Nome = nome;
        Cpf = cpf;
    }

    public string Nome { get; }

    public string Cpf { get; }

    public abstract string GetTipo();

    public override string ToString()
    {
        return GetTipo() + " [nome=" + Nome + ", cpf=" + Cpf + "]";
    }
}