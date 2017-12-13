using UnityEngine;

public class DaggerScript : MonoBehaviour {

    public float rotationSpeed = 10f;
    public float damage = 1f;

	void Start () {
		// When the dagger is spawned it will destroy itself after 5 seconds.
        Destroy(gameObject, 5);
	}

	void Update () {
		// The dagger will spin through the air.
        gameObject.GetComponent<Rigidbody2D>().rotation = -rotationSpeed * Time.frameCount;
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
			//coll.gameObject.GetComponent<FollowScript>();
			//add knockback effect here
        } else
        {
			// Destroyes dagger after hitting somthing thats not an enemy.
            Destroy(gameObject);
        }
    }
}
