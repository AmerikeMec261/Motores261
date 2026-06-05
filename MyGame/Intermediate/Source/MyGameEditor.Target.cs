using UnrealBuildTool;

public class MyGameEditorTarget : TargetRules
{
	public MyGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyGame");
	}
}
