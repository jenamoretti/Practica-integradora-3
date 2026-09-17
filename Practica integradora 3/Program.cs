using System;
using System.Collections.Generic;

namespace Practica_integradora_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    List<Alumno> alumnos = new List<Alumno>();
            //    int opcion = 0;

            //    do
            //    {
            //        Console.WriteLine("\n=== MENÚ DE GESTIÓN DE ALUMNOS ===");
            //        Console.WriteLine("1. Agregar un alumno");
            //        Console.WriteLine("2. Listar todos los alumnos");
            //        Console.WriteLine("3. Buscar un alumno por legajo");
            //        Console.WriteLine("4. Mostrar el promedio general del curso");
            //        Console.WriteLine("5. Mostrar cuántos alumnos están aprobados");
            //        Console.WriteLine("6. Salir");
            //        Console.Write("Seleccione una opción: ");

            //        if (!int.TryParse(Console.ReadLine(), out opcion))
            //        {
            //            opcion = 0;
            //        }

            //        Console.WriteLine();

            //        switch (opcion)
            //        {
            //            case 1:
            //                AgregarAlumno(alumnos);
            //                break;

            //            case 2:
            //                ListarAlumnos(alumnos);
            //                break;

            //            case 3:
            //                BuscarAlumno(alumnos);
            //                break;

            //            case 4:
            //                MostrarPromedioGeneral(alumnos);
            //                break;

            //            case 5:
            //                MostrarAprobados(alumnos);
            //                break;

            //            case 6:
            //                Console.WriteLine("¡Gracias por utilizar el sistema! Saliendo...");
            //                break;

            //            default:
            //                Console.WriteLine("Opción inexistente. Por favor, intente nuevamente.");
            //                break;
            //        }

            //    } while (opcion != 6);
            //}

            //static void AgregarAlumno(List<Alumno> alumnos)
            //{
            //    Console.WriteLine("--- AGREGAR ALUMNO ---");

            //    Console.Write("Ingrese el nombre: ");
            //    string nombre = Console.ReadLine();

            //    Console.Write("Ingrese el legajo: ");
            //    int legajo;
            //    while (!int.TryParse(Console.ReadLine(), out legajo))
            //    {
            //        Console.Write("Legajo inválido.");
            //    }

            //    Alumno nuevoAlumno = new Alumno(nombre, legajo);

            //    bool notasValidas = false;
            //    while (!notasValidas)
            //    {
            //        Console.Write("Ingrese la Nota 1: ");
            //        double nota1;
            //        while (!double.TryParse(Console.ReadLine(), out nota1))
            //        {
            //            Console.Write("Nota inválida.");
            //        }

            //        Console.Write("Ingrese la Nota 2: ");
            //        double nota2;
            //        while (!double.TryParse(Console.ReadLine(), out nota2))
            //        {
            //            Console.Write("Nota inválida.");
            //        }

            //        notasValidas = nuevoAlumno.CargarNotas(nota1, nota2);

            //        if (!notasValidas)
            //        {
            //            Console.WriteLine("Las notas no pueden ser mayores a 10.\n");
            //        }
            //    }

            //    alumnos.Add(nuevoAlumno);
            //    Console.WriteLine("¡Alumno agregado correctamente!");
            //}

            //static void ListarAlumnos(List<Alumno> alumnos)
            //{
            //    Console.WriteLine("--- LISTA DE ALUMNOS ---");
            //    if (alumnos.Count == 0)
            //    {
            //        Console.WriteLine("No hay alumnos registrados.");
            //        return;
            //    }

            //    foreach (var alumno in alumnos)
            //    {
            //        Console.WriteLine(alumno);
            //    }
            //}

            //static void BuscarAlumno(List<Alumno> alumnos)
            //{
            //    Console.WriteLine("--- BUSCAR ALUMNO POR LEGAJO ---");
            //    if (alumnos.Count == 0)
            //    {
            //        Console.WriteLine("No hay alumnos registrados para buscar.");
            //        return;
            //    }

            //    Console.Write("Ingrese el legajo a buscar: ");
            //    int legajoBusqueda;
            //    while (!int.TryParse(Console.ReadLine(), out legajoBusqueda))
            //    {
            //        Console.Write("Legajo inválido.");
            //    }

            //    Alumno alumnoEncontrado = alumnos.Find(a => a.legajo == legajoBusqueda);

            //    if (alumnoEncontrado != null)
            //    {
            //        Console.WriteLine("\nAlumno encontrado:");
            //        Console.WriteLine(alumnoEncontrado);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"\nNo existe ningún alumno registrado con el legajo {legajoBusqueda}.");
            //    }
            //}

            //static void MostrarPromedioGeneral(List<Alumno> alumnos)
            //{
            //    Console.WriteLine("--- PROMEDIO GENERAL DEL CURSO ---");

            //    if (alumnos.Count == 0)
            //    {
            //        Console.WriteLine("No hay alumnos registrados para calcular el promedio general.");
            //        return;
            //    }

            //    float sumaPromedios = 0;
            //    foreach (var alumno in alumnos)
            //    {
            //        sumaPromedios += alumno.CalcularPromedio();
            //    }

            //    float promedioGeneral = sumaPromedios / alumnos.Count;
            //    Console.WriteLine($"El promedio general del curso es: {promedioGeneral:F2}");
            //}

            //static void MostrarAprobados(List<Alumno> alumnos)
            //{
            //    Console.WriteLine("--- ALUMNOS APROBADOS ---");
            //    if (alumnos.Count == 0)
            //    {
            //        Console.WriteLine("No hay alumnos registrados.");
            //        return;
            //    }

            //    int aprobados = 0;
            //    foreach (var alumno in alumnos)
            //    {
            //        if (alumno.EstaAprobado())
            //        {
            //            aprobados++;
            //        }
            //    }

            //    Console.WriteLine($"Cantidad de alumnos aprobados: {aprobados} de {alumnos.Count}");
            //}

            Materia m1 = new Materia("PROG1", "Programación I", 64);
            Materia m2 = new Materia("BD1", "Análisis I", 48);

            Alumno a1 = new Alumno("Ana", 1234);
            a1.CargarNotas(8, 9);

            Profesor p1 = new Profesor("Marta", 5678, "Programación I");

            List<IExportable> listaExportables = new List<IExportable>()
            {
                a1,
                p1,
                m1,
                m2
            };

            foreach (IExportable item in listaExportables)
            {
                Console.WriteLine(item.ExportarLinea());
            }
        }
    }
}