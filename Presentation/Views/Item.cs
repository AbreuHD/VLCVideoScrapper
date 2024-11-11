using App.VLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class Item : UserControl
    {
        VLCExec _VLCExec;
        private readonly string _responseURI;
        private string img = "";
        private ItemSelector _itemSelector;

        public Item(App.VLC.VLCExec vlc, string responseURI)
        {
            InitializeComponent();
            _VLCExec = vlc;
            _responseURI = responseURI;
        }

        public async Task SetDataAsync(string title, string description, string img, ItemSelector itemSelector)
        {
            Tittle.Text = title;
            this.img = img;
            Description.Text = description;
            _itemSelector = itemSelector;
            try
            {
                var client = new HttpClient();
                var imageBytes = await client.GetByteArrayAsync("https://image.tmdb.org/t/p/original" + img);
                using (var stream = new System.IO.MemoryStream(imageBytes))
                {
                    Img.Image = System.Drawing.Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }
        private void Item_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Img_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Description_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Tittle_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void Img_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }


        private void Item_Click(object sender, EventArgs e)
        {
            OnClicked();
        }

        private void Description_Click(object sender, EventArgs e)
        {
            OnClicked();
        }

        private void Img_Click(object sender, EventArgs e)
        {
            OnClicked();
        }

        private void OnClicked()
        {
            _VLCExec.Open(_responseURI, Tittle.Text, "https://image.tmdb.org/t/p/original" + this.img);
            _itemSelector.Dispose();
        }
    }
}
