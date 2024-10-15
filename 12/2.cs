Coche miCoche = new Coche();
miCoche.marca = "Seat";
miCoche.modelo = "Toledo";
miCoche.anio = 2007;
miCoche.color = "verde";
Coche miOtroCoche;
miOtroCoche = miCoche;
Console.WriteLine("Tenemos un {0} {1} de color {2} fabricado en {3}.",
miOtroCoche.marca,
miOtroCoche.modelo,
miOtroCoche.color,
miOtroCoche.anio);
class Coche
{
	public string? marca { get; set; }
	public string? modelo { get; set; }
	public int anio { get; set; }

	public string? color { get; set; }
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