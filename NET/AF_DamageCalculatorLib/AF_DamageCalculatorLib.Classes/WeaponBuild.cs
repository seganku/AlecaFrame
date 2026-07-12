using System;
using System.Collections.Generic;
using AlecaFramePublicLib;

namespace AF_DamageCalculatorLib.Classes;

public class WeaponBuild : BaseBuild
{
	public List<UpgradeSlot> arcane;

	public UpgradeSlot exilusSlot;

	public UpgradeSlot stance;

	public Dictionary<DamageType, double> innateDamages;

	public override UpgradeSlot GetSlot(string category, int index)
	{
		return category switch
		{
			"stance" => stance, 
			"exilus" => exilusSlot, 
			"arcane" => arcane[index], 
			"mod" => modsSlots[index], 
			_ => throw new ArgumentException("Invalid category"), 
		};
	}
}
