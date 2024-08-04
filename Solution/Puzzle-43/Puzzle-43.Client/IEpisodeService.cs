
namespace Puzzle_43.Client;

public interface IEpisodeService
{
	Task<Episode> GetEpisode(int number);
	Task<Episode[]> GetEpisodes();
}