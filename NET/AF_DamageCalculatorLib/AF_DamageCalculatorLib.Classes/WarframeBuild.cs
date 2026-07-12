using System;
using System.Collections.Generic;

namespace AF_DamageCalculatorLib.Classes;

public class WarframeBuild : BaseBuild
{
	public UpgradeSlot auraSlot;

	public List<UpgradeSlot> arcaneSlots;

	public UpgradeSlot exilusSlot;

	public override UpgradeSlot GetSlot(string category, int index)
	{
		return category switch
		{
			"aura" => auraSlot, 
			"exilus" => exilusSlot, 
			"arcane" => arcaneSlots[index], 
			"mod" => modsSlots[index], 
			_ => throw new ArgumentException("Invalid category"), 
		};
	}
}
