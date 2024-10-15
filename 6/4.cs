string[] nombres = new string[] { "Eduardo", "Alejandro", "Miguel", "David" };
for (int i = 0; i < nombres.Length; i++)
{
	Console.WriteLine(nombres[i]);
}
foreach (string nombre in nombres)
{
	Console.WriteLine(nombre);
}