Coche coche1 = new Coche();
coche1.Marca="Seat";
coche1.Modelo="Ibiza";
coche1.Matricula="1234ABC";
Coche coche2 =new Coche();
coche2.Marca="Fiat";
coche2.Modelo="500";
coche2.Matricula="2345DEF";
Libro libro1 = new Libro();
libro1.Titulo="el Lazarillo de Tormes";
libro1.Autor="Anónimo";
libro1.Isbn="0-000-0000-0";

List<Coche> lista = new List<Coche>();
lista.Add(coche1);
lista.Add(coche2);
foreach (Coche coche in lista)
{
	Console.WriteLine(coche.Marca);
}

Dictionary<string,Coche> miDiccionario = new Dictionary<string, Coche>();
miDiccionario.Add(coche1.Matricula,coche1);
miDiccionario.Add(coche2.Matricula,coche2);


class Coche{
	public string? Marca { get; set; }
	public string? Modelo { get; set; }
	public string? Matricula { get; set; }
}
class Libro{
	public string? Titulo { get; set; }
	public string? Autor { get; set; }
	public string? Isbn { get; set; }
}