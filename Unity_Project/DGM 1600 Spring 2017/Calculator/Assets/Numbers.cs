﻿using UnityEngine;
using UnityEngine.UI;

public class Numbers : MonoBehaviour {

	public string ButtonText;

	public InputField Value1;

	void start (){
		ButtonText = GetComponentInChildren<Text>().text;	
	}

	public void OnButtonClick(){
		
		Value1.text += ButtonText;
	}

}