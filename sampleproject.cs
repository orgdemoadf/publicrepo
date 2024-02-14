using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        // URL to extract data from
        string url = "https://www.example.com";

        // Create an HttpClient instance
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                // Make a GET request to the URL
                HttpResponseMessage response = await httpClient.GetAsync(url);

                // Check if the request was successful
                if (response.IsSuccessStatusCode)
                {
                    // Read the content of the response
                    string content = await response.Content.ReadAsStringAsync();

                    // Display the extracted data
                    Console.WriteLine("Data extracted from the URL:");
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
