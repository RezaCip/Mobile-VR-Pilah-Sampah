using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KembalikeMenu : MonoBehaviour {
	public Animator Anim;
	public Image img;
	// Use this for initialization
	void Start () {
		img.gameObject.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
	}
	public void KeMenu(){
		StartCoroutine (Menu());
	}

	IEnumerator Menu(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Menu");
	}
}
