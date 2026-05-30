using C_GlobalSolution_SpaceGuard.Models;
using C_GlobalSolution_SpaceGuard.Partials;
using C_GlobalSolution_SpaceGuard.Services;
using C_GlobalSolution_SpaceGuard.Structs;
using C_GlobalSolution_SpaceGuard.Utils;

List<Alerta> alertas = new();
List<Satelite> satelites = new();
List<Sensor> sensores = new();

bool executando = true;

while (executando)
{
    ConsoleHelper.ExibirTitulo("SPACEGUARD - Monitoramento Ambiental");

    Console.WriteLine("1 - Cadastrar Satélite");
    Console.WriteLine("2 - Listar Satélites");
    Console.WriteLine("3 - Cadastrar Sensor");
    Console.WriteLine("4 - Listar Sensores");
    Console.WriteLine("5 - Registrar Alerta de Incêndio");
    Console.WriteLine("6 - Registrar Alerta de Enchente");
    Console.WriteLine("7 - Listar Alertas");
    Console.WriteLine("8 - Gerar Relatório");
    Console.WriteLine("0 - Sair");

    Console.Write("\nEscolha uma opção: ");
    string? opcao = Console.ReadLine();

    try
    {
        switch (opcao)
        {
            case "1":
                CadastrarSatelite(satelites);
                break;

            case "2":
                ListarSatelites(satelites);
                break;

            case "3":
                CadastrarSensor(sensores);
                break;

            case "4":
                ListarSensores(sensores);
                break;

            case "5":
                RegistrarAlertaIncendio(alertas);
                break;

            case "6":
                RegistrarAlertaEnchente(alertas);
                break;

            case "7":
                ListarAlertas(alertas);
                break;

            case "8":
                GerarRelatorio(alertas);
                break;

            case "0":
                executando = false;
                Console.WriteLine("Sistema encerrado com segurança.");
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Digite apenas números válidos.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Erro de validação: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro inesperado: {ex.Message}");
    }

    if (executando)
    {
        ConsoleHelper.Pausar();
    }
}

static void CadastrarSatelite(List<Satelite> satelites)
{
    Console.Write("Nome do satélite: ");
    string nome = Console.ReadLine() ?? "";

    Console.Write("Agência responsável: ");
    string agencia = Console.ReadLine() ?? "";

    Satelite satelite = new(nome, agencia);
    satelites.Add(satelite);

    Console.WriteLine("Satélite cadastrado com sucesso.");
}

static void ListarSatelites(List<Satelite> satelites)
{
    Console.WriteLine("\nSATÉLITES CADASTRADOS");

    if (satelites.Count == 0)
    {
        Console.WriteLine("Nenhum satélite cadastrado.");
        return;
    }

    foreach (Satelite satelite in satelites)
    {
        satelite.ExibirInformacoes();
        Console.WriteLine("------------------------");
    }
}

static void CadastrarSensor(List<Sensor> sensores)
{
    Console.Write("Nome do sensor: ");
    string nome = Console.ReadLine() ?? "";

    Console.Write("Tipo do sensor: ");
    string tipo = Console.ReadLine() ?? "";

    Sensor sensor = new(nome, tipo);
    sensores.Add(sensor);

    MonitoramentoService monitoramento = new(sensor);
    monitoramento.IniciarMonitoramento();

    Console.WriteLine("Sensor cadastrado com sucesso.");
}

static void ListarSensores(List<Sensor> sensores)
{
    Console.WriteLine("\nSENSORES CADASTRADOS");

    if (sensores.Count == 0)
    {
        Console.WriteLine("Nenhum sensor cadastrado.");
        return;
    }

    foreach (Sensor sensor in sensores)
    {
        Console.WriteLine($"Nome: {sensor.Nome}");
        Console.WriteLine($"Tipo: {sensor.Tipo}");
        Console.WriteLine("------------------------");
    }
}

static void RegistrarAlertaIncendio(List<Alerta> alertas)
{
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine() ?? "";

    Console.Write("Nível de risco (1-5): ");
    int nivelRisco = Convert.ToInt32(Console.ReadLine());

    Coordenada coordenada = LerCoordenada();

    AlertaIncendio alerta = new(descricao, nivelRisco, coordenada);
    alertas.Add(alerta);

    Console.WriteLine("Alerta de incêndio registrado com sucesso.");
}

static void RegistrarAlertaEnchente(List<Alerta> alertas)
{
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine() ?? "";

    Console.Write("Nível de risco (1-5): ");
    int nivelRisco = Convert.ToInt32(Console.ReadLine());

    Coordenada coordenada = LerCoordenada();

    AlertaEnchente alerta = new(descricao, nivelRisco, coordenada);
    alertas.Add(alerta);

    Console.WriteLine("Alerta de enchente registrado com sucesso.");
}

static Coordenada LerCoordenada()
{
    Console.Write("Latitude: ");
    double latitude = Convert.ToDouble(Console.ReadLine());

    Console.Write("Longitude: ");
    double longitude = Convert.ToDouble(Console.ReadLine());

    return new Coordenada(latitude, longitude);
}

static void ListarAlertas(List<Alerta> alertas)
{
    Console.WriteLine("\nALERTAS REGISTRADOS");

    if (alertas.Count == 0)
    {
        Console.WriteLine("Nenhum alerta cadastrado.");
        return;
    }

    foreach (Alerta alerta in alertas)
    {
        alerta.ExibirDetalhes();
        Console.WriteLine("------------------------");
    }
}

static void GerarRelatorio(List<Alerta> alertas)
{
    Relatorio relatorio = new();

    relatorio.GerarResumo(alertas);
    relatorio.ExibirHistorico(alertas);
}