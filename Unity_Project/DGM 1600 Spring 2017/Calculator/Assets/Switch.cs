using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour {

	public List<Numbers> numbers;

	public void SwitchField(){
		foreach (Numbers button in numbers) {
			button.Value1 = GetComponent<InputField> ();

		}
	} 


}
