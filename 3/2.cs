Console.WriteLine("¡el gran concurso de Bob!");
Console.Write("Elige una puerta (1 a 3): ");
string eleccionUsuario = Console.ReadLine();
if (eleccionUsuario=="1")
{
	string mensaje = "¡Has ganado un coche nuevo!";
	Console.WriteLine(mensaje);
}
else if(eleccionUsuario=="2")
{
	string mensaje = "¡Has ganado un barco!";
	Console.WriteLine(mensaje);
}
else if(eleccionUsuario=="3")
{
	string mensaje = "¡Has ganado un gato!";
	Console.WriteLine(mensaje);
}