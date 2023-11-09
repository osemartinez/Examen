using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public abstract class Alumno
    {
        public string? nombre {  get; set; }
        public string? numeroCuenta { get; set; }
        public string? email { get; set; }



        public void imprimir()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Numero de cuenta: " + numeroCuenta);
            Console.WriteLine("Email:" + email);
          
        }

        public override void mostarAlumno()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Número de cuenta: " + numeroCuenta);
            Console.WriteLine("Email: " + email);

        }


        public abstract void mostrarAlumno();
    }


 }
   


