//using UnityEngine;
//using System.Collections;


/* arrays are ways of storing the same type of information together.
A good example from the video, is buying an egg carton. When looking at the eggs, 
the eggs wouldn't be that different from the others. Basically the "egg carton" 
would be filled with variables. So, you would write the Name of the Array [then an
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


//Now this part should be the actual script.
/*
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
Which brings us to what a "list" is in coding/scripting language. A list is an object which holds
variables in a specific order. Normally it is stated beforehand the extent to which your list will go to. 
With that, there are many different things that you can do with your list. For instance, you can do the "get"
action, or add, or remove numbers held within the list. A quick example of these type of actions will follow, 
otherwise you can refer to the past arrays and lists. 


List<string> Animals = new List<string>();
{
	Animals.Add("Tiger");
	Animals.Add("TeddyBear");
	Animals.Add("Kangaroo");

// now remove the TeddyBear
	Animals.Remove("TeddyBear");
	Console.WriteLine(fruits.Count);
}

//And there you go! The computer should know automatically to remove the TeddyBear when the action is enacted.

*/
