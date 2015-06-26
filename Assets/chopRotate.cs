using UnityEngine;
using System.Collections;

public class chopRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*1000);
		//transform.Rotate(Vector3.right * Time.deltaTime, Space.World);
	}
}
