using UnityEngine;
using System.Collections;

public class teleport : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse1)) {
			print ("runs");
			GameObject temp = GameObject.FindGameObjectWithTag ("port");
			Vector3 x = temp.transform.position;
			x.y +=2;
			this.transform.position = x;
			DestroyObject(temp);
		}
	}
}
