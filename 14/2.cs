Int64 x;
try
{
	//Abre el archivo
	StreamWriter sw = new StreamWriter("C:\\Test1.txt", true, Encoding.UTF8);

	//Escribe los números del 1 al 10 en la misma línea
	for(x=0; x < 10; x++)
	{
	sw.Write(x);
	}

	//Cierra el archivo
	sw.Close();
}
catch(Exception e)
{
	Console.WriteLine("Excepción: " + e.Message);
}
finally
{
	Console.WriteLine("Ejecutando el bloque finally.");
}