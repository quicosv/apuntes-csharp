try{
	string contenido = File.ReadAllText("ficheros\\archivo.txt");
Console.WriteLine(contenido);
}
catch(Exception ex){
	Console.WriteLine("Ha ocurrido un error. el mensaje dice lo siguiente:");
	Console.WriteLine(ex.Message);
}