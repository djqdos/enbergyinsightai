using Microsoft.AspNetCore.Mvc.Formatters;

namespace EnergyInsight.Services
{
	public class NewsAPIService : INewsAPIService
	{
		private HttpClient _client;
		private string API_KEY = "pub_4462399a7036bfdc2e24b59be1909637f57c7";

		public NewsAPIService(HttpClient client)
		{
			_client = client;
		}

		public async Task<NewsApiNewResponse> DoSearch(string searchQuery)
		{

			var url = $"https://newsdata.io/api/1/news?apikey={API_KEY}&q={searchQuery}";

			try
			{
                var response = await _client.GetFromJsonAsync<NewsApiNewResponse>(url);
				return response!;
			}
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"Request error: {httpEx.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                throw;
            }

            return null;
		}


	}
}
