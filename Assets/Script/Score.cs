using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

	// Use this for initialization

	public GameObject selanjutnya;
	public static int nilai, sampah ;
	public TextMesh angka, jmlsampah;
	void Start () {
		selanjutnya.SetActive (false);
		sampah = 5;
		nilai = 0;
	}
	
	// Update is called once per frame
	void Update () {
		hitung_score ();
	}
	void sampahHabis(){
		if (sampah == 0) {
			selanjutnya.SetActive (true);
		}
	}
	void hitung_score(){
		angka.text = "Score : " + nilai;
		jmlsampah.text = "Sampah : " + sampah;
		sampahHabis ();
	}
}
