using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    // Checks for a collision and applies the collided gameObject to coll.
    void OnCollisionEnter2D(Collision2D coll)
    {
        // Checks if coll has the "Player" tag.
        if (coll.gameObject.tag == "Player")
        {
            // Checks if coll has a child calld "Shield" and if it is not active.
            if (!coll.gameObject.transform.Find("Shield").gameObject.activeSelf)
            {
                // Calls the DamagePlayer()  method on the collided player.
                coll.gameObject.GetComponent<PlayerHealth>().DamagePlayer();
            }
        }
    }
}