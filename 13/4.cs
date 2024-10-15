Coche? miCoche = new Coche();
miCoche.HacerAlgo();

class Coche
{
	public void HacerAlgo()
	{
		Console.WriteLine(MetodoAuxiliar());
	}
	private string MetodoAuxiliar()
	{
		return "Hola mudno";
	}
}