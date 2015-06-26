using UnityEngine;
using System.Collections;

public class look : MonoBehaviour {

	public int x = 6;
	public Transform target;
	//the enemy's target var moveSpeed = 3; //move speed var rotationSpeed = 3; //speed of turning
	public int movespeed ;
	public int rotationSpeed ;
	public Transform enemy ;
	public float lookAtDistance ;
	public int damping ;
	public float Distance;
	public int attackRange;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

			lookAt ();
	

	}
	void lookAt(){
		enemy.rotation = Quaternion.Slerp (enemy.rotation,Quaternion.LookRotation (target.position - enemy.position),Time.deltaTime*damping);
		
	}
	void attack(){
		enemy.Translate (Vector3.forward * movespeed * Time.deltaTime);
		
	}
}
