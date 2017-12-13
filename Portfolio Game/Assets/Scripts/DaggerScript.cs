using UnityEngine;

public class DaggerScript : MonoBehaviour {

    public float rotationSpeed = 10f;
    public float damage = 1f;

	void Start () {
        Destroy(gameObject, 5);
	}

	void Update () {
        gameObject.GetComponent<Rigidbody2D>().rotation = -rotationSpeed * Time.frameCount;
	}

	// Checks for collision.
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            coll.gameObject.GetComponent<SpaceMineController>();

        } else
        {
            Destroy(gameObject);
        }
    }
}
