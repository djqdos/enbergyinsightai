namespace EnergyInsight.Services
{
	public class NewsAPIService : INewsAPIService
	{
		private HttpClient _client;
		private string API_KEY = "d9f2e6df5a244c18b31eb255e7bc1cf2";

		public NewsAPIService(HttpClient client)
		{
			_client = client;
		}

		public async Task<NewsAPIResponse> DoSearch(string searchQuery)
		{

			var url = $"https://newsapi.org/v2/everything?q={searchQuery}&from=2024-05-20&to=2024-05-20&sortBy=popularity&apiKey={API_KEY}";

			try
			{
				var response = await _client.GetFromJsonAsync<NewsAPIResponse>(url);
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
