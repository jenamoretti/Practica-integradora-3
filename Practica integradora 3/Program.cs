using Practica_integradora_3;

Alumno alumno1 = new Alumno("Juan", 12345, 8.5, 7.0);
Alumno alumno2 = new Alumno("María", 67890, 9.0, 8.5);

alumno1.nombre = "Facundo";

Console.WriteLine("Nombre: " + alumno1.nombre + "- Promedio: " + alumno1.CalcularPromedio());
Console.WriteLine("Nombre: " + alumno2.nombre + "- Promedio: " + alumno2.CalcularPromedio());