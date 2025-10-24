using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
var vr_v = 0;
var typeProduct = new List<string> {"1", "2"};
var typeConservation = new List<string> {"1", "2"};
var storageMedium = new List<string> {"1", "2", "3", "4"};

do
{
    var cc = ConsoleExtension.GetDecimal("Costo de compra: ");
    var tp = string.Empty;
    do
    {
        tp = ConsoleExtension.GetValidOptions("Tipo de producto [1: Perecedero, 2: No Perecedero]: ", typeProduct)!;
    }while (!typeProduct.Any(x => x.Equals(tp, StringComparison.OrdinalIgnoreCase)));

    var tc = string.Empty;
    do
    {
        tc = ConsoleExtension.GetValidOptions("Tipo de conservación [1: Frio, 2: Ambiente]: ", typeConservation)!;
    }
    while (!typeConservation.Any(x => x.Equals(tc, StringComparison.OrdinalIgnoreCase)));

    var pc = ConsoleExtension.GetInt("Periodo de conservación en días: ");
    var pa = ConsoleExtension.GetInt("Periodo de almacenamiento en días: ");
    var vol = ConsoleExtension.GetInt("Volumen en litros: ");
    var ma = string.Empty;
    do
    {
        ma = ConsoleExtension.GetValidOptions("Medio de almacenamiento [1: Nevera, 2: Congelador, 3: Estanteria, 4: Guacal]: ", storageMedium)!;
    } while (!storageMedium.Any(x => x.Equals(ma, StringComparison.OrdinalIgnoreCase)));

    var ca = CalcuteCAProductPerishable(cc, tc, pc, pa);

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? (S/N): ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.OrdinalIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object CalcuteCAProductPerishable(decimal cc, string tc, int pc, int pa)
{
    throw new NotImplementedException();
}
