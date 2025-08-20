// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class P2Repaso200825 : ModuleRules
{
	public P2Repaso200825(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"P2Repaso200825",
			"P2Repaso200825/Variant_Horror",
			"P2Repaso200825/Variant_Horror/UI",
			"P2Repaso200825/Variant_Shooter",
			"P2Repaso200825/Variant_Shooter/AI",
			"P2Repaso200825/Variant_Shooter/UI",
			"P2Repaso200825/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
