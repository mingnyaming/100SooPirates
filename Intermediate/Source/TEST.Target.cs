using UnrealBuildTool;

public class TESTTarget : TargetRules
{
	public TESTTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TEST");
	}
}
