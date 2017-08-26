using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 移動中STATE
/// </summary>
public class MoveState : IPlayerState {

	// Use this for initialization
	public void Start () {
		Debug.Log ("PlayerState : Move : Start");		
	}
	
	// Update is called once per frame
	public void Update () {
	}

	public void Finish(Player pl){
		Debug.Log ("PlayerState : Move : Finish");
		pl.ChangeState(new WaitState());
	}
}
