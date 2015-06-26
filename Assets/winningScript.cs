using UnityEngine;
using System.Collections;

public class winningScript : MonoBehaviour {
	public string name;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject temp = GameObject.FindGameObjectWithTag ("player");
		Vector3 x = this.transform.position - temp.transform.position;
		float m = Mathf.Sqrt ((x.x * x.x) + (x.y * x.y) + (x.z * x.z));

		if(m<2)
		{
			Application.LoadLevel (name);
		}
		//print ("runs");
	}

}
