using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Book;

namespace book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            books();
            Console.WriteLine("Vége");
            Console.ReadLine();
        }
        private static async Task books()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://openlibrary.org/api/books?bibkeys=ISBN:0201558025,LCCN:93005405&format=json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
