using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set;}
        public List<Alumno> Alumnos { get; set;}

        // Este constructor es igual que el de abajo
        // public Curso()
        // {
        //     UniqueId = Guid.NewGuid().ToString();
        // }                 
        public Curso() => UniqueId = Guid.NewGuid().ToString();      
     }
}