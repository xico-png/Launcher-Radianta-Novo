using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Launcher_Radianta_Novo
{
    public partial class winRegistro : Form
    {
        List<Usuario> listUsuarios = new List<Usuario>();  // lista de usuarios;

        public winRegistro()
        {
            InitializeComponent();
        } // Inicializa

        private void winRegistro_Load(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }
        public void salvaDados(string email, string senha, string username) {

        }
        public bool emailExiste(string email, string senha, string username)
        {
            foreach (Usuario usuario in listUsuarios)
            {
                if (usuario.getEmail() == email)
                {
                    return true;
                }

                if (usuario.getUserName() == username)
                {
                    return true;
                }
                if (usuario.getSenha() == senha)
                {
                    return true;
                }
            }

            return false;
        }

        public void btnEnviarEmail(object sender, EventArgs e)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            var config = builder.Build();

            var conta = config.GetSection("EmailServerAccount").Get<EmailServerAccount>();


            // Busca automaticamente todos os arquivos em todos os subdiretórios
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\Files";
            DirectoryInfo Dir = new DirectoryInfo(path);
            FileInfo[] files = Dir.GetFiles("*", SearchOption.AllDirectories);
            var fileNames = files.Select(f => f.FullName).ToArray();

            //cria senha
            string senha = CsenhasRandom.GeneratePassword(8);
            // chamada da função de disparo do e-mail
            string usuario = txtUsuario.Text;
            string email = txtEmail.Text;

            /*  if(emailExiste(email) == true)
              {
                  //se o email existe logar
              }
            */
            if (email.Contains(("@")))
            {
                if (email.Contains((" "))) { MessageBox.Show(" Caracter Invalido"); }




                bool statusResponse = Util.EnviarMensagem(conta, new string[] { email }, null,
                 "NÃO RESPONDA ESTE EMAIL, Ola Este é seu usuario: " + usuario +
                 ", senha: " + senha, " Radianta Project - Password ", fileNames);

                if (statusResponse == true) //
                {
                    Usuario usuarioObj = new Usuario(usuario, email, senha); //Cria o objeto do usuario
                    listUsuarios.Add(usuarioObj); //Adiciona o novo usuario na lista
                    ///cria arquivo txt dentro do banco de dados locas usuarios;
                    ///

                    DirectoryInfo user = new DirectoryInfo(@"Usuarios/" + usuario + ".txt");
                    if (user.Exists)
                    {
                        MessageBox.Show(usuario + "Ja existe, Crie outro.");
                        return;
                        
                    }
                    else
                    {
                        
                        using (StreamWriter sw = File.AppendText(@"Usuarios/" +usuario + ".txt"))
                        {
                            sw.WriteLine(email);
                            sw.WriteLine(senha);
                        }
                            ///fim da criação do arquivo 

                            this.Close();


                    }

                    //Console.WriteLine(sendResponse);
                 

                }
                else
                {
                    MessageBox.Show("E-mail invalido, insira um endereço válido exemplo: ''seuemail@email.com''");

                }
            }
        }
    
         //
        public void btn_INFO_Email(object sender, EventArgs e)
        {
            

        }

        private void Usuário_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
