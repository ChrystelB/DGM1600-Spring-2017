/*02/16/17

Switch statements: When you want to compare a single variable to a series of
contestants. Simpler than adding a bunch of if-statements. Saves a lot of time 
and a lot less cumbersome. The script will be able to tell the character what 
the value is, and what to do with it. 


Switch (variable) - that will be compared. {
	Case (5 - constant);
		Print (“Sup dog!”)
		Break; (only used in functions and loops);
	Case 4;
		Print (“Erm.. How can I help you?”);
		Break;
	Case 3;
		Print (“Why hello there!”);
		Break;
	Case 2;
		Print (“How may I be of assistance?”);
		Break;
	Case 1;
		Print (“Good morning monsieur.”);
		Break;

(Always use a default in case there is an error)
	Default;
		Print (Intelligence level too high!)
		break;
}


Looping: A way of repeating. Instead of writing the same thing over and over
with a slight number différence, you only need to write the first and last 
numbers. The code will figure out the rest, especially if you put a more than
or less than sign, so the computer knows when to stop. There’s the ‘while’ loop
and the ‘for’ loop. The “Do” while loops always loops at least once. The “For”
while loop is very useful for loops that involve counting. The “Foreach” Loop 
you can’t modify the components in the loop.

(The WHILE LOOP)

Int CupsInTheSink = 4;

Void Start ()
{
	While (CupsInTheSink > 0)
	{
		Debug.Log (I’ve washed a cup!”);  - Now every time a “cup” is washed, this statement will pop up.
		CupsInTheSink--;
}
}

(The DOWHILE LOOP)

public class DoWhileLoop : MonoBehaviour 
{
    void Start()
    {
        bool shouldContinue = false;
        
        do
        {
            print ("Hello World");
            
        }while(shouldContinue == true);
    }
}



/* (The FORLOOP) - The For while loop is very useful for loops that involve counting. When the trigger in enacted,
the computer knows to start or restart the loop. This type of looping includes all of the normal characteristics
of a normal loop, including breaks, block statements, etc. In this instance, "i" will only count the numEnemies before
the loop decides to quite. The number of "enemies" is three.

public class ForLoop : MonoBehaviour
{
 	   int numEnemies = 3;



  	  void Start ()
   	 {
     	   for(int i = 0; i < numEnemies; i++)
	        {
    	        Debug.Log("Creating enemy number: " + i);
	        }
 	   }
	   /* Output:
	   1
	   2
	   3
	   */
	   //The Output will always account the "i" as the number one, and will thus be used in every circumstance. 
}



(The FOREACH LOOP)


public class ForeachLoop : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}
*/
