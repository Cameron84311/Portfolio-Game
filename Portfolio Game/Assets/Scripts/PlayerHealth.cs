using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public GameObject mainCamera;
    public Sprite health0;
    public Sprite health1;
    public Sprite health2;
    public Sprite health3;
    public int health = 3;
    public float rattlePower = 1f;
    public float rattleTime = 0.2f;
 
    // Fetches the SpriteRenderer componenet and updates the players Health.
    void Start()
    {    
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateHealth();
    }
    
    // Removes one health and wobbles the GUI then it  
    public void DamagePlayer()
    {
        JuiceBox.Rattle(mainCamera, rattlePower, rattleTime);
        health--;
        UpdateHealth();    
    }
   
    // Updates the GUI to the current health.
    public void UpdateHealth()
    {
        if (health == 3) { spriteRenderer.sprite = health3; }
        if (health == 2) { spriteRenderer.sprite = health2; }
        if (health == 1) { spriteRenderer.sprite = health1; }
        if (health == 0) { spriteRenderer.sprite = health0; }
    }

    public void HealPlayer()
    {
        health++;
        UpdateHealth();
    }
}
