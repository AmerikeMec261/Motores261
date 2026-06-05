using UnrealBuildTool;

public class MyGameClientTarget : TargetRules
{
	public MyGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyGame");
	}
}
