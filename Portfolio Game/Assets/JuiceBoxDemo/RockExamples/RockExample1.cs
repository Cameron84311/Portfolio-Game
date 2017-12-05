using UnityEngine;
using System.Collections;

public class RockExample1 : MonoBehaviour {

	// A nice easy use of the Rock function.
	// Rocking objects will rotate endlessly back and forth (Z-axis only).

	void Start () {
		JuiceBox.Rock (gameObject);
	}

}
