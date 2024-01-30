using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Invertebrado : Animal
    {
        public string Tipo {  get; set; }
        public bool TienePatas { get; set;}
        public int NumeroPatas { get; set; }
        public bool TieneConcha {  get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene patas:{(TienePatas ? "si" : "no")}");
            Console.WriteLine($"Numero de patas: {NumeroPatas}");
            Console.WriteLine($"Tiene concha: {(TieneConcha ? "si" : "no")}");
        }
    }
}
