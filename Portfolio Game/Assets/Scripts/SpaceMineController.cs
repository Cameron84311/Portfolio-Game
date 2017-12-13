using UnityEngine;
using System.Collections;

public class SpaceMineController : MonoBehaviour {

	public float speed = 1;
	public float range = 5;
    public float range2 = 0.1f;
	GameObject target;

	void Start () {
		target = GameObject.FindWithTag ("Player");
	}

	void Update () {
		Vector3 toTarget = target.transform.position - transform.position;
        if (toTarget.magnitude < range && toTarget.magnitude > range2)
        {
			Vector3 movement = toTarget.normalized * speed * Time.deltaTime;
			transform.Translate (movement, Space.World);
		}
	}
}
