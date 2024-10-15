string cita = "Puedes obtener lo que quieras de la vida si ayudas a los demás a obtener lo que quieren";
char[] caracteres = cita.ToCharArray();
Array.Reverse(caracteres);
foreach (string caracter in caracteres)
{
	Console.Write(caracter);
}
Console.WriteLine("");