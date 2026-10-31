Console.Write("Nombre del cliente: ");
string cliente = Console.ReadLine();

Console.Write("Subtotal de la compra: ");
double subtotal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("¿El cliente es frecuente?");
Console.WriteLine("1. Si");
Console.WriteLine("2. No");
Console.Write("Seleccione una opción: ");
int opcion = Convert.ToInt32(Console.ReadLine());

bool esFrecuente;

if (opcion == 1)
{
    esFrecuente = true;
}
else
{
    esFrecuente = false;
}

double total = CalcularTotal(subtotal, esFrecuente);

MostrarFactura(cliente, total);



static double CalcularTotal(double subtotal, bool esFrecuente)
{
    if (esFrecuente)
    {
        subtotal = subtotal - (subtotal * 0.10);
    }

    double itbis = subtotal * 0.18;
    double total = subtotal + itbis;

    return total;
}

static void MostrarFactura(string cliente, double total)
{
    Console.WriteLine("FACTURA");
    Console.WriteLine("Cliente: " + cliente);
    Console.WriteLine("Total a pagar: RD$ " + total);
}