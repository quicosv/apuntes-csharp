Console.WriteLine("¡el gran concurso de Bob!");
Console.Write("Elige una puerta (1 a 3): ");
string eleccionUsuario = Console.ReadLine();
string mensaje = (eleccionUsuario == "1") ? "un barco" : "una hebra de una pelusa";
Console.WriteLine("Has escrito {0}, así que has ganado {1}.", eleccionUsuario, mensaje);