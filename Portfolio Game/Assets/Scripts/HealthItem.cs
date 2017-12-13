using UnityEngine;

public class HealthItem : MonoBehaviour {

    [Range(1,3)]
	[Tooltip("Hom much the collided player will be healed.")]
    public int healAmount = 1;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            if (coll.gameObject.GetComponent<PlayerHealth>().health < 3)
            {
                coll.gameObject.GetComponent<PlayerHealth>().HealPlayer(healAmount);
                JuiceBox.PopOut(gameObject);
                Destroy(gameObject, 3f);
            }
        }
    }
}
