using UnityEngine;
using System.Collections;

public class HoverHighlight : MonoBehaviour {
	
	[SerializeField]
	private SpriteRenderer itemToChange;

	// Use this for initialization
	void Start () {
	}

	void OnMouseEnter(){
		itemToChange.color = Color.cyan;
	}
	void OnMouseExit(){
		itemToChange.color = Color.white;
	}
}
