using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jalan : MonoBehaviour {

	public static bool pos2, pos3, pos4,pos5;
	// Use this for initialization
	void Start () {
		pos2 = false;
		pos3 = false;
		pos4 = false;
		pos5 = false;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (pos2) {
			pindahPos2 ();
		}
	}
	public void pindahPos2(){
		transform.position += transform.forward * 0.05f;
		if (transform.position.z < 0) {

			Debug.Log ("stop");
		}
	}

}
