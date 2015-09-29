using UnityEngine;
using System.Collections;

public class PersonalityTracker : MonoBehaviour {

	public int E, I;
	public int S, N;
	public int T, F;
	public int J, P;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addTraitCounter(string Trait){
		Trait = Trait.ToUpper ();
		char[] charArray = Trait.ToCharArray ();
	foreach (char c in charArray) {
			Debug.Log(c);
			if (c.Equals ('E'))
				E++;
			else if (c.Equals ('I'))
				I++;
			else if (c.Equals ('S'))
				S++;
			else if (c.Equals ('N'))
				N++;
			else if (c.Equals ('T'))
				T++;
			else if (c.Equals ('F'))
				F++;
			else if (c.Equals ('J'))
				J++;
			else if (c.Equals ('P'))
				P++;
		}

	}
}
