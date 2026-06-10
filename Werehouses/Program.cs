using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var CC = ConsoleExtension.GetDecimal("Costo de compra...: ");
    var TP = ConsoleExtension.GetValidOptions("Tipo de producto [P]erecedero, [N]o perecedero...: ", ["p", "n"]);

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

