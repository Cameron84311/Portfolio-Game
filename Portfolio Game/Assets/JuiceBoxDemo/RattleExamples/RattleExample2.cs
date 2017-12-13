using UnityEngine;
using System.Collections;

public class RattleExample2 : MonoBehaviour {

	// A more customisable version of Rattle.
	// Control the force of the rattle by changing the number.

	void OnMouseDown() {
		JuiceBox.Rattle (gameObject, 20);
	}
}
