using UnityEngine;
using System.Collections;

public class EnemyMoveY : MonoBehaviour {

	void Update () {
		transform.Translate(0f, 2 * Time.deltaTime, 0f);
	}
}
