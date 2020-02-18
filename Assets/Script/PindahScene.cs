using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PindahScene : MonoBehaviour {
	
	public GameObject panelUtama, PanelKedua, panelSkor, panelKeluar;
	public Animator Anim;
	public Image img;
	public Text Stage1, Stage2, Stage3;

	void Start(){
		img.gameObject.SetActive (true);
	}
		
	public void Belajar1(){
		StartCoroutine (Belajar ());
	}

	public IEnumerator Belajar(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Belajar");
	}

	public void Info(){
		PanelKedua.SetActive (true);
		panelUtama.SetActive (false);
	}
	public void Exit(){
		panelUtama.SetActive (false);
		panelKeluar.SetActive (true);
	}
	public void kembaliMenu(){
		panelUtama.SetActive (true);
		PanelKedua.SetActive (false);
		panelSkor.SetActive (false);
		panelKeluar.SetActive (false);
	}

	public void SkorTinggi(){
		panelSkor.SetActive (true);
		panelUtama.SetActive (false);
		Stage1.text = PlayerPrefs.GetInt ("NTS1").ToString();
		Stage2.text = PlayerPrefs.GetInt ("NTS2").ToString();
		Stage3.text = PlayerPrefs.GetInt ("NTS3").ToString();
	}
	public void Keluar(){
		Application.Quit ();
	}
}
