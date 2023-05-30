using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher_Radianta_Novo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCapa_Click(object sender, EventArgs e)
        {
            CapaImagem NovaJanela = new CapaImagem();
            NovaJanela.Show();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            Video NovaJanela = new Video();
            NovaJanela.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
