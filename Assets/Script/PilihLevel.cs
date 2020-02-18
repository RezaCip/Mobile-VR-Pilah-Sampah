using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PilihLevel: MonoBehaviour {

	// Use this for initialization
	public GameObject PanelLevel,PanelUtama;
	public Animator Anim;
	public Image img;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void enter_PL(){
	
	}
	public void panel_Level(){
		PanelUtama.SetActive (false);
		PanelLevel.SetActive (true);
	}
	public void Level1(){
		StartCoroutine (level1 ());
	}
	IEnumerator level1(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Stage1");
	}
	public void Level2(){
		StartCoroutine (level2 ());
	}
	IEnumerator level2(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Stage2");
	}
	public void Level3(){
		StartCoroutine (level3 ());
	}
	IEnumerator level3(){
		Anim.SetBool ("Fade", true);
		yield return new WaitUntil (() => img.color.a == 1);
		SceneManager.LoadScene ("Stage3");
	}

	public void KembaliMenu(){
		PanelLevel.SetActive (false);
		PanelUtama.SetActive (true);
	}

}
