// using System;
// using System.Collections.Generic;
// using System.Linq;
// using CoreEscuela.App;
// using CoreEscuela.Entidades;
// using CoreEscuela.Util;
// using static System.Console;

// namespace CoreEscuela.App
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             AppDomain.CurrentDomain.ProcessExit += AccionDelEvento;
//             //AppDomain.CurrentDomain.ProcessExit += (o, s) => Printer.Beep(2000, 1000, 1);

//             var engine = new EscuelaEngine();
//             engine.Inicializar();
//             Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
//             //Printer.Beep(10000, cantidad: 10);
//             //ImpimirCursosEscuela(engine.Escuela);
//             // Dictionary<int, string> dicccionario = new Dictionary<int, string>();

//             // dicccionario.Add(10, "JuanK");

//             // dicccionario.Add(23, "Lorem Ipsum");

//             // foreach (var keyValPair in dicccionario)
//             // {
//             //     WriteLine($"Key: {keyValPair.Key} Valor: {keyValPair.Value}");
//             // }

//             // var dictmp = engine.GetDiccionarioObjetos();

//             // engine.ImprimirDiccionario(dictmp, true);
            
//             var reporteador = new Reporteador(engine.GetDiccionarioObjetos());

//             var evalList = reporteador.GetListaEvaluaciones();

//             var listaAsig = reporteador.GetListaAsignaturas();

//             var listaEvalXAsig = reporteador.GetListaEvalXAsig();

//             var listaPromXAsig = reporteador.GetPromedioAlumXAsig();

          
//             /* Reto del menu. */
      
//             ConsoleKeyInfo opcion;
          
//             do
//             {
//                 Console.Clear();
//                 Printer.WriteTitle("BIENVENIDO AL PROGRAMA ESCUELA");
//                 WriteLine(engine.Escuela);
//                 WriteLine("1 - Lista de cursos.");
//                 WriteLine("2 - Reporte de evaluaciones.");
//                 WriteLine("3 - Reporte de asignaturas.");
//                 WriteLine("4 - Reporte de evaluaciones por asignatura.");
//                 WriteLine("5 - Reporte del promedio de alumnos por asignatura.");
//                 WriteLine("6 - Reporte Top X de estudiantes por asignatura.");
//                 WriteLine("Presione ENTER o ESC para salir");
            
            
//                 opcion = Console.ReadKey();
//                 Console.Clear();                
//                 switch (opcion.Key)
//                 {
//                     case ConsoleKey.D1:
//                         ImpimirCursosEscuela(engine.Escuela);
//                         presioneCualquierTecla();
//                         break;
//                     case ConsoleKey.D2:
//                         reporteador.ImprimirEvaluaciones();
//                         presioneCualquierTecla();
//                         break;
//                     case ConsoleKey.D3:
//                         reporteador.ImprimirAsignaturas();
//                         presioneCualquierTecla();
//                         break;
//                     case ConsoleKey.D4:
//                         reporteador.ImprimirEvaluacionesPorAsignatura();
//                         presioneCualquierTecla();
//                         break;
//                     case ConsoleKey.D5:
//                         reporteador.ImprimirPromedioAlumnosPorAsignatura();
//                         presioneCualquierTecla();
//                         break;
//                     case ConsoleKey.D6:
//                         int top;
//                         string cadenaTop;

//                         Write("\nDigite la cantidad de estudiantes, luego ENTER: ");
//                         cadenaTop = ReadLine();
//                         top = int.Parse(cadenaTop);
//                         reporteador.ImprimirTopPromediosPorAsignatura(top);
//                         presioneCualquierTecla();
//                         break;
//                     default:
//                         Console.Clear();
//                         Printer.WriteTitle("Hasta la vista");
//                         break;
//                 }                
//             }
//             while (opcion.Key != ConsoleKey.Escape && opcion.Key != ConsoleKey.Enter);
//         }

//         private static void presioneCualquierTecla()
//         {
//             System.Console.WriteLine("\n------ Presione cualquier tecla -------");
//             System.Console.WriteLine("         para regresar al Menu");
//             Console.ReadKey();
//         }

//         private static void ImpimirCursosEscuela(Escuela escuela)
//         {

//             Printer.WriteTitle("Cursos de la Escuela");


//             if (escuela?.Cursos != null)
//             {
//                 foreach (var curso in escuela.Cursos)
//                 {
//                     WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
//                 }
//             }
//         }
//     }
// }
