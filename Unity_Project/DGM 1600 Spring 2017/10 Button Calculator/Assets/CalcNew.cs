using UnityEngine;
using UnityEngine.UI;


public class CalcNew : MonoBehaviour {


	public InputField Value1;

	public InputField Value2;

	public Text Value3;


	public void CalculatorButton (string _operation){
		float temp = 0;
		switch (_operation) {

		case"+":
			temp = (float.Parse (Value1.text) + float.Parse (Value2.text));
			break;
		case"-":
			temp = (float.Parse (Value1.text) - float.Parse (Value2.text));
			break;
		case"*":
			temp = (float.Parse (Value1.text) * float.Parse (Value2.text));
			break;
		case"/":
			temp = (float.Parse (Value1.text) / float.Parse (Value2.text));
			break;
		
		}
		Value3.text = temp.ToString ();
		Clear ();
			
	}
		
		void Clear(){
			Value1.text = null;
			Value2.text = null;


	}
}