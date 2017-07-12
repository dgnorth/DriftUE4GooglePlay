/**
* This file is part of the Drift Unreal Engine Integration.
*
* Copyright (C) 2016-2017 Directive Games Limited. All Rights Reserved.
*
* Licensed under the MIT License (the "License");
*
* You may not use this file except in compliance with the License.
* You may obtain a copy of the license in the LICENSE file found at the top
* level directory of this module, and at https://mit-license.org/
*/

using UnrealBuildTool;
using System.IO;

public class DriftGooglePlay : ModuleRules
{
	public DriftGooglePlay(ReadOnlyTargetRules TargetRules) : base(TargetRules)
    {
		bEnableShadowVariableWarnings = false;
		PCHUsage = PCHUsageMode.NoSharedPCHs;

        PublicIncludePaths.AddRange(
			new string[] {
				"DriftGooglePlay/Public",		
			}
			);
				

		PrivateIncludePaths.AddRange(
			new string[] {
				"DriftGooglePlay/Private",
			}
			);

		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "Projects",
			}
			);

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "CoreUObject",
                "Engine",
                "OnlineSubsystem",
                "OnlineSubsystemUtils",
                "Drift",
            }
            );
    }
}
