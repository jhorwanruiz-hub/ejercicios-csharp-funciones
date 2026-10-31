string cliente;
double sub_total;
bool esFrecuente;


Console.WriteLine("Escriba su nombre:");
cliente = Console.ReadLine();

Console.WriteLine("Digite el subtotal:");
sub_total = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Eres frecuente? (true/false)");
esFrecuente = Convert.ToBoolean(Console.ReadLine());

double totalFinal = CalcularTotal(sub_total, esFrecuente);

static double CalcularTotal(double sub_total, bool esFrecuente)
{
    if (esFrecuente)
    {
        sub_total = sub_total - (sub_total * 0.10);
    }

    return sub_total * 1.18;

}

static void MostrarFactura(string cliente, double sub_total)
{
    Console.WriteLine("FACTURA");
    Console.WriteLine("CLIENTE: " + cliente);
    Console.WriteLine("TOTAL: " + sub_total);
}

MostrarFactura(cliente, totalFinal);