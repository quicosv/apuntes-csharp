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
	Console.Clear();
	Console.WriteLine("Juego de adivinar.");
	Random aleatorio = new Random();
	int adivinar = aleatorio.Next(1, 11);
	int intentos = 0;
	bool incorrecto = true;
	do
	{
		Console.WriteLine("Adivina un número entre 1 y 10.");
		Console.Write("Número: ");
		int resultado = int.Parse(Console.ReadLine());
		intentos++;
		if (resultado == adivinar)
		{
			Console.WriteLine("¡Muy bine!");
			incorrecto = false;
		}
		else
		{
			Console.WriteLine("No, ese número no es.");
		}
	} while (incorrecto);
	Console.WriteLine("Lo has adivinado en {0} intentos.", intentos);
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