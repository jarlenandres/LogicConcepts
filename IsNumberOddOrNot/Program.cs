var numString = string.Empty;
do
{
    Console.WriteLine("Ingrese un número entero o 'S' para salir");
    numString = Console.ReadLine();
    if (numString!.ToLower() == "s")
    {
        continue;
    }
    var num = 0;
    if (int.TryParse(numString, out num))
    {
        if (num % 2 == 0)
        {
            Console.WriteLine($"El número, {num} es par");
        }
        else
        {
            Console.WriteLine($"El número {num} es impar");
        }
    }
    else
    {
        Console.WriteLine($"{numString} no es un número entero");
    }
} while (numString!.ToLower() != "s");
Console.WriteLine("Hasta la próxima!");