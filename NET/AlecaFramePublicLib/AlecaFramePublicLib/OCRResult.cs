using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlecaFramePublicLib;

public class OCRResult
{
	[NonSerialized]
	public OCRResultCode resultCode;

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public string text { get; set; }

	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public List<OCRResultBox> boxes { get; set; }
}
