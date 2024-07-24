using Puzzle_43.Client;

public class ServerEpisodeService : IEpisodeService
{
	public Task<Episode> GetEpisode(int number)
	{
		return Task.FromResult<Episode>(null);
	}

	public Task<Episode[]> GetEpisodes()
	{
		return Task.FromResult(Array.Empty<Episode>());
	}
}