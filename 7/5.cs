static void InvertirCadena(string mensaje)
{
	char[] arrayMensaje = mensaje.ToCharArray();
	Array.Reverse(arrayMensaje);
	foreach (char elemento in arrayMensaje)
	{
		Console.Write(elemento);
	}
	Console.Write(" ");
}
Console.WriteLine("El juego del nombre");

Console.Write("Tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Tus apellidos: ");
string apellidos = Console.ReadLine();

Console.Write("La ciudad en la que naciste: ");
string ciudad = Console.ReadLine();

InvertirCadena(nombre);
InvertirCadena(apellidos);
InvertirCadena(ciudad);