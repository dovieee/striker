using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {



	// Use this for initialization
	void Start () {

		for (int i = 0; i < DeckInfomation.selectedInfomation.Count; ++i) {
			Debug.Log (DeckInfomation.selectedInfomation [i]);
			// load needed data 
			//DeckItemData data = (DeckItemData)Resources.Load ("Resources/DeckItem/chara" + i.ToString, typeof(DeckItemData));
			// initialize game player data 
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
