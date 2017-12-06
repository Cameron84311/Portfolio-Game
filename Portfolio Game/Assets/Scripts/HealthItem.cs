using UnityEngine;
using System.Collections;

public class HealthItem : MonoBehaviour {

    public GameObject healthGUI;
    private PlayerHealth playerHealth;

    void Start ()
    {
        playerHealth = healthGUI.GetComponent<PlayerHealth>();
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (playerHealth.health < 3)
            {
                playerHealth.HealPlayer();
                Destroy(gameObject);
            }
        }
    }
}
