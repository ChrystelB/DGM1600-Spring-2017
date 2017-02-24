using UnityEngine;
using System.Collections;


/* arrays are ways of storing the same type of information together.
A good example from the video, is buying an egg carton. When looking at the eggs, 
the eggs wouldn't be that different from the others. Basically the "egg arton" 
would be filled with variables. So, you would write the Name of the Array[then an
index value] = value of integer. Here is a few examples.

(One way to write it out)


public class Arrays : MonoBehaviour {
	
	int[] myIntArray = new int[5];


	void Start ()
	{
		myIntArray[0] = 12;
		myIntArray[0] = 13;
		myIntArray[0] = 14;
	myIntArray[0] = 15;
	}

/*
An easier way of doing it would be to list the integers in the same parenthesis. 

For example...



public class Arrays : MonoBehaviour {
	
	int[] myIntArray = {12,76,8,937,903};


	void Start ()
	{
		myIntArray[4] = 57;

	}
}
*/

//Now this part should be the actual script.

public class Arrays : MonoBehaviour {

    public string[] friends = {"Jayson", "Debug", "Bianca","Anthony","Chrystel};

	void Start ()
	{
		for(int i = 0; i < friends.Length; i++)
		{
            print("Hey there " + friends[i] + "!!");
        }

	}
}
