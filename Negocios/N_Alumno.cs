using System;
using System.Collections.Generic;
using Entidades;
using Datos;

namespace Negocios
{
    public class N_Alumno
    {
        D_Alumno datos = new D_Alumno();

        public List<E_Alumno> N_listaAlumnos()
        {

            List<E_Alumno> listado = datos.listarAlumnos();

            if (listado.Count != 0)
            {
                return listado;
            }
            else
            {
                return null;
            }
        }
    }
}
