// Copyright 2018 Devlin Willis (ImmutableLambda). All Rights Reserved.

using UnrealBuildTool;

public class GSEduItems : ModuleRules
{
	public GSEduItems(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
		});

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"SlateCore",
			"GameplayTags",
		});

		PrivateDependencyModuleNames.AddRange(new string[]
		{
			"CoreUObject",
			"Engine",
		});
	}
}
