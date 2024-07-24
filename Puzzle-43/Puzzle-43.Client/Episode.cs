namespace Puzzle_43.Client;

public record Episode(int Number, DateOnly PublishDate, string Title)
{

	public string Thumbnail => $"/img/{Number.ToString("00")}-title.jpg";

}
