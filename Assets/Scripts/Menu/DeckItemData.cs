using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class DeckItemData : ScriptableObject {
	public string name;
	public Sprite sprite; 
	public int age;
	public int attack;
	public int hp;

}
