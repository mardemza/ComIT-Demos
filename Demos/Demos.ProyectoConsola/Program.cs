using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|======================================|");
            Console.WriteLine("|       Instanciar Clase Player        |");
            Console.WriteLine("|======================================|");
            Console.WriteLine();

            // Instanciar la clase Player
            var player = new Player("Gonzalo","Escudero");//Cambie el jugador Leonel Messi! :D 

            // Retorno el nombre utilizando el metodo Format del tipo string
            Console.WriteLine(string.Format("  Nombre: {0}",player.Name));
            // Retorno el apellido concatenando los string con el signo +
            Console.WriteLine("  Apellido: " + player.Surname);

            // Retorno el nombre completo utilizando la interpolacion de cadena 
            Console.WriteLine($"  Nombre Completo: {player.FullName()}");

            Console.WriteLine();
            Console.WriteLine("|======================================|");
            Console.WriteLine("|       Instanciar Clase Team          |");
            Console.WriteLine("|======================================|");
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
            Console.WriteLine("|======================================|");
            Console.WriteLine("|     Instanciar Clase Employe         |");
            Console.WriteLine("|     que hereda de la clase User      |");
            Console.WriteLine("|======================================|");
            Console.WriteLine();

            var employe1 = new Employe("rguemes","mipassword","Roberto","Guemes");

            Console.WriteLine($"  Usuario: {employe1.Username}");
            Console.WriteLine($"  Valido la contraseña (mipassword): {employe1.ValidUser("mipassword")}");
            Console.WriteLine($"  Nombre del Empleado: {employe1.Name}");
            Console.WriteLine($"  Apellido del Empleado: {employe1.Surname}");
            Console.WriteLine($"  Numero de empleado: {employe1.NumberEmploye}");

            Console.WriteLine();
            Console.WriteLine("|======================================|");

            Console.ReadKey();
        }
    }
}
