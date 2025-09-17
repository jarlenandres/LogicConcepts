Console.WriteLine("Este programa valida si un año es Bisiesto");
Console.WriteLine();
var yearString = string.Empty;
var t = string.Empty;
do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    Console.Write("Ingrese un año ");
    yearString = Console.ReadLine();
    var year = 0;

    if (int.TryParse(yearString, out year))
    {
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
    }
    Console.WriteLine("Desea continuar 'S' o 'N' ");
    t = Console.ReadLine();
    if (t.ToLower() == "n")
    {
        continue;
    }
} while (t!.ToLower() != "n");