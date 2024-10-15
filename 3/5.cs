Console.WriteLine("¡el gran concurso de Bob!");
Console.Write("Elige una puerta (1 a 3): ");
string eleccionUsuario = Console.ReadLine();
string mensaje = "";
if (eleccionUsuario == "1")
	mensaje = "¡Has ganado un coche nuevo!";
else if (eleccionUsuario == "2")
	mensaje = "¡Has ganado un barco!";
else if (eleccionUsuario == "3")
	mensaje = "¡Has ganado un gato!";
else
	mensaje = "Perdón. No lo hemos entendido.";
mensaje = mensaje + " Has perdido.";
Console.WriteLine(mensaje);