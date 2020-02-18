using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEditor;

public class waktu3 : MonoBehaviour {

	// Use this for initialization
	public GameObject tombolResume,tombolMenu,KumpulanSampah;
	public GameObject[] posisi, posisiSampah;
	public TextMesh waktu1, textPaused,angka,jmlSampah,selanjutnya;
	public float hitungMundur,countdown,kecepatan;
	float hitungMundur1;
	public Animator Anim;
	public Image img;
	public static int nilai, sampah, nilai_tertinggi,a;
	bool paused;
	bool pos2, pos3, pos4,pos5;

	void Start () {
		img.gameObject.SetActive (true);
		waktu1 = GameObject.Find("Waktu").GetComponent<TextMesh>();
		KumpulanSampah.SetActive (true);
		tombolResume.SetActive (false);
		tombolMenu.SetActive (false);
		textPaused.gameObject.SetActive (false);
		selanjutnya.gameObject.SetActive (false);
		nilai_tertinggi = PlayerPrefs.GetInt("NTS3");
		sampah = 5;
		nilai = 0;
		a = 1;
		hitungMundur1 = hitungMundur;

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
		hitungMundur1 -= Time.deltaTime;
		waktu1.text = "Waktu : " + Mathf.Round(hitungMundur1).ToString();
		hitung_score ();
		if (hitungMundur1 < 0 || sampah == 0) {
			hitungMundur1 = 0;
			if (a < posisi.Length) {
				pindahPos ();
			} else {
				perhitungan ();
			}
		}
	}

	public void pindahPos(){
		if (transform.position != posisi[a].transform.position) {
			posisiSampah [a - 1].SetActive (false);
			transform.position = Vector3.MoveTowards (transform.position, posisi[a].transform.position, Time.deltaTime * kecepatan);
		} else if(transform.position == posisi[a].transform.position){
			
			if (a > 2) {
				sampah = 7;
			} else if (a < 3) {
				sampah = 5;
			}
			posisiSampah [a].SetActive (true);
			hitungMundur1 = hitungMundur;
			waktumulai ();
			a++;
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
	void menu(){
		SceneManager.LoadScene ("Menu");
	}
	void perhitungan(){
		if (nilai >= 300) {
			if (nilai > nilai_tertinggi) {
				nilai_tertinggi = nilai;
				PlayerPrefs.SetInt ("NTS3", nilai_tertinggi);
				stageLanjut ();
			} else {
				stageLanjut ();
			}

		} else {
			ScoreAkhir.set_score = nilai;
			ScoreAkhir.set_minimal = 300;
			SceneManager.LoadScene ("gameover");
		}
	}
	void stageLanjut(){
		PlayerPrefs.SetInt ("nilai_stage3", nilai);
		selanjutnya.gameObject.SetActive (true);
		selanjutnya.text = "Selamat semua level telah terselesaikan\n" + Mathf.Round (countdown -= Time.deltaTime).ToString ();
		if (countdown < 0) {
			menu ();
		}
	}
	void resetScore(){
		if(nilai < 0){
			nilai = 0;
		}
	}
}
