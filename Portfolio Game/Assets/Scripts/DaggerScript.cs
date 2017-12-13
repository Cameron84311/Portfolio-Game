using UnityEngine;

public class DaggerScript : MonoBehaviour {

    public float rotationSpeed = 10f;
	public int damage = 1;

	void Start () {
		// When the dagger is spawned it will destroy itself after 5 seconds.
        Destroy(gameObject, 5);
	}

	void Update () {
		// The dagger will spin through the air.
        gameObject.GetComponent<Rigidbody2D>().rotation = -rotationSpeed * Time.frameCount;
	}

	// Checks for collision.
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
			// Damages the enemy by the damage amount.
			coll.gameObject.GetComponent<EnemyHealth> ().DamageEnemy (damage);

			//coll.gameObject.GetComponent<FollowScript>();
			//add knockback effect here

			// Destroys the dagger.
			Destroy(gameObject);
        } else
        {
			// Destroyes dagger after hitting somthing thats not an enemy.
            Destroy(gameObject);
        }
    }
}
