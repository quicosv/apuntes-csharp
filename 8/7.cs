static void ImprimirNumeros()
{
	Console.Clear();
	Console.WriteLine("Imprime números.");
	Console.Write("Escribe un número: ");
	int resultado = int.Parse(Console.ReadLine());
	int contador = 1;
	while (contador < resultado + 1)
	{
		Console.Write(contador);
		Console.Write(" ");
		contador++;
	}
}

static void Adivinar()
{
	Console.WriteLine("Juego de adivinar.");
}

static bool MenuPrincipal()
{
	bool valor = true;
	Console.Clear();
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
		valor = false;
	}
	return valor;
}

bool mostrarMenu = true;

while (mostrarMenu)
{
	mostrarMenu = MenuPrincipal();
}