namespace C_GlobalSolution_SpaceGuard.Abstracts;

public abstract class EntidadeEspacial
{
    public string Nome { get; private set; }

    protected EntidadeEspacial(string nome)
    {
        Nome = nome;
    }

    public abstract void ExibirInformacoes();
}