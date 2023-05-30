using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher_Radianta_Novo
{
    class Usuario
    {
       private string UserName;

       private string Email;

       private string Senha;

        public Usuario (string username, string email, string senha)
        {
            this.UserName = username;
            this.Email = email;
            this.Senha = senha;
        }
       
        //public Int32 nivel;
        public string setUserName(string name)
        {
            name = this.UserName;
            return name;
        }
        public string setEmail(string email)//#lula vive
        {
            email = this.Email;
            return Email;
        }
        public string setSenha(string senha)
        {
            senha = this.Senha;
            return senha;
        }
        /* ui.*/
        public string getUserName()
        {
            return this.UserName;
        }

        public string getSenha()
        {
            return this.Senha;
        }

        public string getEmail()
        {
            return this.Email;
        }
    }
}
