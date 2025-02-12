﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnorganikC : MonoBehaviour {

	GameObject mainCamera;
	bool carrying;
	public int nilaiTambah,nilaiKurang;
	GameObject carriedObject;
	public float distance;
	public float smooth;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag("MainCamera");

	}

	// Update is called once per frame
	void Update () {
		if (carrying) {
			carry (carriedObject);
			checkDrop ();
		} else {
			pickup ();
		}
	}

	void carry(GameObject o) {
			o.transform.position = Vector3.Lerp (o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
	}

	void pickup() {
		if(Input.GetButtonDown("Fire1")||Input.GetButtonDown("Fire2")) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;

			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				AnorganikC p = hit.collider.GetComponent<AnorganikC>();

				if(p != null) {
					carrying = true;
					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().isKinematic = true;

				}
			}
		}
	}

	void checkDrop() {
		
		if (carrying == false||Input.GetButtonDown("Fire1")) {
			dropObject ();
		}
	}

	public void dropObject() {
			carrying = false;
			carriedObject.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			carriedObject = null;
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TempatSampahOr") {
			carrying = false;
			Destroy (this.gameObject);
			WaktuNScore.nilai -= nilaiKurang;
			WaktuNScore.sampah -= 1;
		} else if (other.gameObject.name == "TempatSampahAn") {
			carrying = false;
			Destroy (this.gameObject);
			WaktuNScore.nilai += nilaiTambah;
			WaktuNScore.sampah -= 1;
		} else if (other.gameObject.name == "TempatSampahBer") {
			carrying = false;
			Destroy (this.gameObject);
			WaktuNScore.nilai -= nilaiKurang;
			WaktuNScore.sampah -= 1;
		}
	}
}
