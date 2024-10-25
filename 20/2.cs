using System.Timers;

System.Timers.Timer miCronometro = new System.Timers.Timer(2000);
miCronometro.Elapsed += TiempoTranscurrido;
miCronometro.Start();
Console.ReadLine();
void TiempoTranscurrido(object? sender, ElapsedEventArgs e)
{
	Console.WriteLine("{0:HH:mm:ss.fff}.", e.SignalTime);
}