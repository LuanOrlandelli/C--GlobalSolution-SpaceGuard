using C_GlobalSolution_SpaceGuard.Models;

namespace C_GlobalSolution_SpaceGuard.Partials;

public partial class Relatorio
{
    public void GerarResumo(List<Alerta> alertas)
    {
        Console.WriteLine("RELATÓRIO SPACEGUARD");
        Console.WriteLine($"Total de alertas registrados: {alertas.Count}");
        Console.WriteLine($"Data de geração: {DateTime.Now:dd/MM/yyyy HH:mm}");
    }
}