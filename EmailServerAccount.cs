using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher_Radianta_Novo
{
    internal class EmailServerAccount
    {
        public string EmailOrigem { get; set; }
        public string NomeOrigem { get; set; }
        public string Server { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string Retorno { get; set; }
        public Boolean Autentica { get; set; }
        public Boolean Ativo { get; set; }
        public string EmailDebug { get; set; }
       
    }
}
