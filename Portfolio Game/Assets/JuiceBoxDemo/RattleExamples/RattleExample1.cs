using UnityEngine;
using System.Collections;

public class RattleExample1 : MonoBehaviour {

	// A nice easy use of the Rattle function.
	// A good way to show an object was bumped/clicked/etc.

	void OnMouseDown() {
		JuiceBox.Rattle (gameObject);
	}
}
