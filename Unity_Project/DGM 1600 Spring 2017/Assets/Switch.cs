using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
    
    void Start () {
        string light = "yellow";

    switch(light){
        case "red":
             print("The light is red-- That means STOP!");
        break;
        case "yellow":
            print("The light is yellow-- That means you will stop soon!");
        break;
        case "green":
            print("The light is green-- You are free to go!");
        break;
        default:
            print( "That's not a valid color");
        break;
    }

    }

}