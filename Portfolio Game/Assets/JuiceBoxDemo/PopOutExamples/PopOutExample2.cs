using UnityEngine;
using System.Collections;

public class PopOutExample2 : MonoBehaviour {

	// A more customisable version of PopOut.
	// Control the duration of the pop by changing the number.

	void OnMouseDown () {
		JuiceBox.PopOut (gameObject, .4f);
	}
}
