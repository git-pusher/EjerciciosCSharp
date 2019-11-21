using System.Collections.Generic;
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
            Escuela.Cursos = new List<Curso>(){
                              new Curso() {Nombre = "101", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "301", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "401", Jornada = TiposJornada.Tarde},
                              new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde},
            };
        }
    }
}