Coche.MiMetodo();
Coche? miCoche = new Coche();
miCoche.Marca = "Seat";
miCoche.Modelo = "Toledo";
miCoche.Anio = 2007;
miCoche.Color = "verde";
Coche? miOtroCoche = new Coche();
Coche tercerCoche = new Coche("Ford","fiesta",1985,"blanco");
Console.WriteLine("Mi primer coche es un {0} {1} de color {2} fabricado en {3}.",
miCoche.Marca,
miCoche.Modelo,
miCoche.Color,
miCoche.Anio);
Console.WriteLine("Mi otro coche es de la marca {0}.",
miOtroCoche.Marca);
Console.WriteLine("Mi tercer coche es un {0} {1} {2} del año {3}.",
tercerCoche.Marca,
tercerCoche.Modelo,
tercerCoche.Color,
tercerCoche.Anio);
class Coche
{
	public string? Marca { get; set; }
	public string? Modelo { get; set; }
	public int Anio { get; set; }
	public string? Color { get; set; }
	public Coche()
	{
		Marca = "Nissan";
	}
	public Coche(string marca, string modelo, int anio, string color){
Marca = marca;
Modelo = modelo;
Anio = anio;
Color = color;
	}
	public decimal DeterminarValorDemercado()
	{
		decimal valor;
		if (Anio >= 1990)
		{
			valor = 10000;
		}
		else
		{
			valor = 2000;
		}
		return valor;
	}
	public static void MiMetodo(){
		Console.WriteLine("Aquí se fabrican los coches.");
	}
}