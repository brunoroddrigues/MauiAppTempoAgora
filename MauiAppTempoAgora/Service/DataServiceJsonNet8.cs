using MauiAppTempoAgora.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MauiAppTempoAgora.Service
{
    public class DataServiceJsonNet8
    {
        public static async Task<Tempo?> GetPrevisaoDoTempo(string cidade)
        {
            // https://home.openweathermap.org/api_keys
            string appId = "6135072afe7f6cec1537d5cb08a5a1a2";

            string url = $"http://api.openweathermap.org/data/2.5/weather?q={cidade}&units=metric&appid={appId}";

            Tempo? tempo = null;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    Debug.WriteLine("--------------------------------------------------------------------");
                    Debug.WriteLine(json);
                    Debug.WriteLine("--------------------------------------------------------------------");

                    tempo = JsonSerializer.Deserialize<Tempo>(json);                    
                }
            }

            return tempo;
        }
    }
}
