// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

Vertebrado vertebrado = new Vertebrado();
vertebrado.Nombre = "Perro";
vertebrado.Color = "Blanco";
vertebrado.Tamano = "Grande";
vertebrado.Familia = "Husky Sibereano";
vertebrado.Tipo = "Mamiferos";
vertebrado.TienePatas = true;
vertebrado.EsDomestico = true;
vertebrado.EsHervivoro = false;
vertebrado.EsCarnivoro = true;
vertebrado.Imprimir();
Console.WriteLine(new string('-',40));