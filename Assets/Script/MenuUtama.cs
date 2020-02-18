using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUtama : MonoBehaviour {
	public GameObject panelInfo, panelUtama, panelST;
	float waktuSelesai = 1;
	float waktuTunggu;
	public static bool BelajarDipilih,InfoDipilih,STdipilih,PUdipilih;
	public Image img;
	public Animator Anim;
	// Use this for initialization
	void Start () {
		waktuTunggu = 0;
		img.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (BelajarDipilih) {
			waktuTunggu += Time.deltaTime;
			if (waktuTunggu >= waktuSelesai) {
				StartCoroutine (BukaBelajar ());
				waktuTunggu = 0;
			}
		} else if (InfoDipilih) {
			waktuTunggu += Time.deltaTime;
			if (waktuTunggu >= waktuSelesai) {
				panelInfo.SetActive (true);
				panelUtama.SetActive (false);
				waktuTunggu = 0;
			}
		} else if (STdipilih) {
			waktuTunggu += Time.deltaTime;
			if (waktuTunggu >= waktuSelesai) {
				panelST.SetActive (true);
				panelUtama.SetActive (false);
				waktuTunggu = 0;
			}
		}
	}

	IEnumerator BukaBelajar(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Belajar");
	}
	public void pilihBelajar(){
		BelajarDipilih = true;
	}
	public void pilihInfo(){
		InfoDipilih = true;
	}
	public void pilihScoreTinggi(){
		STdipilih = true;
	}
	public void kembaliPanelUtama(){
		PUdipilih = true;
	}
	public void tidakPilih(){
		PUdipilih = false;
		STdipilih = false;
		InfoDipilih = false;
		BelajarDipilih = false;
		waktuTunggu = 0;
	}
}
