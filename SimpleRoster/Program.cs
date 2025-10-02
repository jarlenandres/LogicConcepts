using Calculate;
using Shared;

Console.WriteLine("### Programa de una nómina sencilla###");
Console.WriteLine();
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var name = CalculateSalary.GetName("Ingrese el nombre del empleado: ");
    var hours = CalculateSalary.GetHours("Ingrese número de hora trabajadas: ");
    var hourValue = CalculateSalary.GetHourValue("Ingrese valor hora: ");
    var minimunSalary = CalculateSalary.GetMinimunSalary("Ingrese valor salario mínimo mensual: ");
    var salary = (decimal)hours * hourValue;
    if (salary < minimunSalary)
    {
        Console.WriteLine($"Empleado.....: {name}");
        Console.WriteLine($"Salario......: {minimunSalary:C2}");
    }
    else
    {
        Console.WriteLine($"Empleado.....: {name}");
        Console.WriteLine($"Salario......: {salary:C2}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Hasta la próxima!");
