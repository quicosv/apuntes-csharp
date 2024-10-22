List<Coche> misCoches = new List<Coche>(){
	new Coche() {Matricula="A1",Marca="Fiat",Modelo="500",Precio=55000,Anio=2019},
	new Coche() {Matricula="B2",Marca="Seat",Modelo="Ibiza",Precio=35000,Anio=2010},
	new Coche(){Matricula="C3",Marca="Ford",Modelo="Fiesta",Precio=75000,Anio=2008},
	new Coche() {Matricula="D4",Marca="Seat",Modelo="León",Precio=25000,Anio=2008},
	new Coche(){Matricula="E5",Marca="Renault",Modelo="R5",Precio=57000,Anio=2010}
};

var nacionales = from coche in misCoches
				 where coche.Marca == "Seat"
				 && coche.Anio == 2010
				 select coche;

Console.WriteLine("Con consulta.");
foreach (var coche in nacionales)
{
	Console.WriteLine("{0} {1} con matrícula {2}.",
	coche.Marca,
	coche.Modelo,
	coche.Matricula);
}

class Coche
{
	public string? Matricula { get; set; }
	public string? Marca { get; set; }
	public string? Modelo { get; set; }
	public int Precio { get; set; }
	public int Anio { get; set; }
}