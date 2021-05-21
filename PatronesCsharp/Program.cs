using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiante e1 = Estudiante.ObtenerInstancia();
            Estudiante e2 = Estudiante.ObtenerInstancia();
            Estudiante e3 = Estudiante.ObtenerInstancia();

            if (e1==e2)
                Console.WriteLine("Misma instancia");
            else
                Console.WriteLine("Diferente instancia");
            


           
            
        }
    }
}
