using UnityEngine;
using System.Collections;

public class PopInExample3 : MonoBehaviour {

	// The full version of PopIn, using all 4 options.
	// Control the duration of the pop, the delay before popping and the type of easing.

	void Start () {
		JuiceBox.PopIn (gameObject, .6f, 1, iTween.EaseType.easeOutBack);
	}
}
