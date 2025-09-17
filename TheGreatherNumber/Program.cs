using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
Console.WriteLine("Programa para determinar el número mayor entre tres números.");
Console.WriteLine();
do
{
    var n1 = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var n2 = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    var n3 = ConsoleExtension.GetInt("Ingrese el tercer número: ");

    if (n1 > n2 && n1 > n3)
    {
        Console.WriteLine($"El número mayor es {n1}");
    }
    else if (n2 > n1 && n2 > n3)
    {
        Console.WriteLine($"El número mayor es {n2}");
    }
    else if (n3 > n1 && n3 > n2)
    {
        Console.WriteLine($"El número mayor es {n3}");
    }
    else
    {
        Console.WriteLine("Hay números iguales");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hasta la próxima!");