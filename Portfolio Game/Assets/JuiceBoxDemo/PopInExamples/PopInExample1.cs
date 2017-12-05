using UnityEngine;
using System.Collections;

public class PopInExample1 : MonoBehaviour {

	// A nice easy use of the PopIn function.
	// Would work well in the Start function of your GameObjects.

	void Start () {
		JuiceBox.PopIn (gameObject);
	}
}
