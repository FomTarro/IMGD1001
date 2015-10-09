using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AssemblerPuzzle : MonoBehaviour {

	public string puzzleSet = "FJ";

	private string[] puzzleOptions = {"FJ", "FP", "TJ", "TP"};

	[SerializeField]
	private SpriteRenderer head, physHead;

	[SerializeField]
	private SpriteRenderer torso, physTorso;

	private string[] currentSet = {"F", "J"};

	[SerializeField]
	private Sprite[] HeadSprites = new Sprite[2];

	[SerializeField]
	private Sprite[] TorsoSprites = new Sprite[2];

	private int index = 0;

	// Use this for initialization
	void Start () {
		index = Random.Range (0, 4);
		puzzleSet = puzzleOptions [index];
		if (index == 0 || index == 1)
			head.sprite = HeadSprites [0];
		else
			head.sprite = HeadSprites [1];

		if (index == 0 || index == 2)
			torso.sprite = TorsoSprites [0];
		else
			torso.sprite = TorsoSprites [1];
	}

	public void headSwap(){
		if (physHead.sprite.Equals (HeadSprites [0])) {
			physHead.sprite = HeadSprites [1];
			currentSet[0] = "T";
		}
		else if(physHead.sprite.Equals (HeadSprites [1])) {
			physHead.sprite = HeadSprites [0];
			currentSet[0] = "F";
		}
	}

	public void bodySwap(){
		if (physTorso.sprite.Equals (TorsoSprites [0])) {
			physTorso.sprite = TorsoSprites [1];
			currentSet[1] = "P";
		}
		else if(physTorso.sprite.Equals (TorsoSprites [1])) {
			physTorso.sprite = TorsoSprites [0];
			currentSet[1] = "J";
		}
	}

	public string getDesiredCombo(){
		return puzzleSet;
	}

	public string getCurrentCombo(){
		return currentSet [0] + currentSet [1];
	}

	// Update is called once per frame
	void Update () {
	
	}
}
