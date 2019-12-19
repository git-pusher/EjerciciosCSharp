using CoreEscuela.Util;
using CoreEscuela.Entidades;
using static System.Console;
using System.Linq;

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
            var listaObjetos = engine.GetObjetoEscuela();
            var listaILugar = from obj in listaObjetos
                            where obj is ILugar
                            select (ILugar) obj;
            //engine.Escuela.LimpiarLugar();
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
