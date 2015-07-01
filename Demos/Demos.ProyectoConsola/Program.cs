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
            Console.WriteLine("|==================================|");
            Console.WriteLine("|     Instanciar Clase Player      |");
            Console.WriteLine("|==================================|");
            Console.WriteLine();

            // Instanciar la clase Player
            var player = new Player("Lionel","Messi");

            // Retorno el nombre utilizando el metodo Format del tipo string
            Console.WriteLine(string.Format("  Nombre: {0}",player.Name));
            // Retorno el apellido concatenando los string con el signo +
            Console.WriteLine("  Apellido: " + player.Surname);

            // Retorno el nombre completo utilizando la interpolacion de cadena 
            Console.WriteLine($"  Nombre Completo: {player.FullName()}");

            Console.WriteLine();
            Console.WriteLine("|==================================|");
            Console.WriteLine("|     Instanciar Clase Team        |");
            Console.WriteLine("|==================================|");
            Console.WriteLine();

            var team = new Team() {Name = "Barcelona"};

            // Agrego a la propiedad tipo lista de Player
            // de la clase Team un jugador ya creado que en este
            // caso es un objeto de tipo Player
            team.Players.Add(player);

            // Retorno el nombre del Equipo
            Console.WriteLine($"  Nombre del Equipo: {team.Name}");
            // Llamo al metodo GetCount y retorno la cantidad de jugadores
            Console.WriteLine($"  Cantidad de Jugadores: {team.GetCount()}");
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
