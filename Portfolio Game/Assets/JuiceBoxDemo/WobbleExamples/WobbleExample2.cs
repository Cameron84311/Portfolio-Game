using UnityEngine;
using System.Collections;

public class WobbleExample2 : MonoBehaviour {

	// A more customisable version of Wobble.
	// Control the force of the wobble by changing the number.

	void OnMouseDown() {
		JuiceBox.Wobble (gameObject, .3f);
	}
}
