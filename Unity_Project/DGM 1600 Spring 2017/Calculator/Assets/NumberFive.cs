using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberFive : MonoBehaviour {

	const string five = "5";
	public InputField Value1;
	public InputField Value3;
	public Button yourButton;


	// Use this for initialization
	void Start () {
		Button btn = yourButton.GetComponent<Button> ();
		btn.onClick.AddListener (SetNumber);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SetNumber (){
		Value3.text += "5";
	}
}
