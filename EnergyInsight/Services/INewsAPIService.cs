
namespace EnergyInsight.Services
{
	public interface INewsAPIService
	{
		Task<NewsApiNewResponse> DoSearch(string searchQuery);
	}
}