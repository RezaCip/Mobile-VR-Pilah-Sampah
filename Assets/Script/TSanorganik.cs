﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSanorganik : MonoBehaviour {

	//PickupObject a;
	public TextMesh NotifCocok;
	public TextMesh NotifTidakCocok;

	void Start(){
		NotifCocok.gameObject.SetActive (false);
		NotifTidakCocok.gameObject.SetActive (false);

	}

	void OnTriggerEnter(Collider collider){
		
		if (collider.gameObject.name == "Organik") {
			NotifTidakCocok.gameObject.SetActive (true);
			StartCoroutine (NotifTIdakCocokMati());
		}
		if (collider.gameObject.name == "Anorganik") {
			NotifCocok.gameObject.SetActive (true);
			StartCoroutine (NotifCocokMati());
		}
		if (collider.gameObject.name == "Berbahaya") {
			NotifTidakCocok.gameObject.SetActive (true);
			StartCoroutine (NotifTIdakCocokMati());
		}
	}
	IEnumerator NotifCocokMati(){
		yield return new WaitForSeconds (1f);
		NotifCocok.gameObject.SetActive (false);
	}
	IEnumerator NotifTIdakCocokMati(){
		yield return new WaitForSeconds (1f);
		NotifTidakCocok.gameObject.SetActive (false);
	}
}
