using UnityEngine;
using System.Collections;

public class shiftRight : MonoBehaviour {
	public float shift;
	public float mag;
	public float dist;
	public float start;
	float original;
	// Use this for initialization
	void Start () {
		shift = dist / 2f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 x = this.transform.position;
		
		x = x + (this.transform.right*start)*mag;
		shift++;
		if (shift > dist) {
			start = start*-1;
			shift = 0;
		}
		this.transform.position = x;
	}
}
