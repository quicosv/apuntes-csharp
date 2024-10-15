Coche miCoche = new Coche();
miCoche.marca = "Seat";
miCoche.modelo = "Toledo";
miCoche.anio = 2007;
miCoche.color = "verde";
Console.WriteLine("Tenemos un {0} {1} {2} fabricado en {3}.",
miCoche.marca,
miCoche.modelo,
miCoche.color,
miCoche.anio);

class Coche
{
	public string? marca { get; set; }
	public string? modelo { get; set; }
	public int anio { get; set; }
	public string? color { get; set; }
}