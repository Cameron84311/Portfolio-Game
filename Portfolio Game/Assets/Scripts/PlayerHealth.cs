using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    private Image spriteRenderer;
<<<<<<< HEAD
=======
    [Header("Sprites")]
>>>>>>> parent of 5d160d5... changed name of space mine script
    public Sprite health0;
    public Sprite health1;
    public Sprite health2;
    public Sprite health3;
<<<<<<< HEAD
=======
    [Header("Properties")]
    [Range(1,3)]
	[Tooltip("How much health the player currently has.")]
>>>>>>> parent of 5d160d5... changed name of space mine script
    public int health = 3;
    public float rattlePower = 1f;
    public float rattleTime = 0.2f;
 
    // Fetches the SpriteRenderer componenet and updates the players Health.
    void Start()
    {
        spriteRenderer = GameObject.Find("Health GUI").GetComponent<Image>();
        UpdateHealth();
    }
    
    // Removes one health and wobbles the GUI then it  
    public void DamagePlayer(int damageAmount)
    {
        if (health > 0)
        {
            JuiceBox.Rattle(Camera.main.gameObject, rattlePower, rattleTime);
            health = health - damageAmount;
            UpdateHealth();
        }  
    }
   
    // Updates the GUI to the current health.
    public void UpdateHealth()
    {
        if (health == 3) { spriteRenderer.sprite = health3; }
        if (health == 2) { spriteRenderer.sprite = health2; }
        if (health == 1) { spriteRenderer.sprite = health1; }
        if (health == 0) { spriteRenderer.sprite = health0; }
    }

    public void HealPlayer(int healAmount)
    {
        if (health < 3)
        {
            health = health + healAmount;
            UpdateHealth();
        }
    }
}
