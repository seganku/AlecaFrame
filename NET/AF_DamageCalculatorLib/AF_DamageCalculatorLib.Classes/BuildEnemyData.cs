using Newtonsoft.Json;

namespace AF_DamageCalculatorLib.Classes;

public class BuildEnemyData
{
	public enum ProtectionType
	{
		None,
		TennoShield,
		TennoArmor,
		TennoFlesh,
		ClonedFlesh,
		FerriteArmor,
		AlloyArmor,
		Machinery,
		Shield,
		ProtoShield,
		Flesh,
		RoboticHealth,
		InfestedHealth,
		InfestedFlesh,
		Fossilized,
		InfestedSinew,
		IndifirentFacade,
		Overguard,
		Unknown
	}

	public enum FilteringGroup
	{
		Grineer,
		Corpus,
		Infested,
		Corrupted,
		Sentient,
		Amalgam,
		Narmer,
		Other,
		Orokin,
		Duviri,
		Murmur,
		All
	}

	public string name;

	public string uniqueName;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double armor;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double health;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double shield;

	public ProtectionType healthType;

	public ProtectionType armorType;

	public ProtectionType shieldType;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double shieldRechargeDelay;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double shieldRechargeRate;

	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public double armourConstant;

	public FilteringGroup group;

	public bool eximus;

	public int baseLevel;

	public int weakspotCoeff = 3;

	public string picture;

	public string description;
}
