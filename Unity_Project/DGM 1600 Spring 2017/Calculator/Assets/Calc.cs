﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calc : MonoBehaviour {

	public InputField Value1;
	public InputField Value2;
	public InputField Value3;

	public Button yourButton;

	public enum Operation {Add, Sub, Mul, Div};
	public Operation currentOperation;

	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (Calculate);

		string name = btn.name;
		switch (name){
		case "Add":
			currentOperation = Operation.Add;
			break;
		case "Sub":
			currentOperation = Operation.Sub;
			break;
		case "Mul":
			currentOperation = Operation.Mul;
			break;
		case "Div":
			currentOperation = Operation.Div;
			break;
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void Calculate() {
		float x = 0;
		float y = 0;
		float result = 0;
		if (float.TryParse (Value1.text, out x) && float.TryParse (Value2.text, out y)) {
			switch (currentOperation){
			case Operation.Add:
				result = x + y;
				break;
			case Operation.Sub:
				result = x - y;
				break;
			case Operation.Mul:
				result = x * y;
				break;
			case Operation.Div:
				if (y != 0)
					result = x / y;
				break;
			}
		}
		else
			result = 0;
		Value3.text = result.ToString();
	}
}
/*
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickExample : MonoBehaviour
{
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
*/