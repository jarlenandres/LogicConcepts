using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

Console.WriteLine("Este programa ordena tres números de mayor a menor");
Console.WriteLine();
do
{
    var num1 = ConsoleExtension.GetInt("Ingrese primer número ");
    var num2 = ConsoleExtension.GetInt("Ingrese segundo número ");
    var num3 = ConsoleExtension.GetInt("Ingrese segundo número ");

    if (num1 == num2 || num1 == num3 || num2 == num3)
    {
        Console.WriteLine("Los números deben diferentes, vuelve a empezar");
        Console.WriteLine();
        continue;
    }
    if (num1 > num2 && num1 > num3)
    {
        if (num2 > num3)
        {
            Console.WriteLine($"El orden es {num1}, {num2}, {num3}");
        }
        else
        {
            Console.WriteLine($"El orden es {num1}, {num3}, {num2}");
        }
    }
    else if (num2 > num1 && num2 > num3)
    {
        if (num1 > num3)
        {
            Console.WriteLine($"El orden es {num2}, {num1}, {num3}");
        }
        else
        {
            Console.WriteLine($"El orden es {num2}, {num3}, {num1}");
        }
    }
    else
    {
        Console.WriteLine($"El orden es {num3}, {num2}, {num1}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hasta la próxima!");