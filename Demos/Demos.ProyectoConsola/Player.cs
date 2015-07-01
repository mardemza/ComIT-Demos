using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public class Player
    {
        // Propiedades 
        public string Name { get; set; }
        public string Surname { get; set; }

        /// <summary>
        /// Contructor de la Clase Player
        /// </summary>
        /// <param name="name">Variable tipo string de entrada del nombre</param>
        /// <param name="surname">Variable tipo string de entrada del apellido</param>
        public Player(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        /// <summary>
        /// Metodo que retorna el nombre completo
        /// </summary>
        /// <returns>Retorna un string con el nombre y el apellido separados por un espacio</returns>
        public string FullName()
        {
            // Contatenar
            return string.Format("{0} {1}", Name, Surname);
        }
    }
}
