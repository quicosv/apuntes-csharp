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