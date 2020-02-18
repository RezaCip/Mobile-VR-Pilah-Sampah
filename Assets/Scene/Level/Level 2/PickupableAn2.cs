using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupableAn2: MonoBehaviour {

	int nilaiTambah = 20, nilaiKurang = 10;

	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TempatSampahOr") {
			PickupObject2.dropObject ();
			waktu2.nilai -= nilaiKurang;
			waktu2.sampah -= 1;
			Destroy(this.gameObject);

		} else if (other.gameObject.name == "TempatSampahAn") {
			PickupObject2.dropObject ();
			waktu2.nilai += nilaiTambah;
			waktu2.sampah -= 1;
			Destroy(this.gameObject);

		} else if (other.gameObject.name == "TempatSampahBer") {
			PickupObject2.dropObject ();
			waktu2.nilai -= nilaiKurang;
			waktu2.sampah -= 1;
			Destroy(this.gameObject);

		}
	}

}
