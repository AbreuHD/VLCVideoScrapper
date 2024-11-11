using App.VLC.VLC;
using System.Diagnostics;

namespace App.VLC
{
    public class VLCExec
    {
        private string _path;
        private string _password;

        public VLCExec(string path, string password)
        {
            _path = path;
            _password = password;
        }

        public void Open(string link, string title, string img)
        {
            VLC.VLCWrapper.Initialize("", _password, title, img);
            Process.Start(new ProcessStartInfo
            {
                FileName = _path,
                Arguments = link,
                UseShellExecute = false,
                RedirectStandardOutput = false,
                RedirectStandardError = false,
                CreateNoWindow = true
            });
            
        }

    }
}
