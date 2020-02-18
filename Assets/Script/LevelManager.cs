using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public Button level1;
	public Button level2;
	public Button level3;
	void Start () {
		PlayerPrefs.SetInt ("Level1", 1);
		PlayerPrefs.SetInt ("Level2", 0);
		PlayerPrefs.SetInt ("Level3", 0);
	}
	
	// Update is called once per frame
	void Update () {
		level1selesai ();
		level2selesai ();

	}
	void level1selesai(){
		if (PlayerPrefs.GetInt ("nilai_level1") >= 200) {
			level2.GetComponent<Button> ().interactable = true;
			PlayerPrefs.SetInt ("level2", 1);
		} else {
			level2.GetComponent<Button> ().interactable = false;
		}
	}
	void level2selesai(){
		if (PlayerPrefs.GetInt ("nilai_level2") >= 300) {
			level3.GetComponent<Button> ().interactable = true;
			PlayerPrefs.SetInt ("level3", 1);
		} else {
			level3.GetComponent<Button> ().interactable = false;
		}
	}
}
