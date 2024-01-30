using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vertebrado : Animal
    {
        public string Tipo {  get; set; }
        public bool TienePatas { get; set; }
        public bool EsDomestico { get; set; }
        public bool EsHervivoro { get; set; }
        public bool EsCarnivoro { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {Familia}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Tiene patas:{(TienePatas ? "si" : "no")}");
            Console.WriteLine($"Es domestico: {(EsDomestico ? "si" : "no")}");
            Console.WriteLine($"Es hervivoro: {(EsHervivoro ? "si" : "no")}");
            Console.WriteLine($"Es carnivoro: {(EsCarnivoro ? "si" : "no")}");   
        }
    }
}
