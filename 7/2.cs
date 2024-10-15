Console.WriteLine("El juego del nombre");

Console.Write("Tu nombre: ");
string nombre = Console.ReadLine();

Console.Write("Tus apellidos: ");
string apellidos = Console.ReadLine();

Console.Write("La ciudad en la que naciste: ");
string ciudad = Console.ReadLine();

char[] arrayNomre = nombre.ToCharArray();
Array.Reverse(arrayNomre);
char[] arrayApellidos = apellidos.ToCharArray();
Array.Reverse(arrayApellidos);

char[] arrayCiudad = ciudad.ToCharArray();
Array.Reverse(arrayCiudad);

string resultado = "";

foreach (char elemento in arrayNomre)
{
resultado += elemento;
}

resultado += " ";
foreach (char elemento in arrayApellidos)
{
resultado += elemento;
}

resultado += " ";

foreach (char elemento in arrayCiudad)
{
resultado += elemento;
}
Console.WriteLine("Resultados: " + resultado);