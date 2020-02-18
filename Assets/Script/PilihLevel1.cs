using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PilihLevel1 : MonoBehaviour {

	// Use this for initialization
	public GameObject PanelS1,PanelS2,PanelS3,PanelLevel;
	void Start () {
		PanelS1.SetActive(false);
		PanelS2.SetActive(false);
		PanelS3.SetActive(false);
		PanelLevel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Panel_Level(){
		//PanelUtama.SetActive (false);
		PanelLevel.SetActive (true);
	}
	public void Stage1(){
		PanelLevel.SetActive (false);
		PanelS1.SetActive (true);
	}
	public void Stage2(){
		PanelLevel.SetActive (false);
		PanelS2.SetActive (true);
	}
	public void Stage3(){
		PanelLevel.SetActive (false);
		PanelS3.SetActive (true);
	}
	public void KembaliLevel(){
		PanelS1.SetActive (false);
		PanelS2.SetActive (false);
		PanelS3.SetActive (false);
		PanelLevel.SetActive (true);
	}
	public void KembaliMenu(){
		PanelLevel.SetActive (false);
		//PanelUtama.SetActive (true);
	}

	public void level1_1(){
		SceneManager.LoadScene ("Bermain");
	}
	public void level1_2(){
		SceneManager.LoadScene ("Stage12");
	}
	public void level1_3(){
		SceneManager.LoadScene ("Stage13");
	}
	public void level1_4(){
		SceneManager.LoadScene ("Stage14");
	}
	public void level1_5(){
		SceneManager.LoadScene ("Stage15");
	}

	public void level2_1(){
		SceneManager.LoadScene ("Stage21");
	}
	public void level2_2(){
		SceneManager.LoadScene ("Stage22");
	}
	public void level2_3(){
		SceneManager.LoadScene ("Stage23");
	}
	public void level2_4(){
		SceneManager.LoadScene ("Stage24");
	}
	public void level2_5(){
		SceneManager.LoadScene ("Stage25");
	}

	public void level3_1(){
		SceneManager.LoadScene ("Stage31");
	}
	public void level3_2(){
		SceneManager.LoadScene ("Stage32");
	}
	public void level3_3(){
		SceneManager.LoadScene ("Stage33");
	}
	public void level3_4(){
		SceneManager.LoadScene ("Stage34");
	}
	public void level3_5(){
		SceneManager.LoadScene ("Stage35");
	}
}
