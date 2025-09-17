using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
Console.WriteLine("Programa para determinar si un número es par o impar.");
Console.WriteLine();
do
{
    var number = ConsoleExtension.GetInt("Ingrese un número entero: ");
    if (number % 2 == 0)
    {
        Console.WriteLine($"El número, {number} es par");
    }
    else
    {
        Console.WriteLine($"El número {number} es impar");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hasta la próxima!");