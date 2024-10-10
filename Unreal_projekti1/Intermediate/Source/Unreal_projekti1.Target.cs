using UnrealBuildTool;

public class Unreal_projekti1Target : TargetRules
{
	public Unreal_projekti1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Unreal_projekti1");
	}
}
