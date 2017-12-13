using UnityEngine;

public class HealthItem : MonoBehaviour {

    [Range(1,3)]
	[Tooltip("Hom much the collided player will be healed.")]
    public int healAmount = 1;

    void OnCollisionEnter2D(Collision2D coll)
    {
		// Checks if it has collided with a player.
        if (coll.gameObject.tag == "Player")
        {
			// Checks if the player has less than max health.
            if (coll.gameObject.GetComponent<PlayerHealth>().health < 3)
            {
				// Heals the player by the healAmount.
                coll.gameObject.GetComponent<PlayerHealth>().HealPlayer(healAmount);
                // The Item dissapears.
				JuiceBox.PopOut(gameObject);
                // Destroys the item after 3 seconds.
				Destroy(gameObject, 3f);
            }
        }
    }
}
