using System;

namespace Demos
{
    public class Employe: User
    {
        // Propiedades
        public string Name { get; set; }
        public string Surname { get; set; }
        public string NumberEmploye { get; set; }

        /// <summary>
        /// Constructor de la clase Employe que por defecto al heredar de la clase User tiene que llevar los mismos parametros 
        /// de entrada que esta contiene, para indicar que hay dos parametros de entrada que corresponden a la iniciacion de 
        /// la clase base User se lo indica agregando dos puntos y a continuación base() donde dentro podemos agregar los 
        /// parametros que queramos siempre y cuando esten nombrados en el contructor de Employe
        /// </summary>
        /// <param name="username">Variable de entrada de usuario de la clase Base</param>
        /// <param name="password">Variable de entrada de contraseña de la clase Base</param>
        public Employe(string username, string password,string name, string surname) : base(username, password)
        {
            Name = name;
            Surname = surname;

            // Utilizamos la clase estatica Datetime con su propiedad Now
            // que retorna la fecha y hora actual y despues retornamos un codigo unico convinado por
            // año + mes + dia + hora + minuto + segundo
            NumberEmploye = DateTime.Now.ToString("yyyyMMddhhmmss");
        }
    }
}
