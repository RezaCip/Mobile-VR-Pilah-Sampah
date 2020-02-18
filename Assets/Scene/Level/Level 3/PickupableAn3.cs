using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupableAn3: MonoBehaviour {

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
			PickupObject3.dropObject ();
			waktu3.nilai -= nilaiKurang;
			waktu3.sampah -= 1;
			Destroy(this.gameObject);
			
		} else if (other.gameObject.name == "TempatSampahAn") {
			PickupObject3.dropObject ();
			waktu3.nilai += nilaiTambah;
			waktu3.sampah -= 1;
			Destroy(this.gameObject);

		} else if (other.gameObject.name == "TempatSampahBer") {
			PickupObject3.dropObject ();
			waktu3.nilai -= nilaiKurang;
			waktu3.sampah -= 1;
			Destroy(this.gameObject);

		}
	}

}
