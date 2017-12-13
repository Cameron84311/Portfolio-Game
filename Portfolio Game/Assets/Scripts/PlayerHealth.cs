using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    private Image spriteRenderer;
<<<<<<< HEAD
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
=======

    [Header("Properties")]
    [Range(1,3)]
	[Tooltip("How much health the player currently has.")]
>>>>>>> parent of 76d6625... Merge branch 'master' of https://github.com/JustRyanW/Portfolio-Game
    public int health = 3;
    [Header("Camera")]
	[Tooltip("How long the camera will shake when damaged.")]
    public float rattlePower = 1f;
	[Tooltip("How strong the camera will shake when damaged.")]
    public float rattleTime = 0.2f;
	[Header("Sprites")]
	public Sprite health0;
	public Sprite health1;
	public Sprite health2;
	public Sprite health3;
 
    void Start()
    {
        // Finds the Health GUI and gets its sprite renderer.
        spriteRenderer = GameObject.Find("Health GUI").GetComponent<Image>();
        // Updates the Health GUI.
        UpdateHealth();
    }

    public void DamagePlayer(int damageAmount)
    {
        // Checks if the health is more than 0.
        if (health > 0)
        {
            // Rattles the camera.
            JuiceBox.Rattle(Camera.main.gameObject, rattlePower, rattleTime);
            // Damages the player by the damageAmount.
            health = health - damageAmount;
            // Updates the Health GUI.
            UpdateHealth();
        }  
    }
   
    // Updates the GUI to the sprite relevent the current health.
    public void UpdateHealth()
    {
        if (health == 3) { spriteRenderer.sprite = health3; }
        if (health == 2) { spriteRenderer.sprite = health2; }
        if (health == 1) { spriteRenderer.sprite = health1; }
        if (health == 0) { spriteRenderer.sprite = health0; }
    }

    public void HealPlayer(int healAmount)
    {
        // Checks if health is less that 3.
        if (health < 3)
        {
            //  Heals the player by the healAmount.
            health = health + healAmount;
            // Updates the Health GUI.
            UpdateHealth();
        }
    }
}
