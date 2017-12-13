using UnityEngine;
using System.Collections;

public class RattleExample3 : MonoBehaviour {

	// A full version of Rattle.
	// Control the force and duration of the rattle.

	void OnMouseDown() {
		JuiceBox.Rattle (gameObject, 20, 1.8f);
	}
}
