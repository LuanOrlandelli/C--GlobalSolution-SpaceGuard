using C_GlobalSolution_SpaceGuard.Structs;

namespace C_GlobalSolution_SpaceGuard.Models;

public class AlertaIncendio : Alerta
{
    public AlertaIncendio(string descricao, int nivelRisco, Coordenada localizacao)
        : base(descricao, nivelRisco, localizacao)
    {
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine("ALERTA DE INCÊNDIO");
        base.ExibirDetalhes();
        Console.WriteLine("Ação recomendada: Monitorar foco de calor.");
    }
}