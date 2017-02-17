using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour {
    public int bottles = 0;
    
    void Start () {
       for(int i=99;i>bottles;i--){
            print(i+ "Bottles of Coke on the wall");

    }

}
}