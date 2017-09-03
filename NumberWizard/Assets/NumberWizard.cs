using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	private int max =  500;
	private int min =  1;
	private int max2 =  1000;
	private int max3 =  1500;
	private int guess;

	void Start ()
	{
		IntroduceGame ();
	}

	void Update () 
	{
		PlayGame ();
	}

	void IntroduceGame()
	{
		print ("Welcome to number wizard");
		print ("Choose a number to play: " + max + " " + min + ", " + max2 + " " + min+", "+max3 +" " + min);
		print ("A for 500 B for 1000 and C for 1500");
	}

	void PlayGame()
	{
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			guess = Random.Range (min, max);
			print (guess.ToString ());
		} 
		else if (Input.GetKeyDown (KeyCode.B))
		{
			guess = Random.Range (min, max2);
			print (guess.ToString ());
		} 
		else if (Input.GetKeyDown (KeyCode.C)) 
		{
			guess = Random.Range (min, max3);
			print (guess.ToString ());
		}
	}
}
