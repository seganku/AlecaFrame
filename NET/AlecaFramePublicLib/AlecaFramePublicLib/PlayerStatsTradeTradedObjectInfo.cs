using Newtonsoft.Json;

namespace AlecaFramePublicLib;

public class PlayerStatsTradeTradedObjectInfo
{
	public string name { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string displayName { get; set; }

	public int cnt { get; set; }

	public int rank { get; set; }
}
