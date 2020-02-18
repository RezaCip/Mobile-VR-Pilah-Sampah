using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambil : MonoBehaviour {

	// Use this for initialization
	public Transform destinasi;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pickup(){
		if (Input.GetButtonDown("Fire1")) {
			//GetComponent<Rigidbody> ().useGravity = false;
			this.transform.position = destinasi.position;
			this.transform.parent = GameObject.Find ("tempat").transform;
			//checkDrop ();
		}
	}
	void checkDrop() {
		if (Input.GetButtonDown("Fire1")) {
			this.transform.parent = null;
			//GetComponent<Rigidbody> ().useGravity = true;
		}
	}

}