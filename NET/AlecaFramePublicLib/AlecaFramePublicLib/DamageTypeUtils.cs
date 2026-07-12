namespace AlecaFramePublicLib;

public class DamageTypeUtils
{
	public static ProcType GetProcTypeFromDamageType(DamageType damageType)
	{
		return damageType switch
		{
			DamageType.Impact => ProcType.Impact, 
			DamageType.Puncture => ProcType.Puncture, 
			DamageType.Slash => ProcType.Slash, 
			DamageType.Heat => ProcType.Heat, 
			DamageType.Cold => ProcType.Cold, 
			DamageType.Electricity => ProcType.Electricity, 
			DamageType.Toxin => ProcType.Poison, 
			DamageType.Void => ProcType.Void, 
			DamageType.Blast => ProcType.Blast, 
			DamageType.Corrosive => ProcType.Corrosive, 
			DamageType.Gas => ProcType.Gas, 
			DamageType.Magnetic => ProcType.Magnetic, 
			DamageType.Radiation => ProcType.Radiation, 
			DamageType.Viral => ProcType.Viral, 
			DamageType.Tau => ProcType.Void, 
			_ => ProcType.None, 
		};
	}
}
