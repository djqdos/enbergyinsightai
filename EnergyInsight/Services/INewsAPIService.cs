
namespace EnergyInsight.Services
{
	public interface INewsAPIService
	{
		Task<NewsAPIResponse> DoSearch(string searchQuery);
	}
}