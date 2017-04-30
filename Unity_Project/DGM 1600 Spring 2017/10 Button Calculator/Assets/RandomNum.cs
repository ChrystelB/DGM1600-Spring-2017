using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RandomNum : MonoBehaviour {

	public Text textUI;

	void Start (){
		textUI = GetComponent<Text>();
		textUI.text = Random.Range (1,10).ToString ();
	}
}
