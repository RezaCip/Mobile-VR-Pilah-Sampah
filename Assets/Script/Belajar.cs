using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Belajar : MonoBehaviour {

	public GameObject Organik, Anorganik, Berbahaya, Panel;
	public Animator Anim;
	public Image img;
	void Start(){
		img.gameObject.SetActive (true);
	}

	public void BukaOrganik(){
		Organik.SetActive (true);
		Panel.SetActive (false);
	}
	public void BukaAnorganik(){
		Anorganik.SetActive (true);
		Panel.SetActive (false);
	}
	public void BukaBerbahaya(){
		Berbahaya.SetActive (true);
		Panel.SetActive (false);
	}
	public void KembaliOrganik(){
		Panel.SetActive (true);
		Organik.SetActive (false);
	}
	public void KembaliAnorganik(){
		Panel.SetActive (true);
		Anorganik.SetActive (false);
	}
	public void KembaliBerbahaya(){
		Panel.SetActive (true);
		Berbahaya.SetActive (false);
	}
	public void Menu(){
		StartCoroutine (menu ());
	}
	IEnumerator menu(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Menu");
	}
}
