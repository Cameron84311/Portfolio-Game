using UnityEngine;
using System.Collections;

public class PopOutExample3 : MonoBehaviour {

	// The full version of PopOut, using all 4 options.
	// Control the duration of the pop, the delay before popping and the type of easing.

	void OnMouseDown () {
		JuiceBox.PopOut (gameObject, .6f, .5f, iTween.EaseType.easeOutBounce);
	}
}
