using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupObject : MonoBehaviour {
	
	GameObject mainCamera;
	static bool carrying;
	static GameObject carriedObject;
	public float distance;
	public float smooth;
	float angka = 1;

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
		o.transform.GetChild (0).gameObject.SetActive (true);
	}
	public void ambil(){
		StartCoroutine (ambil1());
		Debug.Log (angka);
	}
	public void ambilLepas(){
		angka = 1;
		Debug.Log ("lepas");
	}
	IEnumerator ambil1(){
		yield return new WaitForSeconds (angka);
		int x = Screen.width / 2;
		int y = Screen.height / 2;

		Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit)) {
			Pickupable p = hit.collider.GetComponent<Pickupable>();
			PickupableAn z = hit.collider.GetComponent<PickupableAn> ();
			PickupableBer q = hit.collider.GetComponent<PickupableBer>();
			if(p != null) {
				carrying = true;
				carriedObject = p.gameObject;
				p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			} else if(z != null) {
				carrying = true;
				carriedObject = z.gameObject;
				z.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			} else if(q != null) {
				carrying = true;
				carriedObject = q.gameObject;
				q.gameObject.GetComponent<Rigidbody>().isKinematic = true;
			}
		}
	}

	void pickup() {
		if(Input.GetButtonDown("Fire1")||Input.GetButtonDown("Fire2")) {
			int x = Screen.width / 2;
			int y = Screen.height / 2;
			
			Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit)) {
				Pickupable p = hit.collider.GetComponent<Pickupable>();
				PickupableAn z = hit.collider.GetComponent<PickupableAn> ();
				PickupableBer q = hit.collider.GetComponent<PickupableBer>();
				if(p != null) {
					carrying = true;
					carriedObject = p.gameObject;
					p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
				} else if(z != null) {
					carrying = true;
					carriedObject = z.gameObject;
					z.gameObject.GetComponent<Rigidbody>().isKinematic = true;
				} else if(q != null) {
					carrying = true;
					carriedObject = q.gameObject;
					q.gameObject.GetComponent<Rigidbody>().isKinematic = true;
				}
			}
		}
	}
	
	void checkDrop() {
			if (Input.GetButtonDown ("Fire1") || Input.GetButtonDown ("Fire2")) {
				dropObject ();
		}
	}
	
	public static void dropObject() {
		carrying = false;
		carriedObject.transform.GetChild (0).gameObject.SetActive (false);
		carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;
		carriedObject = null;
	}
}

