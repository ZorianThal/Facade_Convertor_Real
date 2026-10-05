using VideoConverter.Models;

namespace VideoConverter.Services;

public class VideoResizer
{
    public void Resize(VideoFile video, int width, int height)
    {
        Console.WriteLine($"Изменяем разрешение на {width}x{height}.");
    }
}