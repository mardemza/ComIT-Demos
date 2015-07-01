using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("==== Instanciar Clase Player =======");
            Console.WriteLine("====================================");
            Console.WriteLine();

            // Instanciar la clase Player
            var player = new Player("Juan","Suarez");

            // Retorno el nombre utilizando el metodo Format del tipo string
            Console.WriteLine(string.Format("Nombre: {0}",player.Name));
            // Retorno el apellido concatenando los string con el signo +
            Console.WriteLine("Apellido: " + player.Surname);

            // Retorno el nombre completo utilizando la interpolacion de cadena 
            Console.WriteLine($"Nombre Completo: {player.FullName()}");
            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
