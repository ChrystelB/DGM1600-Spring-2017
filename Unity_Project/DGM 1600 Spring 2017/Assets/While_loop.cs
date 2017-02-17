using UnityEngine;
using System.Collections;

public class While_loop : MonoBehaviour {
    public int ammo = 0;
    
    void Start () {
        while(ammo< 12){
            ammo ++;
            print( "Loading Round" + ammo);
            

        } 
        


    }

}