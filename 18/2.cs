void EvaluarTareas(List<Tarea> tareas){
	foreach (var tarea in tareas)
	{
		switch (tarea.Estado)
		{
			case Estado.SinEmpezar:
			Console.Write("Deberías ponerte con ");
			break;
			case Estado.EnProgreso:
			Console.Write("Sigue trabajando en ");
			break;
			case Estado.EnEspera:
			Console.Write("Esperando para hacer ");
			break;
			case Estado.Completada:
			Console.Write("Has terminado ");
			break;
			case Estado.Eliminada:
			Console.Write("Ya no hay que hacer ");
			break;
			default:
			break;
		}
	Console.WriteLine(tarea.Descripcion+".");
	}
}

List<Tarea> tareas = new List<Tarea>(){
	new Tarea() {Descripcion="Tarea 1",HorasEstimadas=6,Estado=Estado.Completada},
	new Tarea() {Descripcion="Tarea 2",HorasEstimadas=8,Estado=Estado.EnProgreso},
	new Tarea() {Descripcion="Tarea 3",HorasEstimadas=6,Estado=Estado.SinEmpezar},
	new Tarea() {Descripcion="Tarea 4",HorasEstimadas=12,Estado=Estado.Eliminada},
	new Tarea() {Descripcion="Tarea 5",HorasEstimadas=8,Estado=Estado.EnProgreso},
	new Tarea() {Descripcion="Tarea 6",HorasEstimadas=14,Estado=Estado.SinEmpezar},
	new Tarea() {Descripcion="Tarea 7",HorasEstimadas=4,Estado=Estado.EnProgreso},
	new Tarea() {Descripcion="Tarea 8",HorasEstimadas=8,Estado=Estado.Completada},
	new Tarea() {Descripcion="Tarea 9",HorasEstimadas=16,Estado=Estado.Completada},
	new Tarea() {Descripcion="Tarea 10",HorasEstimadas=10,Estado=Estado.SinEmpezar},
	new Tarea() {Descripcion="Tarea 11",HorasEstimadas=12,Estado=Estado.Eliminada},
	new Tarea(){Descripcion="Tarea 12",HorasEstimadas=6,Estado=Estado.SinEmpezar}
};

EvaluarTareas(tareas);

enum Estado
{
	SinEmpezar,
	EnProgreso,
	EnEspera,
	Completada,
	Eliminada
};

class Tarea
{
	public string? Descripcion { get; set; }
	public int HorasEstimadas { get; set; }
	public Estado Estado { get; set; }
}