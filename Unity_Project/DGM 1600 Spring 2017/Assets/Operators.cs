/*
using UnityEngine;
using System.Collections;

public class Operators : MonoBehaviour {
    public int one = 5;
    public int two = 2;
    private float modulusReturn;

	// Use this for initialization
	void Start () {

    //Assignment (=) Assignment operator - the equal sign actually gives the variable a value.
        //public int one = 5
    //Addition (+) addition operator - Adds the values given for the variable together. 
        Debug.Log(one + two);
    //Modulus(%) Modulus operator - This one is interesting. It take the remainder of the 
    //value after it is divded.
        Debug.Log(mod=one % two);
    //Subtraction (-) subtraction operator - Subtracts the values given for the vairables.
        Debug.Log(one - two);
    //Division (/) division operator - Divides the values shown in the order written. 
        Debug.Log(one/two);
    //Increment (++) increment - tells the computer to upgrade the value
    //by one (or another variable).
        Debug.Log(one++);
    //Multiply (*) Multplying operator - multiplies the values given for the vairables.
        Debug.Log(one*two);
	}
	
	// Update is called once per frame
	void Update () {
		

	}
}

/* Math Operators are simple ways of letting the computer know the
functions of specific operations. For example, if I want the character
to move five spaces every time I hit a certain button, I would say "x + 5".
Everytime that button is hit, the object would moves five integers.
    Also, it's another way to tell the computer what comes next. If "one" is hit(value=5),
then two must be subtracted from it (value 2). The end result would tell the computer that
the new value is now 3. (5-2) These type of functions are incredibly helpful, because 
without the aid of the functions, the game would essentially not know what to do next. 
*/