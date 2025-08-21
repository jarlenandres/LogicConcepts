var response = string.Empty;
var num1 = string.Empty;
var num2 = string.Empty;
var num3 = string.Empty;
do
{
    Console.WriteLine("Ingrese tres números diferentes: ");
    Console.WriteLine("Ingrese el primer número: ");
    num1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo número: ");
    num2 = Console.ReadLine();
    Console.WriteLine("Ingrese el tercer número: ");
    num3 = Console.ReadLine();

    int numberOne, numberTwo, numberThree;
    if (int.TryParse(num1, out numberOne) && 
        int.TryParse(num2, out numberTwo) && 
        int.TryParse(num3, out numberThree))
    {
        if (numberOne > numberTwo && numberOne > numberThree)
        {
            Console.WriteLine($"El número mayor es: {numberOne}");
        }
        else if (numberTwo > numberOne && numberTwo > numberThree)
        {
            Console.WriteLine($"El número mayor es: {numberTwo}");
        }
        else if (numberThree > numberOne && numberThree > numberTwo)
        {
            Console.WriteLine($"El número mayor es: {numberThree}");
        }
        else
        {
            Console.WriteLine($"Los números son iguales");
        }

        Console.WriteLine("¿Desea continuar? Si, No");
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
}
while (response.ToLower() == "si");
