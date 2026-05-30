using C_GlobalSolution_SpaceGuard.Structs;

namespace C_GlobalSolution_SpaceGuard.Models;

public class Alerta
{
    public string Descricao { get; protected set; }
    public int NivelRisco { get; protected set; }
    public DateTime DataRegistro { get; protected set; }
    public Coordenada Localizacao { get; protected set; }

    public Alerta(string descricao, int nivelRisco, Coordenada localizacao)
    {
        if (nivelRisco < 1 || nivelRisco > 5)
        {
            throw new ArgumentException("O nível de risco deve estar entre 1 e 5.");
        }

        Descricao = descricao;
        NivelRisco = nivelRisco;
        Localizacao = localizacao;
        DataRegistro = DateTime.Now;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Descrição: {Descricao}");
        Console.WriteLine($"Nível de risco: {NivelRisco}");
        Console.WriteLine($"Data do registro: {DataRegistro:dd/MM/yyyy HH:mm}");
        Console.WriteLine($"Localização: {Localizacao}");
    }
}