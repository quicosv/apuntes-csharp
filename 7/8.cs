static string InvertirCadena(string mensaje)
{
	char[] arrayMensaje = mensaje.ToCharArray();
	Array.Reverse(arrayMensaje);
	return string.Concat(arrayMensaje);
}
static void MostrarResultados(string cadena1, string cadena2, string cadena3)
{
	Console.WriteLine("Resultados: {0} {1} {2}",
cadena1,
cadena2,
cadena3);
}

Console.WriteLine("El juego del nombre");

Console.Write("Tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Tus apellidos: ");
string apellidos = Console.ReadLine();

Console.Write("La ciudad en la que naciste: ");
string ciudad = Console.ReadLine();
MostrarResultados(InvertirCadena(nombre),
InvertirCadena(apellidos),
InvertirCadena(ciudad));