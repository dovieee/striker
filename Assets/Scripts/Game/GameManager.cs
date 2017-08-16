using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	[SerializeField]
	UIDeckItem[] items;
	[SerializeField]
	DeckItemData[] dataArray;
	[SerializeField]
	Player[] players;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < DeckInfomation.selectedInfomation.Count; ++i) {
			Debug.Log (DeckInfomation.selectedInfomation [i]);
			var selected = DeckInfomation.selectedInfomation [i];

			// initialize game player data
			players[i].DeckItemData = selected;
			players [i].GetComponent<SpriteRenderer> ().sprite = selected.sprite;


		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
