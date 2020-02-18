using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEditor;

public class waktubonus1 : MonoBehaviour {

	// Use this for initialization
	public GameObject tombolResume,tombolMenu;
	//public GameObject[] posisi, posisiSampah;
	public TextMesh waktu1, textPaused,angka,jmlSampah,selanjutnya;
	public Animator Anim;
	public Image img;
	public float hitungMundur,countdown;
	float hitungMundur1;
	public static int nilai, jmlbintang, nilai_tertinggi,a;
	bool paused;
	bool pos2, pos3, pos4,pos5;

	void Start () {
		img.gameObject.SetActive (true);
		waktu1 = GameObject.Find("Waktu").GetComponent<TextMesh>();
		tombolResume.SetActive (false);
		tombolMenu.SetActive (false);
		textPaused.gameObject.SetActive (false);
		selanjutnya.gameObject.SetActive (false);
		nilai_tertinggi = PlayerPrefs.GetInt("NTS1");
		jmlbintang = 0;;
		a = 1;
		hitungMundur1 = hitungMundur;

	}

	// Update is called once per frame
	void Update ()
	{
		if (paused) {
			
		} else if (!paused) {
			
			resetScore ();
			waktumulai ();
		}
	}

	void waktumulai(){
		hitungMundur1 -= Time.deltaTime;
		waktu1.text = "Waktu : " + Mathf.Round(hitungMundur1).ToString();
		hitung_score ();
		if (hitungMundur1 < 0) {
			perhitungan ();
		}
	}

	public void Pause(){
		tombolResume.SetActive (true);
		tombolMenu.SetActive (true);
		paused = true;
		textPaused.gameObject.SetActive (true);
	}

	public void Resume(){
		tombolResume.SetActive (false);
		tombolMenu.SetActive (false);
		paused = false;
		textPaused.gameObject.SetActive (false);
	}

	void perhitungan(){
		if (nilai >= 200) {
			if (nilai > nilai_tertinggi) {
				nilai_tertinggi = nilai;
				PlayerPrefs.SetInt ("NTS1", nilai_tertinggi);
				stageLanjut ();
			} else if (nilai >= PlayerPrefs.GetInt ("nilai_level1")) {
				PlayerPrefs.SetInt ("nilai_level1", nilai);
				stageLanjut ();
			} else {
				stageLanjut ();
			}
		} else {
			ScoreAkhir.set_score = nilai;
			ScoreAkhir.set_minimal = 200;
			SceneManager.LoadScene ("gameover");
		}
	}

	void hitung_score(){
		angka.text = "Score : " + nilai;
		jmlSampah.text = "Bintang : " + jmlbintang;
	}

	void stage1_2(){

		SceneManager.LoadScene ("Stage2");
	}

	void stageLanjut(){
		selanjutnya.gameObject.SetActive (true);
		selanjutnya.text = "Score telah memenuhi syarat\n menuju ke level selanjutnya \n" + Mathf.Round (countdown -= Time.deltaTime).ToString ();
		if (countdown < 0) {
			stage1_2();
		}
	}

	void resetScore(){
		if(nilai < 0){
			nilai = 0;
		}
	}
}
