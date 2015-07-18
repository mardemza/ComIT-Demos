namespace Demos
{
    public class User
    {
        // Propiedades
        public string Username { get; set; }
        string Password { get; set; }

        /// <summary>
        /// Constructor de la clase User
        /// </summary>
        /// <param name="username">Variable de entrada de Usuario tipo String</param>
        /// <param name="password">Variable de entrada de Contraseña tipo String</param>
        public User(string username, string password)
        {
            Username = username;
            Password = EncryptPassword(password);
        }


        /// <summary>
        /// Metodo privado para simular una encriptacion de contraseña
        /// </summary>
        /// <param name="password">Variable de entrada de una contraseña tipo string</param>
        /// <returns>retorna una encriptación de la contraseña tipo string</returns>
        private string EncryptPassword(string password)
        {
            return 8*1024 + password;
        }

        /// <summary>
        /// Metodo privado para simular una desencriptación de una contraseña
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string DesencryptPassword(string password)
        {
            return password.Replace((8*1024).ToString(), "");
        }

        /// <summary>
        /// Metodo publico para simular una validacion de un usuario
        /// </summary>
        /// <param name="password">Contraseña</param>
        /// <returns>Retorna un valor true o false</returns>
        public bool ValidUser(string password)
        {
            var passwordDesencrypt = DesencryptPassword(Password);
            return passwordDesencrypt == password;
        }

        
    }

}
