using UnityEngine;
using System.Collections;

public class pointDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject x = GameObject.FindGameObjectWithTag ("port");
		Vector3 d = x.transform.up;
		this.transform.up = d;
	}
}
