using Microsoft.Extensions.FileSystemGlobbing.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Launcher_Radianta_Novo
{
    public partial class winLogin : Form
    {
        public winLogin()
        {
            InitializeComponent();


        }
        winRegistro novaTela = new winRegistro();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {






        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


           

            try { novaTela.Show(); }
            catch (Exception)
            {



                winRegistro novaTela = new winRegistro();
                novaTela.Show();

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void winLogin_Load(object sender, EventArgs e)
        {
            

            /// CRIAR PASTA USUARIOS; 
            /// 
            DirectoryInfo dUser = new DirectoryInfo(@"Usuarios");
            if (dUser.Exists)
            {
                return;

            }
            else
            {
                dUser.Create();

            }
            DirectoryInfo listapasta = new DirectoryInfo(@"Usuarios");
            FileInfo[] usuarioListaPasta = listapasta.GetFiles(".txt");
            foreach (FileInfo fi in usuarioListaPasta)
            {

            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string SenhaTeste = txtSenha.Text;
            string username = txtEmail.Text;
            int linha = 2;

         
            try
            {



                if ((email == "admin") && (SenhaTeste == "admin"))
                {
                    Menu Novajanela = new Menu();

                    Novajanela.ShowDialog();

                    
                    

                }
                else
                {
                    string[] buscasenha = File.ReadAllLines(@"Usuarios\" + username + ".txt");
                    string SenhaReal = buscasenha[linha - 1];

                    if (SenhaTeste == SenhaReal)
                    {
                        Menu Novajanela = new Menu();
                        Novajanela.Show();
                    }
                    else { MessageBox.Show("Senha Incorreta"); }
                }
            }
            catch (System.IO.FileNotFoundException) { MessageBox.Show("Usuario Incorreto ou nao consta no banco de dados"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool versenha = false;
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (versenha == false)
            {
                txtSenha.PasswordChar = '\0';
                versenha = true;
            }
            else if (versenha == true)
            {
                txtSenha.PasswordChar = '*';
                versenha = false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtEmail_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
