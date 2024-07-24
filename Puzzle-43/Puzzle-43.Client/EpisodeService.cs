using System.Net.Http.Json;

namespace Puzzle_43.Client;

public class EpisodeService(HttpClient Client) : IEpisodeService
{

	public async Task<Episode[]> GetEpisodes()
	{
		return await Client.GetFromJsonAsync<Episode[]>("/api/episodes");
	}

	public async Task<Episode> GetEpisode(int number)
	{
		return await Client.GetFromJsonAsync<Episode>($"/api/episodes/{number}");
	}

}