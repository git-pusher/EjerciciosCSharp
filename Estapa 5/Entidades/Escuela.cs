using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Escuela : ObjetoEscuelaBase
    {
        public int AñoDeCreacion { get;set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TiposEscuela TiposEscuela { get; set; }
        public List<Curso> Cursos { get; set; }


        

        //CONSTRUCTOR -- Igualación por tuplas 
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);
        public Escuela(string nombre, 
                       int año, 
                       TiposEscuela tipo, 
                       string pais="", 
                       string ciudad="") 
        {
            (Nombre, AñoDeCreacion) = (nombre, año);
            Pais = pais;
            Ciudad = ciudad;
        }

        public override string ToString() {
            return $"Nombre: {Nombre}, \nTipo: {TiposEscuela}, \nPais: {Pais}, \nCiudad: {Ciudad}";
        }
    }
}