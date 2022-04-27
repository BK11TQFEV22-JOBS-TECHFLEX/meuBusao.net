namespace ControleFrota.Entidades;

using ControleFrota.Entidades.Abstracoes;

public sealed class Passageiro : Pessoa
{
    public Passageiro(string nome, string cpf, string codigoCliente)
        : base(nome, cpf)
    {
        CodigoCliente = codigoCliente;
    }

    public string CodigoCliente { get; }

    public override string GetTipo()
    {
        return "Passageiro";
    }
}