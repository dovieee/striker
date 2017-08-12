using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIDeck : MonoBehaviour {

	[SerializeField]
	UIDeckItem[] items;
	[SerializeField]
	DeckItemData[] dataArray;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < items.Length; ++i) {
			if (items [i] == null) {
				continue;
			}
			items [i].SetImage (dataArray[i].sprite);
			// setage
			// setname 
		}
	}
	
	// Update is called once per frame
	void Update () {
		// if selected > 4 
		// goto game
		if (Input.GetKey (KeyCode.Space)) {
			SceneManager.LoadScene ("game");
		}
	}
}
