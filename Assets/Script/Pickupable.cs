using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Pickupable : MonoBehaviour {

	// Use this for initialization
	int nilaiTambah = 20, nilaiKurang = 10;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TempatSampahOr") {
			PickupObject.dropObject ();
			waktu.nilai += nilaiTambah;
			waktu.sampah -= 1;
			Destroy(this.gameObject);
			
		} else if (other.gameObject.name == "TempatSampahAn") {
			PickupObject.dropObject ();
			waktu.nilai -= nilaiKurang;
			waktu.sampah -= 1;
			Destroy(this.gameObject);

		} else if (other.gameObject.name == "TempatSampahBer") {
			PickupObject.dropObject ();
			waktu.nilai -= nilaiKurang;
			waktu.sampah -= 1;
			Destroy(this.gameObject);
		}
	}

}
