DateTime valor = DateTime.Now;
Console.WriteLine("Mes de la fecha de hoy: {0}.", valor.Month);
DateTime aniversario = new DateTime(1986,12,29);
Console.WriteLine("Aniversario: {0}.", aniversario.ToShortDateString());
DateTime hispanidad = DateTime.Parse("12/10/2024");
Console.WriteLine("Hispanidad: {0}.", hispanidad.ToShortDateString());
TimeSpan edad = valor.Subtract(aniversario);
Console.WriteLine("Esta persona ha vivido {0} días y, por lo tanto, tiene aproximadamente {1} años.", edad.TotalDays, edad.TotalDays/365);