Console.Write("### Ver si un año es bisieto ###\n\n");
var response = string.Empty;
do
{
    var currentYear = DateTime.Now.Year;
    var message = string.Empty;
    
    

    Console.Write("Ingrese un año: ");
    var y = Console.ReadLine();
    if (int.TryParse(y, out int year))
    {
        if (year == currentYear)
        {
            message = "es";
        }
        else if (year < currentYear)
        {
            message = "fue";
        }
        else
        {
            message = "será";
        }
        if (year % 4 == 0 && year % 100 != 0 || year % 4 == 0 && year % 100 == 0 && year % 400 == 0)
        {
            Console.WriteLine($"El año {year} {message} bisiesto");
        }
        else
        {
            Console.WriteLine($"El año {year} no {message} bisiesto");
        }

        Console.Write("Desea continuar? Si, No: ");
        response = Console.ReadLine().ToLower();
        if (response.ToLower() == "si")
        {
            continue;
        }
        else if (response.ToLower() != "no")
        {
            Console.WriteLine("Ingresar una respuesta no válida");
            response = "si";
        }
    }
    else
    {
        Console.WriteLine("El valor ingresado no es un año válido");
    }
} while (response.ToLower() == "si");
