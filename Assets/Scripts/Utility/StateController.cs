using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateContolol {
	IState currentState;

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

	void changeState(IState newState)
	{
		currentState = newState;
	}
}
