var numberOne = string.Empty;
var numberTwo = string.Empty;
var response = string.Empty;

do
{
    Console.Write("Ingrese primer número: ");
    numberOne = Console.ReadLine();
    Console.Write("Ingrese segundo número: ");
    numberTwo = Console.ReadLine();

    if (int.TryParse(numberOne, out int num1) &&
        int.TryParse(numberTwo, out int num2))
    {
        if (num1 % num2 == 0)
        {
            Console.WriteLine($"{num1} es múltiplo de {num2}");
            Console.Write("");
        }
        else
        {
            Console.WriteLine($"{num1} no es múltiplo de {num2}");
            Console.Write("");
        }

        Console.Write("¿Desea continuar? Si, No ");
        response = Console.ReadLine().ToLower();
        if (response.ToLower() == "si")
        {
            continue;
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingrese números válidos.");
        response = "si"; // Forzar continuar si hay error
    }    
} while (response.ToLower() == "si");
