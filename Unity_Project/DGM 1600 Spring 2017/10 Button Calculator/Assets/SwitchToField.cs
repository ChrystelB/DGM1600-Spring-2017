using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SwitchToField : MonoBehaviour {

	public List<NumButton> numButtons;

	public void SwitchField(){
		foreach (NumButton button in numButtons) {
			button.inputField = GetComponent<InputField> ();
		}
	}
}
