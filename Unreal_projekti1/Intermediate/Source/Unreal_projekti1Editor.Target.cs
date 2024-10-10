using UnrealBuildTool;

public class Unreal_projekti1EditorTarget : TargetRules
{
	public Unreal_projekti1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Unreal_projekti1");
	}
}
