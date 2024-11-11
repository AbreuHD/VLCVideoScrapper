using App;
using App.Dtos;
using App.VLC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Views
{
    public partial class ItemSelector : Form
    {
        private readonly TmdbWrapper _tmdbWrapper;
        private VLCExec _vlc;
        private string _responseURI;

        public ItemSelector(string responseURI)
        {
            InitializeComponent();
            _tmdbWrapper = new TmdbWrapper(Settings.Default.ApiKey, Settings.Default.Languague);
            this._responseURI = responseURI;
        }

        private async Task GetData(GenericTmdbResponse dto)
        {
            _vlc = new VLCExec(Presentation.Settings.Default.VLCPath, Presentation.Settings.Default.VLCPassword);
            foreach (var item in dto.Results)
            {
                var newItem = new Item(_vlc, _responseURI);

                if(item.title == null)
                {
                    item.title = item.name;
                }
                await newItem.SetDataAsync(item.title, item.overview, item.poster_path, this);
                newItem.Width = flowLayoutPanel1.Width - 20;
                newItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                flowLayoutPanel1.Controls.Add(newItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var response = new GenericTmdbResponse();
            if (checkBox1.Checked)
            {
               response = _tmdbWrapper.getTV(tbSearch.Text).Result;
            }
            else
            {
               response = _tmdbWrapper.getMovie(tbSearch.Text).Result;
            }
            GetData(response);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void ItemSelector_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Text = "TV";
            }
            else
            {
                checkBox1.Text = "Movie";
            }
        }

    }
}
