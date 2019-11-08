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
                              new Curso() {Nombre = "502", Jornada = TiposJornada.Tarde}
            };

            //Creando un curso temporal 
            Curso tmp = new Curso {Nombre = "101-Vacacional", Jornada = TiposJornada.Noche};

            //Métodos para adicionar
            escuela.Cursos.AddRange(otraColecion);      
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            //WriteLine("Curso.Hash: " + tmp.GetHashCode());
            // Predicate<Curso> miAlgoritmo;
            // escuela.Cursos.RemoveAll(miAlgoritmo);
            //escuela.Cursos.Remove(tmp);
            WriteLine("==================================");
            ImprimirCursosEscuela(escuela);

            //Eliminar todo
            //otraColecion.Clear(); 
            //otraColecion.Remove(); 
            


            ////////////////////////////////////////////////////////////////////////////////////
            //IMPRESIÓN FINAL


        }

        // private static bool miAlgoritmo(Curso curobj)
        // {
        //     return curobj.Nombre == " 301";
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
