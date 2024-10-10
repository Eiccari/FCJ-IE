using UnrealBuildTool;

public class Unreal_projekti1ServerTarget : TargetRules
{
	public Unreal_projekti1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Unreal_projekti1");
	}
}
