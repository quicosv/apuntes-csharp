using System.Timers;

System.Timers.Timer miCronometro = new System.Timers.Timer(2000);
miCronometro.Elapsed += TiempoTranscurrido;

void TiempoTranscurrido(object? sender, ElapsedEventArgs e)
{
	throw new NotImplementedException();
}