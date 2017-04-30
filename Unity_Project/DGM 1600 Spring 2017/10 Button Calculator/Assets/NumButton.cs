using UnityEngine;
using UnityEngine.UI;


public class NumButton : MonoBehaviour {

	private string buttonText;

	public InputField inputField;


	void Start () {
		buttonText = GetComponentInChildren<Text> ().text;

	}
	public void OnButtonClick(){
		inputField.text += buttonText;

	}

}
