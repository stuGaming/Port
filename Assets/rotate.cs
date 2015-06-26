using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public float rotat;
	public float dir;
	public float mag;
	float origin;
	// Use this for initialization
	void Start () {
		origin = 50;
		rotat = rotat * dir;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//Quaternion x = this.transform.rotation;
		//x.z += mag * dir;
		//if (Mathf.Abs (x.z - origin) > rotat) {
			//dir = dir*-1;
		//}
		//this.transform.rotation = x;
		transform.Rotate(Vector3.right * Time.deltaTime*rotat);
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
		origin++;
		if (origin > 100) {
			rotat = rotat*-1;
			origin = 0;
		}

	}
}
