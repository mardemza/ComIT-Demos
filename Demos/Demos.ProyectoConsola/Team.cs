using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public class Team
    {
        // Propiedades de la clase Team
        public string Name { get; set; }
        public List<Player> Players { get; set; }

        /// <summary>
        /// Constructor de la clase Team
        /// </summary>
        public Team()
        {
            Players = new List<Player>();
        }

        /// <summary>
        /// Metodo para retornar la cantidad de jugadores que tiene la clase Team
        /// </summary>
        /// <returns>Valor tipo entero</returns>
        public int GetCount()
        {
            return Players.Count();
        }
    }
}
