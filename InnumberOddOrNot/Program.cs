using Shared;

var answer = string.Empty;
do
{
    var number = ConsoleExtension.GetInt("Ingrese número entero: ");
    if (number % 2 == 0)
    {
        Console.WriteLine($"El número {number}, es par.");
    }
    else
    {
        Console.WriteLine($"El número {number}, es impar");
    }
    answer = ConsoleExtension.GetValidOptions("¿Desea continuar [S]í, [N]o?", new List<string> { "s", "n" });
}
while (answer.ToLower() == "s");