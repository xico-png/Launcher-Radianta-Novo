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
    public partial class CapaImagem : Form
    {
        public CapaImagem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                button1.Location = new Point(button1.Location.X + 416, button1.Location.Y);
            }
            else
            {
                pictureBox1.Visible = true;
                button1.Location = new Point(button1.Location.X - 414, button1.Location.Y);
            }
        }
    }
}
