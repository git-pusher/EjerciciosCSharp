using CoreEscuela.Util;
using CoreEscuela.Entidades;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            //se mueven las inicializaciones de escuela y cursos a EscuelaEngine
            //y se inicializan de esta forma aquí
            var engine = new EscuelaEngine();
            engine.Inicializar();
            //se importa el namespace de Util para usar Printer
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            Printer.Beep(10000, cantidad:3);
            ImprimirCursosEscuela(engine.Escuela);

            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de POLIMORFISMO");

            var alumnoTest = new Alumno { Nombre = "Claire UnderWood" };

            Printer.WriteTitle("AlumnoTest");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            ObjetoEscuelaBase ob = alumnoTest;
            Printer.WriteTitle("ObjetoEscuelaBase");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

            var objDummy = new ObjetoEscuelaBase() { Nombre = "Frank Underwood" };
            Printer.WriteTitle("ObjDummy");
            WriteLine($"Alumno: {objDummy.Nombre}");
            WriteLine($"Alumno: {objDummy.UniqueId}");
            WriteLine($"Alumno: {objDummy.GetType()}");

            alumnoTest = (Alumno) ob;
            Printer.WriteTitle("AlumnoTest");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");
            
            //GENERA ERROR EN TIEMPO DE EJECUCIÓN
            /* alumnoTest = (Alumno) objDummy;
            Printer.WriteTitle("AlumnoTest");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}"); */

            var evaluacion = new Evaluacion(){Nombre = "Evaluacion 1", Nota=4.5f};
            Printer.WriteTitle("evaluacion");
            WriteLine($"Alumno: {evaluacion.Nombre}");
            WriteLine($"Alumno: {evaluacion.UniqueId}");
            WriteLine($"Alumno: {evaluacion.Nota}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            ob = evaluacion;
            Printer.WriteTitle("ObjetoEscuelaBase evaluacion");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

            // GENERA ERROR EN TIEMPO DE EJECUCIÓN
            // alumnoTest = (Alumno)(ObjetoEscuelaBase)evaluacion;
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos Escuela");
            // if(escuela != null && escuela.Cursos != null) 
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, Id: {curso.UniqueId} ");
                }
            }
        }
    }
}
