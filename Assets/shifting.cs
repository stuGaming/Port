using UnityEngine;
using System.Collections;

public class shifting : MonoBehaviour {
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
	void FixedUpdate () {
		Vector3 x = this.transform.position;
		//x.z += mag * start;
		//if (Mathf.Abs (x.z - original) > shift) {
		//	start = start*-1;
		//}

		//this.transform.position = x;

		x = x + (this.transform.forward*start)*mag;
		shift++;
		if (shift > dist) {
			start = start*-1;
			shift = 0;
		}
		this.transform.position = x;
	}
}
