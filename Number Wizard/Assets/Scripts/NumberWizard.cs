using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max = 1000, min = 1, guess=500;
	void Start () {
		StartGame ();

	}

	void StartGame()
	{
		max++;
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");

		print("The highest number you can pick is " + max + "and the lowest is " + min);
		print ("Is the number lower or higher than "+guess+"?");
		print ("UP for higher,DOWN for lower, Return for equal");
	}



	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up Arrow pressed");
			min = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down Arrow pressed");
			max = guess;
			NextGuess ();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I Win!");
		}

	}
	void NextGuess(){
		guess = (max + min) / 2;
		print ("higher or lower than " + guess + "?");
		print ("UP for higher,DOWN for lower, Return for equal");
	}
}

