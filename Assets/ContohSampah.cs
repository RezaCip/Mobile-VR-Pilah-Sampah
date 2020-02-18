using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContohSampah: MonoBehaviour {

	// Use this for initialization
	public GameObject[] contohSampah;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		berputar ();
	}

	void berputar(){
		for (int i = 0; i < contohSampah.Length; i++) {
			contohSampah[i].transform.Rotate (0, 3, 0);
		}
	}
}
