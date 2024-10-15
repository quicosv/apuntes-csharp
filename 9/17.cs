using System.Text;

StringBuilder miCadena = new StringBuilder();
for (int i = 0; i < 100; i++)
{
	miCadena.Append("--");
	miCadena.Append(i);
}
Console.WriteLine(miCadena);