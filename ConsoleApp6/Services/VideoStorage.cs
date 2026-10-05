using VideoConverter.Models;

namespace VideoConverter.Services;

public class VideoStorage
{
	public string Save(VideoFile video)
	{
		string outputPath = "video/jopa.mp4";
		Console.WriteLine($"Сохраняем видео {outputPath}");
		return outputPath;
	}
}