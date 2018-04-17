// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class HurricaneOfTanksEditorTarget : TargetRules
{
	public HurricaneOfTanksEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "HurricaneOfTanks" } );
	}
}
