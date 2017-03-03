using UnityEngine;
using System.Collections;


/* In scripting, taking or looking at the scope of something is litterally looking at the "scope" 
 of the section decribed. Basically anything within the brackets of a higher class. For instance, 
 with the example below, between the brackets after "MonoBehaviour" and the end of the code. That 
 would be a scope. We could also look at the brackets after "void Start" and the second to last
 bracket. That would also be considered as a scope.


public class Scopes : MonoBehaviour {

    public string[] friends = {"Jayson", "Debug", "Bianca","Anthony","Chrystel};

	void Start ()
	{
		for(int i = 0; i < friends.Length; i++)
		{
            print("Hey there " + friends[i] + "!!");
        }

	}
}

*/
/*
    Access Modifiers are just about as easy to define. When we look at the script above, we see the word
    public. A Modifier is simply going to tell us right away what type of actions the computer should imply
    when looking at the script. It can be public, private, protected or internal. Basically it tells the computer, 
    and other people whether they can have access to your script or not. 
*/