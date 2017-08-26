using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : FieldObj {
	IPlayerState currentState;

	[SerializeField]
	UIDeckItem[] items;
	[SerializeField]
	public DeckItemData DeckItemData;

	// Use this for initialization
	void Start () {

		// set State
		currentState = new WaitState();
		currentState.Start ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void Finish(){
	}

	// State の変更
	public void ChangeState(IPlayerState newState){
		currentState = newState;
	}
}

	