using System;
using System.Collections.Generic;
using Negocios;
using Entidades;

namespace Vistas
{
    class Escuela
    {
        static N_Alumno negocios = new N_Alumno();
        static List<E_Alumno> listado = listaAlumnos();

        static List<E_Alumno> listaAlumnos()
        {
            List<E_Alumno> alumnos = new List<E_Alumno>();
            alumnos = negocios.N_listaAlumnos();

            return alumnos;
        }

        static void Main(string[] args)
        {
            int opcion = 1;

            Console.WriteLine("BIENVENIDO!");

            while (opcion != 0)
            {
                Console.WriteLine("Que desea hacer? " +
                    "\n1 - Ver lista de alumnos." +
                    "\n2 - Registrar nuevo alumno." +
                    "\n3 - Editar información de un alumno." +
                    "\n4 - Eliminar un alumno." +
                    "\n5 - Ver lista de tutores." +
                    "\n0 - Salir.");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //Recorremos y mostramos cada elemento de la lista
                        foreach (E_Alumno item in listado)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n\n\n\n\n");
                        break;

                    case 2:
                        E_Alumno alumno2 = new E_Alumno();
                        Console.WriteLine("REGISTRANDO NUEVO ALUMNO: ");
                        alumno2.Id = (listado.Count + 1);

                        Console.WriteLine("Nombres: ");
                        alumno2.Nombres = Console.ReadLine();

                        Console.WriteLine("Apellidos: ");
                        alumno2.Apellidos = Console.ReadLine();

                        Console.WriteLine("Edad: ");
                        alumno2.Edad = int.Parse(Console.ReadLine());

                        listado.Add(alumno2);
                        Console.WriteLine("\n\n\n\n\n");
                        break;

                    case 3:
                        E_Alumno alumno3 = new E_Alumno();
                        Console.WriteLine("EDITANDO ALUMNO: ");
                        Console.WriteLine("Id: ");
                        alumno3.Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Nombres: ");
                        alumno3.Nombres = Console.ReadLine();

                        Console.WriteLine("Apellidos: ");
                        alumno3.Apellidos = Console.ReadLine();

                        Console.WriteLine("Edad: ");
                        alumno3.Edad = int.Parse(Console.ReadLine());

                        Console.WriteLine("Promedio: ");
                        alumno3.Promedio = double.Parse(Console.ReadLine());

                        Console.WriteLine(alumno3);

                        for (int i = 0; i < listado.Count; i++)
                        {
                            if (listado[i].Id == alumno3.Id)
                            {
                                listado[i] = alumno3;
                            }
                        }
                        Console.WriteLine("\n\n\n\n\n");
                        break;

                    case 4:
                        E_Alumno alumno4 = new E_Alumno();
                        Console.WriteLine("ELIMINANDO ALUMNO: ");
                        Console.WriteLine("Id: ");
                        alumno4.Id = int.Parse(Console.ReadLine());

                        listado.RemoveAll(r => r.Id == alumno4.Id);
                        Console.WriteLine("\n\n\n\n\n");
                        break;

                    default:
                        Console.WriteLine("Opción no disponible!");
                        Console.WriteLine("\n\n\n\n\n");
                        break;
                }
            }
        }
    }
}
