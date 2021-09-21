using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class E_Maestro
    {
        private int id;
        private string nombres;
        private string apellidos;
        private string rol;
        private int edad;

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Edad { get => edad; set => edad = value; }

        public E_Maestro() { }

        public E_Maestro(int id, string nombres, string apellidos, string rol, int edad)
        {
            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.rol = rol;
            this.edad = edad;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, Nombre: {1} {2}, Rol: {3}, Edad: {4}", id, nombres, apellidos, rol, edad);
        }
    }
}
