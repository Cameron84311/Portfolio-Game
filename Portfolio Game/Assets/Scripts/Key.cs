using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	//Makes the dooe a variable
	public GameObject door;

	void OnCollisionEnter () {
		//When the key is touched the door will be destoyed
		Destroy(door);
		//Will also destroy the key
		Destroy(gameObject);
	}
}