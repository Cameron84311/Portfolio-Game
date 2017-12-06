using UnityEngine;

public class DamagePlayer : MonoBehaviour {

    public GameObject Shield;
    public GameObject healthGUI;
    private PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = healthGUI.GetComponent<PlayerHealth>();
    }

    // If the gameObject collides with the player then do dammage
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" &! Shield.activeSelf)
        {
            playerHealth.DamagePlayer();
        }
    }
}