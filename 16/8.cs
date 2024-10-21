Coche coche1 = new Coche() {Marca="Seat",Modelo="Ibiza",Matricula="1234ABC"};
Coche coche2 = new Coche() {Marca="Fiat",Modelo="500",Matricula="2345BCD"};
Libro libro1 = new Libro() {Titulo="el Lazarillo de Tormes",Autor="Anónimo",Isbn="0-00-0000-0"};
List<Coche> lista = new List<Coche>() {coche1,coche2};
foreach (Coche coche in lista)
{
	Console.WriteLine(coche.Marca);
}

Dictionary<string,Coche> miDiccionario = new Dictionary<string, Coche>();
miDiccionario.Add(coche1.Matricula,coche1);
miDiccionario.Add(coche2.Matricula,coche2);
Console.WriteLine(miDiccionario["1234ABC"].Marca);

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