﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GameStateMenu))]

public class GameModeMenu : GameMode {

	public override void RespawnPlayer(Vector3 location, Quaternion rotation)
	{
		//do nothing
	}
}
