Coche miCoche = new Coche();
miCoche.marca = "Seat";
miCoche.modelo = "Toledo";
miCoche.anio = 2007;
miCoche.color = "verde";
decimal valor = DeterminarValorDeMercado(miCoche);
Console.WriteLine("Tenemos un {0} {1} {2} fabricado en {3} que vale {4:c}.",
miCoche.marca,
miCoche.modelo,
miCoche.color,
miCoche.anio,
valor);

static decimal DeterminarValorDeMercado(Coche coche)
{
	decimal valor = 15000.00M;
	return valor;
}

class Coche
{
	public string? marca { get; set; }
	public string? modelo { get; set; }
	public int anio { get; set; }
	public string? color { get; set; }
}