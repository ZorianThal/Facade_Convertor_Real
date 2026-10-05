using VideoConverter.Models;

namespace VideoConverter.Services;

public class VideoValidation
{
    public void Validate(VideoFile video)
    {
        if (string.IsNullOrWhiteSpace(video.FilePath))
        {
            throw new ArgumentException("Путь не верный");
        }

        Console.WriteLine("Видео прошло проверку.");
    }
}
