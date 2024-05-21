using EnergyInsight.Services;
using FluentAssertions;

namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public async void NewsServiceAPI_GetResponse()
		{
			HttpClient c = new HttpClient();
			var newsService = new NewsAPIService(c);

			var response = await newsService.DoSearch("Tesla");


			response.Should().NotBeNull();
		}
	}
}