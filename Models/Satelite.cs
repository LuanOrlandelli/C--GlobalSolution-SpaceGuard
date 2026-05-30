using C_GlobalSolution_SpaceGuard.Abstracts;

namespace C_GlobalSolution_SpaceGuard.Models;

public class Satelite : EntidadeEspacial
{
    public string AgenciaResponsavel { get; private set; }

    public Satelite(string nome, string agenciaResponsavel)
        : base(nome)
    {
        AgenciaResponsavel = agenciaResponsavel;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Satélite: {Nome}");
        Console.WriteLine($"Agência: {AgenciaResponsavel}");
    }
}