
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

            WriteLine("*****************************************************");
            ImprimirCursosEscuela(engine.Escuela);
            WriteLine("*****************************************************");
        }
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
