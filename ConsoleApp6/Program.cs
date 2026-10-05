using VideoConverter.Facades;
using VideoConverter.Models;

VideoFile video = new VideoFile("imput/video.mov", "mov");

VideoConverterFacade converter = new VideoConverterFacade();

string result = converter.Converter(video);

Console.WriteLine($"Видео = {result}");