using VideoConverter.Models;

namespace VideoConverter.Services;

public class VideoEncoder
{
    public void Encode(VideoFile video, string format)
    {
        Console.WriteLine($"Кодируем видео формат {format}");
    }
}
