using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.App;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela.App
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;
            //AppDomain.CurrentDomain.ProcessExit += (o, s) => Printer.Beep(2000, 1000, 1);

            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad: 10);
            //ImpimirCursosEscuela(engine.Escuela);
            // Dictionary<int, string> dicccionario = new Dictionary<int, string>();

            // dicccionario.Add(10, "JuanK");

            // dicccionario.Add(23, "Lorem Ipsum");

            // foreach (var keyValPair in dicccionario)
            // {
            //     WriteLine($"Key: {keyValPair.Key} Valor: {keyValPair.Value}");
            // }

            // var dictmp = engine.GetDiccionarioObjetos();

            // engine.ImprimirDiccionario(dictmp, true);
            
            var reporteador = new Reporteador(engine.GetDiccionarioObjetos());

            var evalList = reporteador.GetListaEvaluaciones();

            var listaAsig = reporteador.GetListaAsignaturas();

            var listaEvalXAsig = reporteador.GetListaEvalXAsig();

            var listaPromXAsig = reporteador.GetPromedioAlumXAsig();

            Printer.WriteTitle("Captura de una evaluación por consola");
            var newEval = new Evaluación();
            string nombre, notaString;
            float nota;
            WriteLine("Ingrese nombre  de la evaluación:");
            Printer.ENTER();
            nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Printer.WriteTitle("El valor del nombre no puede ser vacío.");
                WriteLine("Saliendo del programa");
            } else
            {
                newEval.Nombre = nombre.ToLower();
                WriteLine("Se ingresó correctamente el nombre");
            }

            WriteLine("Ingrese nota de la evaluación:");
            Printer.ENTER();
            notaString = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(notaString))
            {
                Printer.WriteTitle("El valor de la nota no puede ser vacío.");
                WriteLine("Saliendo del programa");
            } else
            {
                try
                {
                    newEval.Nota = float.Parse(notaString);
                    if (newEval.Nota <0 || newEval.Nota > 5)
                    {
                        throw new ArgumentException("La nota debe estar entre 0 y 5");
                    }
                    WriteLine("Se ingresó correctament la nota");
                } 
                catch(ArgumentException arg)
                {
                    Printer.WriteTitle(arg.Message);
                    WriteLine("Saliendo del programa");
                }
                catch(Exception)
                {
                    Printer.WriteTitle("El valor de la nota no es un número válido.");
                    WriteLine("Saliendo del programa");
                }
                finally{
                    Printer.WriteTitle("F I N A  L L Y");
                    Printer.Beep(2500, 500, 3);
                }
            }

        }

        private static void AccionDelEvento(object sender, EventArgs e)
        {
            Printer.WriteTitle("SALIENDO");
            //Printer.Beep(3000, 1000, 3);
            Printer.WriteTitle("SALIÓ");
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos de la Escuela");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
