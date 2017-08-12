using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateContolol {
	State currentState;

	// Use this for initialization
	void Start () {
		currentState.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		currentState.Update ();
	}

	void Finish()
	{
		currentState.Finish();
	}

	void changeState(State newState)
	{
		currentState = newState;
	}
}
