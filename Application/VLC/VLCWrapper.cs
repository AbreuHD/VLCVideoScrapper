using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DiscordRPC;

namespace App.VLC.VLC
{
    internal static class VLCWrapper
    {
        private static HttpClient _httpClient;
        private static System.Timers.Timer _timer;
        private static string _title;
        private static string _img;

        internal static void Initialize(string username, string password, string title, string img)
        {
            _title = title;
            _img = img;
            _httpClient = new HttpClient();
            var authToken = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{username}:{password}"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authToken);

            _timer = new System.Timers.Timer(1000);
            _timer.Elapsed += async (sender, e) => await ActualizarEstadoAsync();
            _timer.Start();
        }

        private static async Task ActualizarEstadoAsync()
        {
            try
            {
                var response = await _httpClient.GetStringAsync("http://localhost:8080/requests/status.json");
                dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(response);

                double tiempoActualSegundos = json.time;
                double duracionTotalSegundos = json.length;

                var posicionActual = TimeSpan.FromSeconds(tiempoActualSegundos);
                var duracionTotal = TimeSpan.FromSeconds(duracionTotalSegundos);

                // Se verifica si los valores están inicializados y se actualiza el estado
                if (_title != null && _img != null)
                    RCP.SetPresenceTime($"Viendo {_title}", posicionActual, duracionTotal, _img);
                else if (_title != null)
                    RCP.SetPresenceTime($"Viendo algo", posicionActual, duracionTotal, "vlc");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar el estado: " + ex.Message);
            }
        }
    }
}
