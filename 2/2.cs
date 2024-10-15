// Esto imprime en la consola sin cambiar a la siguiente línea
Console.Write("Escribe tu nombre: ");
// Para almacenar una cadena de caracteres
string miNombre;
// Le asignamos lo que el usuario escriba cuando pulse enter
miNombre = Console.ReadLine();
Console.Write("Escribe tus apellidos: ");
string misApellidos;
misApellidos = Console.ReadLine();
// Aquí no se suma sino que se concatena, es decir, se pone una cadena a continuación de la otra
Console.WriteLine("Hola " + miNombre + " " + misApellidos + ".");