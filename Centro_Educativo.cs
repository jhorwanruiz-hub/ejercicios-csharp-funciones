string nombre;
string apellido;
string clave;
Console.WriteLine("centro educativo");

Console.WriteLine("Ingrese su nombre: ");
nombre= Console.ReadLine();
Console.WriteLine("Ingrese su apellido: ");
apellido= Console.ReadLine();
Console.WriteLine("Ingrese su clave: ");
clave= Console.ReadLine();


static string generarUsuario (string nombre, string apellido)

    {
    return nombre.Substring(0, 1).ToLower() + apellido.ToLower();
}


static bool claveValida(string clave, string usuario)
{
    return clave.Length >= 8 && !clave.Contains(usuario);
}

static void MostrarCueta(string usuario, bool valida)
{
    Console.WriteLine("Usuario es: "+ usuario);
    Console.WriteLine("Claver es valida: "+ valida);
}

string usuarioGenerado = generarUsuario(nombre, apellido);
bool claveEs= claveValida(clave, usuarioGenerado);
MostrarCueta(usuarioGenerado, claveEs);


