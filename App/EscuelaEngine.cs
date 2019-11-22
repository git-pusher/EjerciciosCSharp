using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }
        public EscuelaEngine()
        {
        }
        public void Inicializar()
        {
            //se inicializa escuela
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
               pais: "Colombia", ciudad: "Bogotá");

            //Se inicializan cursos
            CargarCursos();
            CargarAsignaturas();
            foreach (var curso in Escuela.Cursos)
            {
                //A cada curso se le está agregando varios alumnos
                curso.Alumnos.AddRange(CargarAlumnos());
                
            }
            CargarEvaluaciones();
        }
        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>(){
                              new Curso() {Nombre = "101", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "301", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "401", Jornada = TiposJornada.Tarde},
                              new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde},
            };
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignatura = new List<Asignatura>(){
                                                   new Asignatura{Nombre = "Matemáticas"},
                                                   new Asignatura{Nombre = "Educación Física"},
                                                   new Asignatura{Nombre = "Castellano"},
                                                   new Asignatura{Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas.AddRange(listaAsignatura);
            }
        }

        private IEnumerable<Alumno> CargarAlumnos()
        {
            string[] nombre1 = { "Francisco", "Alberto", "Martha", "Lucía", "Samuel", "Sebastián", "Julián" };
            string[] apellido1 = { "Arroyo", "Ortega", "Espinosa", "Cruz", "Estrada", "Ramones", "Orantes" };
            string[] nombre2 = { "Margarita", "Luciano", "Roberto", "Catalina", "Moisés", "Gonzalo", "Ana" };

            //generar nombres aleatorios con lenguaje integrado de consultas
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre= $"{n1} {n2} {a1}" };
            return listaAlumnos;
        }


        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

    }
}