using Newtonsoft.Json;

namespace AlecaFramePublicLib;

public class BasicRemoteDataItemData
{
	public string name;

	public string pic;

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string wiki;
}
