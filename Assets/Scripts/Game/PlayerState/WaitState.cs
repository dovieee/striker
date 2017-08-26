using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 待機中STATE
/// </summary>
public class WaitState : IPlayerState{

	// Use this for initialization
	public void Start () {
		Debug.Log ("PlayerState : Wait : Start");
	}
	
	// Update is called once per frame
	public void Update () {
	}

	public void Finish(Player pl){
		Debug.Log ("PlayerState : Wait : Finish");
	}
}
