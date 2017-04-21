using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberOne : MonoBehaviour {

	const string one = "1";
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
		Value3.text += "1";
	}
}
