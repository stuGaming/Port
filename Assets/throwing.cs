using UnityEngine;
using System.Collections;

public class throwing : MonoBehaviour {
	public GameObject t;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject s = GameObject.FindGameObjectWithTag("port");
			//DestroyObject(s);
			if(s!=null){
				print (s.tag);
				s.tag = "oldPort";
			}
			print ("runs2");
			Vector3 dir = this.transform.forward;
			dir = dir*2;
			print (dir);


			Instantiate(t, this.transform.position, this.transform.rotation);
			GameObject r = GameObject.FindGameObjectWithTag("port");
			r.rigidbody.AddForce(dir*1000);
		
		}
	}
}
