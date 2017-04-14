using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class AddArray : MonoBehaviour {

	public int [] Names = new int[10];
	int i, j;


	// Use this for initialization
	//void Start () {

	
	void addtoArray (GameObject obj) {
			
		for(i = 0; i < 10; i++) {
			Names [i] = i + 1;
		}
/*		for(j = 0; j < 10; j++) {
			Names [j] = j + 1;
}*/
}
}