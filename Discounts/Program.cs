using Shared;
using System.Diagnostics;

Console.WriteLine("### Programa de descuentos ###");
Console.WriteLine();
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var quantity = ConsoleExtension.GetInt("Ingrese cantidad de escritorios: ");
    var valueToPay = CalculateValue(quantity);
    Console.WriteLine($"Valor a pagar es..: {valueToPay:N2}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object CalculateValue(int quantity)
{
    float discount;
    if (quantity < 5)
    {
        discount = 0.1f;
    }
    else if (quantity < 10)
    {
        discount = 0.2f;
    }
    else
    {
        discount = 0.4f;
    }
     return quantity * 650000 * (decimal)(1 - discount);
}

Console.WriteLine("Hasta la próxima!");