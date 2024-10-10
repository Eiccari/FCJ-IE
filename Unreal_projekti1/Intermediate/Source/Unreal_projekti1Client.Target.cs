using UnrealBuildTool;

public class Unreal_projekti1ClientTarget : TargetRules
{
	public Unreal_projekti1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Unreal_projekti1");
	}
}
