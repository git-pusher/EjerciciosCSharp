//me acorta la instrucción para usar el objeto WriteLine
using static System.Console;
namespace CoreEscuela.Util
{

    //La calse estatica no permite crear más clases, pero se puede usar como un objeto
   public static class Printer
   {
       //recibe comoparámetro el tamaño de la línea, por defecto será 10
       public static void DibujarLinea(int tam = 10)
       {
           //Padleft rellenará de acuerdo a los parámetros que se le pasen
           WriteLine("".PadLeft(tam, '='));
       }
       public static void WriteTitle(string titulo)
       {
           var tamaño = titulo.Length + 4;
           //Dibujamos una línea del tamaño de la cadena titulo
           DibujarLinea(tamaño);
           //string literals
            WriteLine($"| {titulo} |");
           DibujarLinea(tamaño);
       }

       public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
       {
           //decremento con el --
           while(cantidad--> 0)
           {
               System.Console.Beep(hz, tiempo);
           }
       }
   } 
}