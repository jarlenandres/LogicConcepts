using Shared;
Console.WriteLine("Shipping of Mercharndise");
Console.WriteLine();

var answer = string.Empty;
string isMonday = string.Empty;
var type = string.Empty;
var pay = new List<string> { "e", "t" };
var options = new List<string> { "s", "n" };
do
{
    var weight = ConsoleExtension.GetInt("Peso de la mercancía: ");
    var value = ConsoleExtension.GetDecimal("Valor de la mercancía: ");

    do
    {
        isMonday = ConsoleExtension.GetValidOptions("¿Es lunes? [S]í [N]o: ", options)!;
    } while (!options.Any(x => x.Equals(isMonday, StringComparison.OrdinalIgnoreCase)));
    
    do
    {
        type = ConsoleExtension.GetValidOptions("Tipo de pago [E]fectivo [T]arjeta: ", pay)!;
    } while (!pay.Any(x => x.Equals(type, StringComparison.OrdinalIgnoreCase)));

    var fee = CalculateFee(weight);
    var discount = CalculateDiscount(value, fee, isMonday!, type!);
    Console.WriteLine($"Tarifa....: {fee}");
    if (isMonday.ToLower() == "s" && type.ToLower() == "t")
    {
        Console.WriteLine($"Promoción....: {discount}");
    }
    else
    {
        Console.WriteLine($"Descuento....: {discount}");
    }
    Console.WriteLine($"Total a pagar....: {fee - discount}");
    do
        {
            answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
        } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculateFee(int weight)
{
    decimal add = 0;
    if (weight < 100)
    {
        return 20000m;
    }
    if (weight >= 100 && weight <= 150)
    {
        return 25000m;
    }
    if (weight > 150 && weight <= 200)
    {
        return 30000m;
    }
    if (weight > 200)
    {
        add = (((weight - 200) / 10) * 2000) + 35000;
        return add;
    }
    return 0m;
}

decimal CalculateDiscount(decimal value, decimal fee, string isMonday, string type)
{
    decimal discount;
    if (value >= 300000 && value <= 600000 && isMonday.ToLower() != "s" && type.ToLower() != "t")
    {
        return discount = fee * 0.10m;
    }
    if (value > 600000 && value <= 1000000 && isMonday.ToLower() != "s" && type.ToLower() != "t")
    {
        return discount = fee * 0.20m;
    }
    if (isMonday.ToLower() == "s" && type.ToLower() == "t")
    {
        return discount = fee / 2m;
    }
    if (type.ToLower() == "e" && value > 1000000)
    {
        return discount = fee * 0.40m;
    }
    if (value > 1000000 && type.ToLower() != "e")
    {
        return discount = fee * 0.30m;
    }
    return 0m;
}

