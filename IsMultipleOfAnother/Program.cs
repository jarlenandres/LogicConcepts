using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

Console.WriteLine("Este programa valida si un número es multiplo de otro");
Console.WriteLine();
do
{
    var num1 = ConsoleExtension.GetInt("Ingrese primer número ");
    var num2 = ConsoleExtension.GetInt("Ingrese primer número ");
    if (num2 % num1 == 0)
    {
        Console.WriteLine($"{num1} es múltiplo de {num2}");
    }
    else
    {
        Console.WriteLine($"{num1} no es múltiplo de {num2}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hasta la próxima!");