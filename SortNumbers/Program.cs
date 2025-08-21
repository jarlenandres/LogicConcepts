var response = string.Empty;
var n1 = string.Empty;
var n2 = string.Empty;
var n3 = string.Empty;

do
{
    Console.WriteLine("### Ordenar tres números de mayo a menor ###");
    Console.WriteLine("Ingrese primer número");
    n1 = Console.ReadLine();
    Console.WriteLine("Ingrese segundo número");
    n2 = Console.ReadLine();
    Console.WriteLine("Ingrese tercer número");
    n3 = Console.ReadLine();
    int num1, num2, num3;
    if (int.TryParse(n1, out num1) && 
        int.TryParse(n2, out num2) &&
        int.TryParse(n3, out num3))
    {
        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Console.WriteLine("Los números deben ser diferentes. Intente de nuevo.");
            continue;
        }
        if (num1 > num2 && num1 > num3)
        {
            if (num2 > num3)
            {
                Console.WriteLine($"Orden: {num1}, {num2}, {num3}");
            }
            else
            {
                Console.WriteLine($"Orden: {num1}, {num3}, {num2}");
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine($"Orden: {num2}, {num1}, {num3}");
            }
            else
            {
                Console.WriteLine($"Orden: {num2}, {num3}, {num1}");
            }
        }
        else
        {
            Console.WriteLine($"Orden: {num3}, {num1}, {num2}");
        }
        Console.WriteLine("¿Desea continuar? Si, No");
        response = Console.ReadLine();
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
}
while (response.ToLower() == "si");