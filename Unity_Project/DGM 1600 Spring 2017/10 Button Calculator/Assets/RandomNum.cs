using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class RandomNum : MonoBehavior {

	public Text textUI;

	void Start (){
		textUI = GetComponent<Text> ();
		textUI.text = Random.Range (1,9).ToString ();
	}
}
