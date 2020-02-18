using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObjectA : MonoBehaviour {

	GameObject mainCamera;
	public bool carrying;
	public bool a;
	public GameObject carriedObject;
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
			//rotateObject();
		} else {
			pickup ();
		}
	}

	void rotateObject() {
		carriedObject.transform.Rotate(5,10,15);
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
				//Pickupable p = hit.collider.GetComponent<Pickupable>();
				PickupObjectA p = hit.collider.GetComponent<PickupObjectA>();

				if(p != null) {
					carrying = true;

					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().isKinematic = true;

				}
			}
		}
	}

	void checkDrop() {
		
		if (a||Input.GetButtonDown("Fire1")) {
			dropObject ();
		}
	}

	public void dropObject() {
			carrying = false;
			a = false;
			//a = false;
			carriedObject.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
			carriedObject = null;
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "TempatSampahOr") {
			a = true;
			Destroy (this.gameObject);
			//ambil.dropObject1(this.gameObject);
			Score.nilai += 10;
		} else if (other.gameObject.name == "TempatSampahAn") {
			Destroy (this.gameObject);
			//scoresatu.nilai_player += 100;

		} else if (other.gameObject.name == "TempatSampahBer") {
			Destroy (this.gameObject);

		}
	}
}
