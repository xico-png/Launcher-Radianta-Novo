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
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string CaminhoVideo = Path.Combine(Application.StartupPath, "Video.mp4");
            AbaVideo.URL = CaminhoVideo;
        }
    }
}