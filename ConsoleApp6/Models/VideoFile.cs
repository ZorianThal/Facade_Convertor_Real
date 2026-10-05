namespace VideoConverter.Models;

public class VideoFile
{
    public string FilePath { get; }
    public string Format { get; }

    public VideoFile(string filePath, string format)
    {
        FilePath = filePath;
        Format = format;
    }
}