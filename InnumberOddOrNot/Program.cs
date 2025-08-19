var numberString = string.Empty;
do
{
    Console.Write("Escribe un número entero o 'salir' para salir ");
    numberString = Console.ReadLine();
    if(numberString!.ToLower() == "salir")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"{numberInt} es par");
        }
        else
        {
            Console.WriteLine($"{numberInt} es impar");
        }

    }
    else
    {
        Console.WriteLine($"{numberString} no es un número entero");
    }
}
while (numberString.ToLower() != "salir");