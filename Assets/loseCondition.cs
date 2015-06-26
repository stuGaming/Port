using UnityEngine;
using System.Collections;

public class loseCondition : MonoBehaviour {
	public float beginY;
	Vector3 start;
	// Use this for initialization
	void Start () {
		beginY = this.transform.position.y;
		start = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs (beginY - this.transform.position.y) >50) {
			this.transform.position = start;
		}
	}
}
