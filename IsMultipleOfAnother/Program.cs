var num1 = string.Empty;
var num2 = string.Empty;
var t = string.Empty;
Console.WriteLine("Este programa valida si un número es multiplo de otro");
Console.WriteLine();
do
{
    Console.Write("Ingrese primer número ");
    num1 = Console.ReadLine();
    Console.Write("Ingrese segundo número ");
    num2 = Console.ReadLine();
    var n1 = 0;
    var n2 = 0;
    if (int.TryParse(num1, out n1) && int.TryParse(num2, out n2))
    {
        if (n2 % n1 == 0)
        {
            Console.WriteLine($"{n1} es múltiplo de {n2}");
        }
        else
        {
            Console.WriteLine($"{n1} no es múltiplo de {n2}");
        }
    }
    Console.WriteLine("Desea continuar 'S' o 'N' ");
    t = Console.ReadLine();

    if (t.ToLower() == "n")
    {
        continue;
    }
} while (t!.ToLower() != "n");
Console.WriteLine("Hasta la próxima!");