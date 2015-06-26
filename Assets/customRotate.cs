using UnityEngine;
using System.Collections;

public class customRotate : MonoBehaviour {
	public float mag;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime*mag);
		//transform.Rotate(Vector3.right * Time.deltaTime, Space.World);
	}
}
