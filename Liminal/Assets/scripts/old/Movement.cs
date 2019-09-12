using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		float movspeed = 2.0f;
		//gameObject.GetComponent<Rigidbody> ().useGravity = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		float hori = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");

		Vector3 position = this.transform.position;
		if (Input.GetKeyUp (KeyCode.H)) {
			position.y = position.y + 3f;
			this.transform.position = position;
			gameObject.GetComponent<Rigidbody> ().useGravity = true;

		}
		else
		{

			gameObject.GetComponent<Rigidbody> ().useGravity = false;
		}
			
		controller (hori, vert);
	}
	
	void controller (float x,float y)
	{
		transform.position += new Vector3 (x, 0.0f, y);
	}	

}
