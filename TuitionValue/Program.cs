using Shared;

Console.WriteLine("Programa de Valor de Matrícula");
Console.WriteLine();

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var credits = ConsoleExtension.GetInt("Número de créditos: ");
    var creditsValue = ConsoleExtension.GetDecimal("Valor crédito: ");
    var stratum = ConsoleExtension.GetInt("Estrato del estudiante: ");
    var tuitionValue = CalculateTuitionVale(credits, creditsValue, stratum);
    var subsidy = CalculateSubsidy(stratum);
    Console.WriteLine($"Costo matrícula: {tuitionValue:N2}");
    Console.WriteLine($"Costo matrícula: {subsidy:N2}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculateSubsidy(int stratum)
{
    decimal subsidy = 0;
    if (stratum == 1)
    {
        return subsidy = 200000;
    }
    if (stratum == 2)
    {
        return subsidy = 100000;
    }
    return subsidy;
}

decimal CalculateTuitionVale(int credits, decimal creditsValue, int stratum)
{
    decimal value;
    if (credits <= 20)
    {
        value = credits * creditsValue;
    }
    else
    {
        value = 20 * creditsValue + (credits - 20) * creditsValue * 2m;
    }

    if (stratum == 1)
    {
        return value * 0.2m;
    }
    if (stratum == 2)
    {
        return value * 0.5m;
    }
    if (stratum == 3)
    {
        return value * 0.7m;
    }

    return value;
}