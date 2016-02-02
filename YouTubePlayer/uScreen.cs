using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubePlayer
{
    public partial class uScreen : Form
    {
        public uScreen()
        {
            InitializeComponent();
        }

        private void uScreen_Load(object sender, EventArgs e)
        {
            
        }
        
        private void uScreen_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.Control && e.KeyCode == Keys.V)
            {
                PlayNewChannel();
            }
        }

        private void axShockwaveFlash1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                PlayNewChannel();
            }
        }

        private void PlayNewChannel()
        {
            string url = Clipboard.GetText();
            if (url.Contains(("youtube.com")))
            {
                string token = url.Remove(0, url.IndexOf("=") + 1);

                this.axShockwaveFlash1.Movie = string.Format("https://www.youtube.com/v/{0}", token);
                this.axShockwaveFlash1.Play();
            }
        }
    }
}
