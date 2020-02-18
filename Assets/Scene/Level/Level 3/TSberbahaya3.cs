using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSberbahaya3 : MonoBehaviour {

	public TextMesh NotifCocok;
	public TextMesh NotifTidakCocok;


	void Start(){
		NotifCocok.gameObject.SetActive (false);
		NotifTidakCocok.gameObject.SetActive (false);
	}

	public void OnTriggerEnter(Collider collider){
		if (collider.gameObject.name == "Organik") {
			NotifTidakCocok.gameObject.SetActive (true);
			StartCoroutine (NotifTIdakCocokMati());

		}
		if (collider.gameObject.name == "Anorganik") {
			NotifTidakCocok.gameObject.SetActive (true);
			StartCoroutine (NotifTIdakCocokMati());

		}
		if (collider.gameObject.name == "Berbahaya") {
			NotifCocok.gameObject.SetActive (true);
			StartCoroutine (NotifCocokMati());

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
