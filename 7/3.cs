static void InvertirCadena()
{
	string mensaje = "Hola Mundo";
	char[] arrayMensaje = mensaje.ToCharArray();
	Array.Reverse(arrayMensaje);
	foreach (char elemento in arrayMensaje)
	{
		Console.Write(elemento);
	}
}
InvertirCadena();
Console.WriteLine();