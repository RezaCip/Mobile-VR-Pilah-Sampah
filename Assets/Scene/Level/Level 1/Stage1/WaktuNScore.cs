using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;

public class WaktuNScore : MonoBehaviour {

	// Use this for initialization
	public GameObject tombolResume,tombolMenu,KumpulanSampah;
	public TextMesh waktu1, textPaused,angka,jmlSampah,selanjutnya;
	public float hitungMundur,countdown;
	public static int nilai, sampah, nilai_tertinggi;
	bool paused;

	void Start () {
		waktu1 = GetComponent<TextMesh>();
		KumpulanSampah.SetActive (true);
		tombolResume.SetActive (false);
		tombolMenu.SetActive (false);
		textPaused.gameObject.SetActive (false);
		selanjutnya.gameObject.SetActive (false);
		nilai_tertinggi = PlayerPrefs.GetInt("NTS11");
		sampah = 5;
		nilai = 0;

	}
	
	// Update is called once per frame
	void Update ()
	{
		if (paused) {
			KumpulanSampah.SetActive (false);
		} else if (!paused) {
			KumpulanSampah.SetActive (true);
			resetScore ();
			waktumulai ();
		}
	}

	void waktumulai(){
		hitungMundur -= Time.deltaTime;
		waktu1.text = "Waktu : " + Mathf.Round(hitungMundur).ToString();
		hitung_score ();
		if (hitungMundur < 0||sampah == 0) {
			waktu1.text = "Waktu : 0";
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
	void hitung_score(){
		angka.text = "Score : " + nilai;
		jmlSampah.text = "Sampah : " + sampah;
	}
	void stage1_2(){
		SceneManager.LoadScene ("Stage12");
	}
	void perhitungan(){
		if (nilai >= 60) {
			if (nilai > nilai_tertinggi) {
				nilai_tertinggi = nilai;
				PlayerPrefs.SetInt ("NTS11", nilai_tertinggi);
				stageLanjut ();
			} else {
				stageLanjut ();
			}

		} else {
			ScoreAkhir.set_score = nilai;
			SceneManager.LoadScene ("gameover");
		}
	}
	void stageLanjut(){
		PlayerPrefs.SetInt ("nilai_stage11", nilai);
		selanjutnya.gameObject.SetActive (true);
		selanjutnya.text = "Score telah memenuhi syarat\n lanjut ke stage selanjutnya dalam waktu \n" + Mathf.Round (countdown -= Time.deltaTime).ToString ();
		if (countdown < 0) {
			stage1_2 ();
		}
	}
	void resetScore(){
		if(nilai < 0){
			nilai = 0;
		}
	}
}
