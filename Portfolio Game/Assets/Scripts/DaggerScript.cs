using UnityEngine;
using System.Collections;

public class DaggerScript : MonoBehaviour {

    public float rotationSpeed = 10f;

	void Start () {
	
	}

	void Update () {
        gameObject.GetComponent<Rigidbody2D>().rotation = -rotationSpeed * Time.frameCount;
	}
}
