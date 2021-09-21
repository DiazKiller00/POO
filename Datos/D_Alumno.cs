using System;
using System.Collections.Generic;
using Entidades;

namespace Datos
{
    public class D_Alumno
    {
        public List<E_Alumno> listarAlumnos() {
            List<E_Alumno> lista = new List<E_Alumno>();
            lista.Add(new E_Alumno(1, "Wilfredo", "Morales", 19, 7.4));
            lista.Add(new E_Alumno(2, "Cristian", "Figueroa", 18, 9.9));
            lista.Add(new E_Alumno(3, "Nelson", "Calles", 20, 9.3));
            lista.Add(new E_Alumno(4, "Kemberly", "Amaya", 19, 8.2));
            lista.Add(new E_Alumno(5, "Eduardo", "Vasquez", 18, 7.5));

            return lista;
        }

    }
}
