using UnityEngine;
using System.Collections;

public class WobbleExample3 : MonoBehaviour {

	// A full version of Wobble.
	// Control the force and duration of the wobble.

	void OnMouseDown() {
		JuiceBox.Wobble (gameObject, .2f, 1);
	}
}
