using App;
using App.VLC;
using Presentation.Views;

namespace Presentation
{
    public partial class Home : Form
    {
        private ScrapSelector _scrapSelector;
        private VLCExec _vlc;
        public Home()
        {
            InitializeComponent();
            _scrapSelector = new ScrapSelector();
            _vlc = new VLCExec(Presentation.Settings.Default.VLCPath, Presentation.Settings.Default.VLCPassword);
            RCP.SetPresenceTxt("Video Scrapper | Home", "IDK just download this", "https://raw.githubusercontent.com/AbreuHD/AbreuHD/master/gifs/banner.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settingsview configForm = new();
            configForm.Show();
        }

        private void Home_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            RCP.Dispose();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var responseURI = _scrapSelector.GetDirectUri(tbLink.Text);
            if (Presentation.Settings.Default.ItemSearch)
            {
                ItemSelector itemSelector = new(responseURI);
                itemSelector.Show();
            }
            else
            {
                _vlc.Open(responseURI, null, null);
            }
        }

        private void tbLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
