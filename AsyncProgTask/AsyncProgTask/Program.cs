using System.Diagnostics;
//    Task 1.Mueyyen link toplusuna(hansi linkleri isteyirsizse goturun)
//1.Non-async sorğu ataraq ümumi vaxtı yoxlayın.
//2.Async sorğu ataraq ümumi vaxtı yoxlayın

namespace AsyncProgTask


{
    internal class Program
    {
        static async Task Main(string[] args)
        {
           
            string[] links = { "https://www.code.edu.az", 
                               "https://www.google.com",
                               "https://www.microsoft.com" };

            // noon-async
            

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Non-async sorğuların vaxtı:");

            foreach (string link in links)
            {
                await GetHttpContentNonAsync(link);
            }
            stopwatch.Stop();
            Console.WriteLine($"Non-async toplam vaxt: {stopwatch.ElapsedMilliseconds} ms\n");

            // vaxt olcen yer
            stopwatch.Restart();
            Console.WriteLine("Async sorğuların vaxtı:");

            foreach (string link in links)
            {
                await GetHttpContentAsync(link); 
            }
            stopwatch.Stop();
            Console.WriteLine($"Async toplam vaxt: {stopwatch.ElapsedMilliseconds} ms");
        }

        
        static async Task<string> GetHttpContentNonAsync(string url)
        {
            HttpClient client = new HttpClient(); 
            Task<string> response = client.GetStringAsync(url);
            return await response;
        }

        // async hisse
        static async Task GetHttpContentAsync(string url)
        {
            HttpClient client = new HttpClient(); 
            await client.GetStringAsync(url); 
        }
    }
}
