using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumoApi
{
    class Program
    {
        static void Main(string[] args)
        {
            InvocarAPI();
        }

        private static async void InvocarAPIasync()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://192.168.1.77/TallerPublicacion");
            var request = await client.GetAsync("/api/Publicacion");

            if (request.IsSuccessStatusCode)
            {
                var response = await request.Content.ReadAsStringAsync();
            }
        }

        private static void InvocarAPI()
        {
            HttpClient client = new HttpClient();


            client.BaseAddress = new Uri("http://192.168.1.77/TallerPublicacion");
            var request =  client.GetAsync("/api/Publicacion").Result;

            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Publicacion>>(responseJson);

                foreach(var item in response)
                {
                    Console.WriteLine(item);
                }

                Console.ReadLine();
            }
        }
    }
}
