using UnityEngine;
using System.Collections;

public class JiggleExample3 : MonoBehaviour {

	// A full version of Jiggle.
	// Control the force and duration of the jiggle.

	void OnMouseDown() {
		JuiceBox.Jiggle (gameObject, .4f, 3);
	}
}
