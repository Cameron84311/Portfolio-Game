using UnityEngine;
using System.Collections;

public class JiggleExample2 : MonoBehaviour {

	// A more customisable version of Jiggle.
	// Control the force of the jiggle by changing the number.

	void OnMouseDown() {
		JuiceBox.Jiggle (gameObject, .3f);
	}
}
