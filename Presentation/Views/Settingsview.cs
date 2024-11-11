using App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Settingsview : Form
    {
        public Settingsview()
        {
            InitializeComponent();
            RCP.SetPresenceTxt("Video Scrapper | Settings", "IDK just download this", "https://raw.githubusercontent.com/AbreuHD/AbreuHD/master/gifs/banner.png");
            loadConfig();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            cbRCP.Checked = RCP.Active;
        }
        private void cbRCP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRCP.Checked)
            {
                RCP.Active = true;
            }
            else
            {
                RCP.ClearPresence();
                RCP.Active = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Program Files\\VideoLAN\\VLC\\"; // Carpeta inicial
                openFileDialog.Filter = "Archivos Ejecutables (*.exe)|*.exe";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = openFileDialog.FileName;
                    Presentation.Settings.Default.VLCPath = rutaArchivo;
                    Presentation.Settings.Default.Save();
                    loadConfig();
                }
            }
        }

        private void loadConfig()
        {
            cbRCP.Checked = Presentation.Settings.Default.RCP;
            cbSearchAllow.Checked = Presentation.Settings.Default.ItemSearch;
            tbApiKey.Text = Presentation.Settings.Default.ApiKey;
            textBox1.Text = Presentation.Settings.Default.VLCPath;
            textBox2.Text = Presentation.Settings.Default.VLCPassword;
            loadCombobox();
        }
        private void loadCombobox()
        {
            var idiomas = new Dictionary<string, string>
            {
                { "en", "Inglés" },
                { "es", "Español" },
                { "fr", "Francés" },
                { "de", "Alemán" },
                { "it", "Italiano" },
                { "pt", "Portugués" },
                { "zh", "Chino" },
                { "ja", "Japonés" },
                { "ko", "Coreano" },
                { "ru", "Ruso" },
                { "ar", "Árabe" },
                { "hi", "Hindi" },
                { "bn", "Bengalí" },
                { "tr", "Turco" },
                { "pl", "Polaco" },
                { "nl", "Neerlandés" },
                { "sv", "Sueco" },
                { "fi", "Finlandés" },
                { "no", "Noruego" },
                { "da", "Danés" },
                { "cs", "Checo" },
                { "el", "Griego" },
                { "he", "Hebreo" },
                { "id", "Indonesio" },
                { "ms", "Malayo" },
                { "th", "Tailandés" },
                { "vi", "Vietnamita" },
                { "ro", "Rumano" },
                { "hu", "Húngaro" },
                { "uk", "Ucraniano" },
                { "bg", "Búlgaro" },
                { "sr", "Serbio" },
                { "hr", "Croata" },
                { "sk", "Eslovaco" },
                { "lt", "Lituano" },
                { "lv", "Letón" },
                { "et", "Estonio" },
                { "sl", "Esloveno" }
            };

            foreach (var idioma in idiomas)
            {
                cbLanguague.Items.Add(new KeyValuePair<string, string>(idioma.Key, idioma.Value));
            }
            cbLanguague.DisplayMember = "Value";
            cbLanguague.ValueMember = "Key";

            cbLanguague.SelectedItem = idiomas.FirstOrDefault(idioma => idioma.Key == Presentation.Settings.Default.Languague);
        }

        private void cbLanguague_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idioma = (KeyValuePair<string, string>)cbLanguague.SelectedItem;
            Presentation.Settings.Default.Languague = idioma.Key;
            Presentation.Settings.Default.Save();
        }

        private void tbApiKey_TextChanged(object sender, EventArgs e)
        {
            var apiKey = tbApiKey.Text;
            Presentation.Settings.Default.ApiKey = apiKey;
            Presentation.Settings.Default.Save();
        }

        private void cbSearchAllow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearchAllow.Checked)
            {
                Presentation.Settings.Default.ItemSearch = true;
            }
            else
            {
                Presentation.Settings.Default.ItemSearch = false;
            }
            Presentation.Settings.Default.Save();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var password = textBox2.Text;
            Presentation.Settings.Default.VLCPassword = password;
            Presentation.Settings.Default.Save();
        }
    }
}
