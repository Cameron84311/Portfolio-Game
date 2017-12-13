using UnityEngine;
using System.Collections;

public class RockExample2 : MonoBehaviour {

	// A more customisable version of Rock.
	// Control the angle and duration.

	void Start () {
		JuiceBox.Rock (gameObject, 15, .4f);
	}
}
