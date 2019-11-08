using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
            pais: "Colombia", ciudad: "Bogotá");

            //LISTA
            escuela.Cursos = new List<Curso>(){
                              new Curso() {Nombre = "101", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "201", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "301", Jornada = TiposJornada.Mañana}
            };
           

            //En las listas puedo agregar nuevos elementos
            escuela.Cursos.Add( new Curso {Nombre = "102", Jornada = TiposJornada.Tarde});            
            escuela.Cursos.Add( new Curso {Nombre = "202", Jornada = TiposJornada.Tarde});    

            //creo nueva lista
            var otraColecion = new List<Curso>(){
                              new Curso() {Nombre = "401", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "501", Jornada = TiposJornada.Mañana},
                              new Curso() {Nombre = "501", Jornada = TiposJornada.Tarde},
                              new Curso() {Nombre = "502", Jornada = TiposJornada.Tarde}
            };

            //Creando un curso temporal para eliminarlo con Remove()
            Curso tmp = new Curso {Nombre = "101-Vacacional", Jornada = TiposJornada.Noche};

            //Métodos para adicionar
            escuela.Cursos.AddRange(otraColecion);  
            escuela.Cursos.Add(tmp);
            
            ImprimirCursosEscuela(escuela);
            WriteLine("Curso.Hash: " + tmp.GetHashCode());

            //remover el curso temporal(un curso en específico)
            escuela.Cursos.Remove(tmp);

            //eliminar usando predicado
            //Predicate<Curso> miAlgoritmo = Predicado;
            //escuela.Cursos.RemoveAll( Predicado);
            escuela.Cursos.RemoveAll( delegate (Curso cur )
                                    {
                                        return cur.Nombre == "301";
                                    });
            //expresiones lambda, el resultado es igual al delegado, pero más compacto
            escuela.Cursos.RemoveAll(( cur ) => cur.Nombre == "501" && cur.Jornada == TiposJornada.Mañana);
            
            WriteLine("==================================");
            ImprimirCursosEscuela(escuela);

            //Eliminar todo
            //otraColecion.Clear(); 
            //otraColecion.Remove(); 
        }

        //predicado -- ya no uso el predicado, uso delegate
        // private static bool Predicado (Curso curobj)
        // {
        //     return curobj.Nombre == "301";
        // }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("=====================\nCursos de la escuela\n====================="); 
            // if(escuela != null && escuela.Cursos != null) 
            if(escuela?.Cursos != null) 
            {               
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId} ");
                }
            }
        }        
    }
}
