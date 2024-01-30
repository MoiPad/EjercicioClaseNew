
namespace EjercicioInterfazClase
{
    internal class Invertebrado : Animal, IAnimal
    {
        public void Imprimir() {
            Console.WriteLine($"Nombre: {Nombre}");
        }

      
    }
}
