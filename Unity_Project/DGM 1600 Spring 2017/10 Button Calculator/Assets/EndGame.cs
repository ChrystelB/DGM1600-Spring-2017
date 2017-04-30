using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class EndGame : MonoBehaviour {

	public Text endText;


	void OnCollisionEnter(Collision other){
		EndTheGame("Really?");
		other.gameObject.SetActive(false);
	}

	public void EndTheGame(string _s){
		endText.enabled = true;
		endText.text = _s;
	}

}
