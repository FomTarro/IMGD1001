using UnityEngine;
using System.Collections;

public class HoverHighlight : MonoBehaviour {

	[SerializeField]
	private Sprite highlight;
	private Sprite original;
	[SerializeField]
	private SpriteRenderer itemToChange;

	// Use this for initialization
	void Start () {
		original = itemToChange.sprite;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		itemToChange.sprite = highlight;
	}
	void OnMouseExit(){
		itemToChange.sprite = original;
	}
}
