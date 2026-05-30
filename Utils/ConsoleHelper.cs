namespace C_GlobalSolution_SpaceGuard.Utils;

public static class ConsoleHelper
{
    public static void ExibirTitulo(string titulo)
    {
        Console.Clear();

        Console.WriteLine("=========================================");
        Console.WriteLine(titulo);
        Console.WriteLine("=========================================");
        Console.WriteLine();
    }

    public static void Pausar()
    {
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}