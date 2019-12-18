using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    //Clase sellada: Puedo crear instancias de la clase, pero no heredar
    public  sealed class EscuelaEngine
    {
        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
               
        }
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
            //Creación de alumnos al azar
            //generador de números aleatorios
            Random rnd = new Random();
            foreach (var c in Escuela.Cursos)
            {
                //next genera un entero, mínimo 5, máximo 20
                int cantidadRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>(){
                                                   new Asignatura{Nombre = "Matemáticas"},
                                                   new Asignatura{Nombre = "Educación Física"},
                                                   new Asignatura{Nombre = "Castellano"},
                                                   new Asignatura{Nombre = "Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Francisco", "Alberto", "Martha", "Lucía", "Samuel", "Sebastián", "Julián" };
            string[] apellido1 = { "Arroyo", "Ortega", "Espinosa", "Cruz", "Estrada", "Ramones", "Orantes" };
            string[] nombre2 = { "Margarita", "Luciano", "Roberto", "Catalina", "Moisés", "Gonzalo", "Ana" };

            //generar nombres aleatorios con lenguaje integrado de consultas (Linq)
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre= $"{n1} {n2} {a1}" };
            //OrderBy ordena ascendentemente, cada miembro de la lista es un alumno que se ordenará por su ID
            //y toma sólo la cantidad que se haya especificado y lo convierte en una lista con ToList
            return listaAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();
        }


        private void CargarEvaluaciones()
        {
            //var lista = new List<Evaluacion>();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {                    
                    foreach (var alumno in curso.Alumnos)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluacion
                            {
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev# {i +1}",
                                Nota = (float)(5 * rnd.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(ev);
                        }
                    }
                }
            }
        }

    }
}