using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba3.Models
{
    public class Usuario {

        private int idUser;
        private string name;
        private string userName;
        private string password;

        public int IdUser { get { return idUser; } }
        public string Name { get { return name; } }
        public string UserName { get { return userName; } }
        public string Password { get { return password; } }
        

        public Usuario() {

        }

        public Usuario(int idUser, string name, string userName, string password)
        {
            this.idUser = idUser;
            this.name = name;
            this.userName = userName;
            this.password = password;
        }
    }


}