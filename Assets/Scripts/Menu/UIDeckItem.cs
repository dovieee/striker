using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDeckItem : MonoBehaviour {

	[SerializeField]
	Image image;

	[SerializeField]
	DeckItemData item;


	public void OnTap()
	{
		Debug.Log ("Tap : " + gameObject.name);
		DeckInfomation.selectedInfomation.Add (item);
	}
		
	public void SetImage(Sprite sprite)
	{
		image.sprite = sprite;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
