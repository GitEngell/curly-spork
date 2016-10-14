using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Nito.AsyncEx;

namespace MobbingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncContext.Run(() => MainAsync(args));
        }

        static async void MainAsync(string[] args)
        {
            var page = "http://localhost:9192/MyRestService.svc/GetProductList/";
            var client = new HttpClient();
            var response = await client.GetAsync(page);
            var content = response.Content;
            var result = content.ReadAsStringAsync();

            Console.WriteLine(result.Result);

            Console.WriteLine("Finished");
            Console.ReadLine();
        }
    }
}
