using UnityEngine;
using System.Collections;

public class WobbleExample1 : MonoBehaviour {

	// A nice easy use of the Wobble function.
	// A good way to show an object was bumped/clicked/etc.

	void OnMouseDown() {
		JuiceBox.Wobble (gameObject);
	}
}
