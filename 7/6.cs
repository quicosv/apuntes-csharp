static string InvertirCadena(string mensaje)
{
	char[] arrayMensaje = mensaje.ToCharArray();
	Array.Reverse(arrayMensaje);
	return string.Concat(arrayMensaje);
}
Console.WriteLine("El juego del nombre");

Console.Write("Tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Tus apellidos: ");
string apellidos = Console.ReadLine();

Console.Write("La ciudad en la que naciste: ");
string ciudad = Console.ReadLine();

string nombreAlReves = InvertirCadena(nombre);
string apellidosAlReves = InvertirCadena(apellidos);
string ciudadAlReves = InvertirCadena(ciudad);
Console.WriteLine("Resultados: {0} {1} {2}",
nombreAlReves,
apellidosAlReves,
ciudadAlReves);