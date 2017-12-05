using UnityEngine;
using System.Collections;

public class PopOutExample1 : MonoBehaviour {

	// A nice easy use of the PopOut function.
	// A juicy way to hide objects.
	// Note: does not delete the object.

	void OnMouseDown () {
		JuiceBox.PopOut (gameObject);
	}
}
