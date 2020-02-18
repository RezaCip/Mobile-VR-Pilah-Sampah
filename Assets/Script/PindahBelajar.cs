using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PindahBelajar : MonoBehaviour {
	float waktuSelesai = 1;
	float waktuTunggu;
	bool dipilih;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dipilih) {
			waktuTunggu += Time.deltaTime;
			Debug.Log (waktuTunggu);
		
		}
	}

	public void Enter(){
		dipilih = true;

	}

	public void Exit(){
		dipilih = false;
		Debug.Log ("exit");
	}
}
