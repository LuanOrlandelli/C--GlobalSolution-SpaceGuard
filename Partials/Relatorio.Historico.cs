using C_GlobalSolution_SpaceGuard.Models;

namespace C_GlobalSolution_SpaceGuard.Partials;

public partial class Relatorio
{
    public void ExibirHistorico(List<Alerta> alertas)
    {
        Console.WriteLine("\nHistórico de alertas:");

        if (alertas.Count == 0)
        {
            Console.WriteLine("Nenhum alerta registrado.");
            return;
        }

        foreach (Alerta alerta in alertas)
        {
            Console.WriteLine($"{alerta.DataRegistro:dd/MM/yyyy HH:mm} - {alerta.Descricao} - Risco {alerta.NivelRisco}");
        }
    }
}