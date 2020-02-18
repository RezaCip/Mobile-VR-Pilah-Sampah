using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ganti_objek : MonoBehaviour {

	// Use this for initialization
	public GameObject[] Objek;
	int i = 0;
	void Start () {
		StartCoroutine (ganti());
	}

	// Update is called once per frame
	void Update () {
		StartCoroutine (ganti ());
	}

	void gantiObjek(){

	}
	IEnumerator ganti(){
		for (int a = 0; a < Objek.Length; a++) {
			Objek [i].SetActive (true);
			//Objek [i].transform.Rotate (Vector3.up * 100 * Time.deltaTime);
			yield return new WaitForSeconds (3);
			//Objek [i].SetActive (false);
		}
	}
}
