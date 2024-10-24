try
{
	string contenido = File.ReadAllText("ficheros\\archivo.txt");
	Console.WriteLine(contenido);
}
catch (FileNotFoundException)
{
	Console.WriteLine("No encuentro ningún archivo con ese nombre. Asegúrate de escribirlo bien.");
}
catch (DirectoryNotFoundException)
{
	Console.WriteLine("Esa carpeta no existe. Comprueba bien la ruta de tu archivo.");
}
catch (Exception ex)
{
	Console.WriteLine("Ha ocurrido un error. el mensaje dice lo siguiente:");
	Console.WriteLine(ex.Message);
}