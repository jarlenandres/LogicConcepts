var num1 = string.Empty;
var num2 = string.Empty;
var num3 = string.Empty;
var t = string.Empty;
Console.WriteLine("Este programa ordena tres números de mayor a menor");
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
            if (n2 > n3)
            {
                Console.WriteLine($"El orden es {n1}, {n2}, {n3}");
            }
            else
            {
                Console.WriteLine($"El orden es {n1}, {n3}, {n2}");
            }
        }
        else if (n2 > n1 && n2 > n3)
        {
            if (n1 > n3)
            {
                Console.WriteLine($"El orden es {n2}, {n1}, {n3}");
            }
            else
            {
                Console.WriteLine($"El orden es {n2}, {n3}, {n1}");
            }
        }
        else
        {
            Console.WriteLine($"El orden es {n3}, {n2}, {n1}");
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