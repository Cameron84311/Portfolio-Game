using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	//Makes the dooe a variable
	public GameObject door;

	void OnCollisionEnter2D () {

        JuiceBox.PopOut(door, 2f, 4);
		Destroy(door);
		

		Destroy(gameObject);
	}
}