using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCsharp
{
    public class Estudiante //SINGLETON
    {
        // Propiedades
        public string Nombre { get; set; }
        //***********************************
        private static Estudiante instancia; //Instancia única
        //Constructor por defecto privado
        private Estudiante() {
            AsignarNombre();
        } 
        public static Estudiante ObtenerInstancia()
        {
            if (instancia==null) instancia = new Estudiante(); // ya no será nulo

            return instancia;
       }

        private void AsignarNombre()
        {
            this.Nombre = "50k registros";
        }

        ~Estudiante() // destructor
        {
            //
        }
    }
}
