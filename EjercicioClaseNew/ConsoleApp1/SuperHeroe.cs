using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder SuperPoder { get; set; }

        //Constructor vacio
        public SuperHeroe()
        {
          
        }

        //Constructor con parametros
        public SuperHeroe(string nombre, string identidadsecreta, string ciudad, bool puedevolar, SuperPoder superPoder){
            Nombre = nombre;
            IdentidadSecreta = identidadsecreta;
            Ciudad = ciudad;
            PuedeVolar = puedevolar;
            SuperPoder =  superPoder;
        }

        public void Imprimir(){
            //Linea divisoria superior
            Console.Write(new string ('-', 143));
            //Formato para la fila, tiene que coincidir con el encabezado
            string fila = "\n| {0,-15} | {1,-20} | {2,-15} | {3,-15} | {4,-20} | {5,-30} | {6,6} |";
            //Cadena de impresión según el formato establecido en fila
            Console.WriteLine(String.Format(fila, Nombre, IdentidadSecreta, Ciudad, PuedeVolar, SuperPoder.Nombre, SuperPoder.Descripcion, SuperPoder.Nivel));

        }
    }
}
