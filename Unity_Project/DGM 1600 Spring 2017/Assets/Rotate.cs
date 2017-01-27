using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
	public int number = 10;
	public int rotSpeed = 10;

	// Use this for initialization
	void Start () {
		Debug.Log(number);

	}
	
	// Update is called once per frame
	void Update () {
		//transform.Rotate (0,2,0);
		transform.Rotate(Vector3.up,rotSpeed*Time.deltaTime);
	
	}
}
