using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Clase : Alumno
    {
        public string? nombreClase;
        public int? horaClase;
        public string? nombreCatedratico;

        public override void mostrarAlumno()
        {
            throw new ();
        }

        public void mostrarClase()
        {

            Console.WriteLine("Nombre de la clase: " + nombreClase);
            Console.WriteLine("Hora de la clase: " + horaClase);
            Console.WriteLine("Nombre del catedrático: " + nombreCatedratico);
    }
    }
    

    

    
}
