﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameState{

	// Use this for initialization
	void Start ();
	
	// Update is called once per frame
	void Update ();

	void Finish();
}
