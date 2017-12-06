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
<<<<<<< HEAD
            if (playerHealth.health < 3)
            {
                playerHealth.HealPlayer();
                Destroy(gameObject);
            }
=======
            playerHealth.HealPlayer();
            JuiceBox.PopOut(gameObject);
            Destroy(gameObject, 0.3f);
>>>>>>> dbbd5939ce0049975067b54a7af54fb09beb1c8a
        }
    }
}
