using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    // If the gameObject collides with the player then do dammage
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (!coll.gameObject.transform.Find("Shield").gameObject.activeSelf)
            {
                coll.gameObject.GetComponent<PlayerHealth>().DamagePlayer();
            }
        }
    }
}