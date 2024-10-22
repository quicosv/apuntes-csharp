﻿List<Coche> misCoches = new List<Coche>(){
	new Coche() {Matricula="A1",Marca="Fiat",Modelo="500",Precio=55000,Anio=2019},
	new Coche() {Matricula="B2",Marca="Seat",Modelo="Ibiza",Precio=35000,Anio=2010},
	new Coche(){Matricula="C3",Marca="Ford",Modelo="Fiesta",Precio=75000,Anio=2008},
	new Coche() {Matricula="D4",Marca="Seat",Modelo="León",Precio=25000,Anio=2008},
	new Coche(){Matricula="E5",Marca="Renault",Modelo="R5",Precio=57000,Anio=2010}
};

var primero = misCoches.First(p => p.Marca == "Seat");
Console.WriteLine("El primer Seat de la lista es un {0} con matrícula {1}.",
primero.Modelo,
primero.Matricula);
class Coche
{
	public string? Matricula { get; set; }
	public string? Marca { get; set; }
	public string? Modelo { get; set; }
	public int Precio { get; set; }
	public int Anio { get; set; }
}