using UnityEngine;
using System.Collections;

public class PopInExample2 : MonoBehaviour {

	// A more customisable version of PopIn.
	// Control the duration of the pop by changing the number.

	void Start () {
		JuiceBox.PopIn (gameObject, 2f);
	}
}
