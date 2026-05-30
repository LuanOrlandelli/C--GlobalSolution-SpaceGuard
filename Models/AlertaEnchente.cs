using C_GlobalSolution_SpaceGuard.Structs;

namespace C_GlobalSolution_SpaceGuard.Models;

public class AlertaEnchente : Alerta
{
    public AlertaEnchente(string descricao, int nivelRisco, Coordenada localizacao)
        : base(descricao, nivelRisco, localizacao)
    {
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine("ALERTA DE ENCHENTE");
        base.ExibirDetalhes();
        Console.WriteLine("Ação recomendada: Acionar defesa civil.");
    }
}