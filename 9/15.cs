string miCadena = "    En un lugar de la Mancha     ";
miCadena = string.Format("Antes había {0} caracteres y hora hay {1} caracteres.",
miCadena.Length,
miCadena.Trim().Length);
Console.WriteLine(miCadena);