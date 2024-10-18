using System.Net;

namespace MiBiblioteca;

public class Arreglo
{
	public string fuenteWeb(string url)
	{
		WebClient cliente = new WebClient();
		return cliente.DownloadString(url);
	}
	public string fuenteWeb(string url, String ruta)
	{
		WebClient cliente = new WebClient();
		string respuesta = cliente.DownloadString(url);
		File.WriteAllText(ruta, respuesta);
		return respuesta;
	}
}
