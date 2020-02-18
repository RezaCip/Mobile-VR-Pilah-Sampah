using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bintang : MonoBehaviour {

	// Use this for initialization
	public GameObject[] objek;
	float timer;
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		int xPointRespawn = Random.Range(-10, 10);
		int zPointRespawn = Random.Range(7, 20);
		int pointBalon = Random.Range(0, objek.Length);

		if(timer >= 2){
			timer = 0;

			Instantiate(objek[pointBalon], new Vector3(xPointRespawn, -2f, zPointRespawn), Quaternion.identity).gameObject.SetActive(true);
		}

	}
}
