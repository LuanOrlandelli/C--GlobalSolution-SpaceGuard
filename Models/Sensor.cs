using C_GlobalSolution_SpaceGuard.Interfaces;

namespace C_GlobalSolution_SpaceGuard.Models;

public class Sensor : IMonitoravel
{
    public string Nome { get; private set; }
    public string Tipo { get; private set; }

    public Sensor(string nome, string tipo)
    {
        Nome = nome;
        Tipo = tipo;
    }

    public void Monitorar()
    {
        Console.WriteLine($"Sensor {Nome} ({Tipo}) monitorando ambiente.");
    }
}