using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        //para que cada alumno sea portador de su propia lista de evaluaciones
        public List<Evaluacion> Evaluaciones { get; set; } = new List<Evaluacion>();   
    }
}