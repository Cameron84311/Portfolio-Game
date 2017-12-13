using UnityEngine;
using System.Collections;

public class JiggleExample1 : MonoBehaviour {

	// A nice easy use of the Jiggle function.
	// A good way to show an object was bumped/clicked/etc.

	void OnMouseDown() {
		JuiceBox.Jiggle (gameObject);
	}
}
