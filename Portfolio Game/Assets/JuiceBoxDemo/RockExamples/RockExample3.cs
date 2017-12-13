using UnityEngine;
using System.Collections;

public class RockExample3 : MonoBehaviour {

	// A full version of Rock.
	// Control the angle, duration and easing of the rocking.

	void Start () {
		JuiceBox.Rock (gameObject, 20, .6f, iTween.EaseType.linear);
	}
}
