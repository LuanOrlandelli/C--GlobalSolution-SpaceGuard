using C_GlobalSolution_SpaceGuard.Interfaces;

namespace C_GlobalSolution_SpaceGuard.Services;

public class MonitoramentoService
{
    private readonly IMonitoravel _monitoravel;

    public MonitoramentoService(IMonitoravel monitoravel)
    {
        _monitoravel = monitoravel;
    }

    public void IniciarMonitoramento()
    {
        Console.WriteLine("Iniciando monitoramento...");
        _monitoravel.Monitorar();
    }
}