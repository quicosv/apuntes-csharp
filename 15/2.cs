using System.Net;

namespace MiBiblioteca;

public class Arreglo
{
	public string fuenteWeb(string url)
	{
		return obtenerFuente(url);
	}
	public string fuenteWeb(string url, String ruta)
	{
		string respuesta = obtenerFuente(url);
		File.WriteAllText(ruta, respuesta);
		return respuesta;
	}
	private string obtenerFuente(string url)
	{
		WebClient cliente = new WebClient();
		return cliente.DownloadString(url);
	}
}
