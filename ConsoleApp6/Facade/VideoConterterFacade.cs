using VideoConverter.Models;
using VideoConverter.Services;

namespace VideoConverter.Facades;

public class VideoConverterFacade
{
	private readonly VideoValidation _validation;
	private readonly VideoMetaDataReader _metadataReader;
	private readonly VideoDecoder _decoder;
	private readonly VideoResizer _resizer;
	private readonly VideoEncoder _encoder;
	private readonly VideoStorage _storage;

	public VideoConverterFacade()
	{
		_validation = new VideoValidation();
		_metadataReader = new VideoMetaDataReader();
		_decoder = new VideoDecoder();
		_resizer = new VideoResizer();
		_encoder = new VideoEncoder();
		_storage = new VideoStorage();
	}

	public string Converter(VideoFile video)
	{
		_validation.Validate(video);
		_metadataReader.Reader(video);
		_decoder.Decode(video);
		_resizer.Resize(video, 1920, 1080);
		_encoder.Encode(video, "mp4");
		return _storage.Save(video);
	}
}


