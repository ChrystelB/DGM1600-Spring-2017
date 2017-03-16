
using UnityEngine;
using System.Collections;


public class Arrays : MonoBehaviour {
	
	public string[] StartUp = [Trees, Bushes, Buildings];


	void Start ()
	{
		StartUp[Trees] = 12;
		StartUp[Bushes] = 30;
		StartUp[Buildings] = 6;
	}
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

public class Arrays : MonoBehaviour {

    public string[] friends = {"Jayson", "Debug", "Bianca","Anthony","Chrystel"};

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