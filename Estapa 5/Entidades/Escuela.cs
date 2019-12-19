using System;
using System.Collections.Generic;
using CoreEscuela.Util;

namespace CoreEscuela.Entidades
{
    public class Escuela : ObjetoEscuelaBase, ILugar
    {
        public int AñoDeCreacion { get;set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
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

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando escuela...");
            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
            Printer.WriteTitle($"Escuela {Nombre} limpia.");
            //Console.WriteLine($"Escuela {Nombre} limpia.");
            Printer.Beep(1000, cantidad:3);
        }
    }
}