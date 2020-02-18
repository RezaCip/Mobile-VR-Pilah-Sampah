using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreAkhir : MonoBehaviour {

	// Use this for initialization
	Text score_akhir,score_min;
	public static int set_score, set_minimal;
	void Start () {
		score_akhir = GetComponent<Text> ();
		score_min = GameObject.Find ("Score minimal").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		score_akhir.text = "Score : " + set_score;
		score_min.text = "Score Minimal : " + set_minimal;
	}
	public void reset(){
		set_score = 0;
	}
	public void KeMenu(){
		reset ();
		SceneManager.LoadScene ("Menu");
	}
}
