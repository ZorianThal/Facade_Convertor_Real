using VideoConverter.Models;

namespace VideoConverter.Services;

public class VideoDecoder
{
    public void Decode(VideoFile video)
    {
        Console.WriteLine($"Декодируем видео формата {video.Format}");
    }
}
