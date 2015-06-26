using UnityEngine;
using System.Collections;

public class zap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//print ("runs");
	}
	void OnCollisionEnter (Collision col)
	{
		print (col.gameObject.tag);
		if(col.gameObject.tag== "port")
		{
			Destroy(col.gameObject);
		}
	}
}
