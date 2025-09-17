var num1 = string.Empty;
var num2 = string.Empty;
var num3 = string.Empty;
var t = string.Empty;
do
{
    Console.Write("Ingrese primer número ");
    num1 = Console.ReadLine();
    Console.Write("Ingrese tercer número ");
    num2 = Console.ReadLine();
    Console.Write("Ingrese segundo número ");
    num3 = Console.ReadLine();
    var n1 = 0;
    var n2 = 0;
    var n3 = 0;

    if (int.TryParse(num1, out n1) && int.TryParse(num2, out n2) && int.TryParse(num3, out n3))
    {
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
    }
    Console.WriteLine("Desea continuar 'S' o 'N' ");
    t = Console.ReadLine();

    if (t.ToLower() == "n")
    {
        continue;
    }
} while (t!.ToLower() != "n");
Console.WriteLine("Hasta la próxima!");