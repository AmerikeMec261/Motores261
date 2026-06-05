using UnrealBuildTool;

public class MyGameServerTarget : TargetRules
{
	public MyGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyGame");
	}
}
