using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Calculator : MonoBehaviour {

int a = 0;
int b = 0;
int c = 0;

public InputField A;
public InputField B;
public Text C;

public Button calcButton;

void Start(){
        Button btn = calcButton.GetComponent<Button>();
      // btn.onClick.AddListener(Addition);
}

void Addition()
{
    a = int.Parse(A.text);
    b = int.Parse(B.text);
    
    C.text = (a + b).ToString();
}
}