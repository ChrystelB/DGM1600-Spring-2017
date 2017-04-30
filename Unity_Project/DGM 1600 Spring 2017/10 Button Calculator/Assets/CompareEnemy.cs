using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;

public class CompareEnemy : MonoBehavior {

	public EndGame endGame;

	public List<RandomNum> randomNums;

	public void CheckRandomNums (string _t){

		for (int i = 0; i< randomNums.Count; i++) {
			if(randomNums[i].textUI.text == _t){
				randomNums[i].gameObject.SetActive(false);
				randomNums.RemoveAt(i);
			}
		}
		if (randomNums.Count <= 0) {
			endGame.EndTheGame("You Win!");
		}

	}

}