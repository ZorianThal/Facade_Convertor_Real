using VideoConverter.Models;

namespace VideoConverter.Services;

public class VideoMetaDataReader
{
    public void Reader(VideoFile video)
    {
        Console.WriteLine($"Получаем информацию о видео: {video.FilePath}");
    }
}
