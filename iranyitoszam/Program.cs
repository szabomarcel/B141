using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using iranyitoszam;

namespace iranyitoszam
{
    internal class Program
    {
        static PostaCode postCode = null;
        static async Task Main(string[] args)
        {
            string keresettIranyitoszam = "4200";
            await irszam(keresettIranyitoszam);
            Console.WriteLine($"{postCode.Places[0].PlaceName.ToString()} település irányítószáma: {keresettIranyitoszam}");
            Console.WriteLine($"{postCode.Places[0].State} megye");
            Console.WriteLine($" Google Maps link: https://www.google.com/maps/place/{postCode.Places[0].Latitude},{postCode.Places[0].Longitude}");
            Console.WriteLine("Vége");
            Console.ReadLine();
        }
        private static async Task irszam(string irszama)
        {
            string url = $"http://api.zippopotam.us/us/98121{irszama}";
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonString = await response.Content.ReadAsStringAsync();
            postCode = PostaCode.FromJson(jsonString);
        }
    }
}
