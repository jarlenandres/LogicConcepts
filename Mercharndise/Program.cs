using Shared;
Console.WriteLine("Shipping of Mercharndise");
Console.WriteLine();

var answer = string.Empty;
var isMonday = string.Empty;
var type = string.Empty;
var pay = new List<string> { "e", "t" };
var options = new List<string> { "s", "n" };
do
{
    var weight = ConsoleExtension.GetInt("Peso de la mercancía: ");
    var value = ConsoleExtension.GetDecimal("Valor de la mercancía: ");
    isMonday = ConsoleExtension.GetValidOptions("¿Es lunes? [S]í [N]o: ", options);
    type = ConsoleExtension.GetValidOptions("Tipo de pago [E]fectivo [T]arjeta: ", pay);

    var fee = CalculateFee(weight);
    var discount = CalculateDiscount(value, fee);
    var total = CalculateTotal(fee, isMonday!, type!, value, discount);

    Console.WriteLine($"Tarifa: {fee}");
    if (isMonday == "s" && type == "t")
    {
        Console.WriteLine($"Promoción: {discount}");

    }
    else
    {
        Console.WriteLine($"Descuento: {discount}");
    }
    Console.WriteLine($"Total a pagar: {total}");
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

decimal CalculateDiscount(decimal value, decimal fee)
{
    decimal discount;
    if (value >= 300000 && value <= 600000)
    {
        return discount = fee * 0.10m;
    }
    if (value > 600000 && value <= 1000000)
    {
        return discount = fee * 0.20m;
    }
    if (value > 1000000)
    {
        return discount = fee * 0.30m;
    }
    return 0m;
}

decimal CalculateTotal(decimal fee, string isMonday, string type, decimal value, decimal discount)
{
    decimal total = 0m;
    if (isMonday == "s" && type == "t")
    {
        total = fee * 0.50m;
        return total;
    }
    if (type == "e" && value > 1000000)
    {
        total = fee * 0.40m;
        return total;
    }
    else
    {
        total = fee - discount;
        return total;
    }
}
