using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Univer;

namespace School
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            List<University> schools = new List<University>();
            schools = await universuty();
            foreach (University school in schools)
            {
                Console.WriteLine($"{school.Name} - {school.Country}");
            }
            Console.WriteLine("Vége");
            Console.ReadLine();
        }           

        private static async Task<List<University>> universuty()
        {
            List<University> school = new List<University>();
            //HttpClient client = new HttpClient();
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://universities.hipolabs.com/search?country=hungary");
            var response = await client.SendAsync(request);
            if (!response.IsSuccessStatusCode)
            {
                string jsonSring = await response.Content.ReadAsStringAsync();
                //var school = University.FromJson(jsonSring);
            }
            return school;
        }
    }
}
