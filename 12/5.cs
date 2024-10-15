Coche? miCoche = new Coche();
miCoche.marca = "Seat";
miCoche.modelo = "Toledo";
miCoche.anio = 2007;
miCoche.color = "verde";
Coche? miOtroCoche = new Coche();
Console.WriteLine("Mi coche original es un {0} {1} de color {2} fabricado en {3}.",
miCoche.marca,
miCoche.modelo,
miCoche.color,
miCoche.anio);
Console.WriteLine("Mi otro coche es de la marca {0}.",
miOtroCoche.marca);
class Coche
{
	public string? marca { get; set; }
	public string? modelo { get; set; }
	public int anio { get; set; }

	public string? color { get; set; }
	public Coche()
	{
		marca = "Nissan";
	}
	public decimal DeterminarValorDemercado()
	{
		decimal valor;
		if (anio >= 1990)
		{
			valor = 10000;
		}
		else
		{
			valor = 2000;
		}
		return valor;
	}
}