using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonContoh : MonoBehaviour {

	// Use this for initialization
	public GameObject[] contohSampah;
	public GameObject[] kumpulanSampah;
	public GameObject[] materiSampah;
	int angka;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void tampilSampahOrganik(){
		angka = 0;
		contohSampah [angka].SetActive (true);
		kumpulanSampah [angka].SetActive (true);
		materiSampah [angka].SetActive (false);
			

	}
	public void tampilSampahAnorganik(){
		angka = 1;
		contohSampah [angka].SetActive (true);
		kumpulanSampah [angka].SetActive (true);
		materiSampah [angka].SetActive (false);
			

	}
	public void tampilSampahBerbahaya(){
		angka = 2;
		contohSampah [angka].SetActive (true);
		kumpulanSampah [angka].SetActive (true);
		materiSampah [angka].SetActive (false);
			
		
	}
	public void kembali(){
		for (int i = 0; i < contohSampah.Length; i++) {
			contohSampah [i].SetActive (false);
			kumpulanSampah [i].SetActive (false);
			materiSampah [angka].SetActive (true);

		}
	}
}
