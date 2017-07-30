using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YourGameSystemsManager : GameSystemsManager
{
	protected override void AddAdditionalGameSystems()
	{
		// Add your own game systems here
		AddGameSystem(GameSystem.CreateInstance<SayHelloGameSystem>());
		AddGameSystem(GameSystem.InstantiateFromAsset("SomePrefabSpawnerGameSystem"));
	}
}
