﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PersonalityTracker : MonoBehaviour {

	public int E, I;
	public int S, N;
	public int T, F;
	public int J, P;


	[SerializeField]
	private Sprite Es, Is, Ss, Ns, Ts, Fs, Js, Ps;

	[SerializeField]
	private Text Et, It, St, Nt, Tt, Ft, Jt, Pt;

	[SerializeField]
	private Toggle valueShower;

	[SerializeField]
	private SpriteRenderer Head, Torso, Left, Right, Eyes;

	private string finalType = "";

	private string finalTypeList = "";

	private List<string> listOfEnds = new List<string> ();

	private bool all = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}


	public void setPriorTypeList(string oldLists){
		finalTypeList =  "";
		finalTypeList += oldLists;
		Debug.Log (finalTypeList);
	}

	public string listToString(){
		foreach (string s in listOfEnds) {
			finalTypeList+= (" " + s + "\n");
		}
		Debug.Log (finalTypeList);
		return finalTypeList;
	}
	

	public bool typeContains(char C){
		char[] charArray = finalType.ToCharArray ();
		foreach (char c in charArray) {
			if(c.Equals(C))
				return true;
		}
		return false;
	}

	public void toggleValues(bool changed){
		Et.gameObject.SetActive (changed);
		It.gameObject.SetActive (changed); 
		St.gameObject.SetActive (changed); 
		Nt.gameObject.SetActive (changed); 
		Tt.gameObject.SetActive (changed);
		Ft.gameObject.SetActive (changed);
		Jt.gameObject.SetActive (changed);
		Pt.gameObject.SetActive (changed);
	}

	public void addTraitCounter(string Trait){
		Trait = Trait.ToUpper ();
		char[] charArray = Trait.ToCharArray ();
	foreach (char c in charArray) {
			Debug.Log(c);
			if (c.Equals ('E')){
				E++;
				Et.text = "E:"+E;
			}
			else if (c.Equals ('I')){
				I++;
				It.text = "I:"+I;
			}
			else if (c.Equals ('S')){
				S++;
				St.text = "S:"+S;
			}
			else if (c.Equals ('N')){
				N++;
				Nt.text = "N:"+N;
			}
			else if (c.Equals ('T')){
				T++;
				Tt.text = "T:"+T;
			}
			else if (c.Equals ('F')){
				F++;
				Ft.text = "F:"+F;
			}
			else if (c.Equals ('J')){
				J++;
				Jt.text = "J:"+J;
			}
			else if (c.Equals ('P')){
				P++;
				Pt.text = "P:"+P;
			}
		}

	}

	public bool unlockSecret(){
		if (finalTypeList.Length == 112) {
			all = true;
		}
		return all;
	}

	public string forceValues(int e, int i, int s, int n, int t, int f, int j, int p){
		E = e;
		I = i;
		S = s;
		N = n;
		T = t;
		F = f;
		J = j;
		P = p;

		return tallyItUp ();
	}


	public string tallyItUp(){
		finalType = "";
		if (E >= I) {
			Left.sprite = Es;
			Right.sprite = Es;
			finalType += "E";
		} else if (I > E) {
			Left.sprite = Is;
			Right.sprite = Is;
			finalType += "I";
		}

		if (S >= N) {
			Eyes.sprite = Ss;
			finalType += "S";
		} else if (N > S) {
			Eyes.sprite = Ns;
			finalType += "N";
		}

		if (T >= F) {
			Head.sprite = Ts;
			finalType += "T";
		} else if (F >= T) {
			Head.sprite = Fs;
			finalType += "F";
		}

		if (J >= P) {
			Torso.sprite = Js;
			finalType += "J";
		} else if (P > J) {
			Torso.sprite = Ps;
			finalType += "P";
		}
		Debug.Log (finalType + " is your final type");
		/*
		if (!listOfEnds.Contains (finalType)) {
			listOfEnds.Add(finalType);
		}
		*/

		if (!finalTypeList.Contains (finalType))
			finalTypeList += " " + finalType + "\n";

		string temp = finalType;
		finalType = "";
		I = E = S = N = T = F = J = P = 0;
		return temp;
	}

	public string getList(){
		Debug.Log (finalTypeList);
		return finalTypeList;
	}

}
