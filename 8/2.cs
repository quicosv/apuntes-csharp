static void ImprimirNumeros()
{
	Console.WriteLine("Imprime números.");
}

static void Adivinar()
{
	Console.WriteLine("Juego de adivinar.");
}

static void MenuPrincipal()
{
	Console.WriteLine("Escoge una opción:");
	Console.WriteLine("1. Opción 1.");
	Console.WriteLine("2. Opción 2.");
	Console.WriteLine("3. Salir.");
	string resultado = Console.ReadLine();
	if (resultado == "1")
	{
		ImprimirNumeros();
	}
	else if (resultado == "2")
	{
		Adivinar();
	}
	else if (resultado == "3")
	{
		// Código para salir
	}
}
MenuPrincipal();