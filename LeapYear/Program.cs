using Shared;

Console.WriteLine("Este programa valida si un año es Bisiesto");
Console.WriteLine();
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    Console.Write("Ingrese un año ");
    var year = ConsoleExtension.GetInt("Ingrese un año: ");
    if (year == currentYear)
    {
        message = "ES";
    }
    else if (year > currentYear)
    {
        message = "SERÁ";
    }
    else
    {
        message = "FUE";
    }

    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"El año {year} {message} bisiesto");
    }
    else
    {
        Console.WriteLine($"El año {year} NO {message} bisiesto");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hasta la próxima!");