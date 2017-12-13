using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	//private Image spriteRenderer;

	[Header("Properties")]
	[Range(1,3)]
	[Tooltip("The max amount of health that the enemy has.")]
	public int maxHealth = 3;
	[Range(1,3)]
	[Tooltip("How much health this enemy currently has.")]
	public int health = 3;

	/*
	Header("Sprites")]
	public Sprite health0;
	public Sprite health1;
	public Sprite health2;
	public Sprite health3;
	*/

	void Start()
	{
		// Finds the Health GUI and gets its sprite renderer.
		//spriteRenderer = GameObject.Find("Health GUI").GetComponent<Image>();
		// Updates the Health GUI.
		UpdateHealth();
	}

	public void DamageEnemy(int damageAmount)
	{
		// Checks if the health is more than 0.
		if (health > 0)
		{
			// Damages the enemy by the damageAmount.
			health = health - damageAmount;
			// Updates the Health GUI.
			UpdateHealth();
		}  
	}
		
	public void UpdateHealth()
	{
		// Checks if the health = 0.
		if (health == 0) 
		{
			// Destroyes the emeny.
			Destroy (gameObject);
		}

		/*
		if (health == 3) { spriteRenderer.sprite = health3; }
		if (health == 2) { spriteRenderer.sprite = health2; }
		if (health == 1) { spriteRenderer.sprite = health1; }
		if (health == 0) { spriteRenderer.sprite = health0; }
		*/
	}

	public void HealEnemy(int healAmount)
	{
		// Checks if health is less that 3.
		if (health < maxHealth)
		{
			//  Heals the enemy by the healAmount.
			health = health + healAmount;
			// Updates the Health GUI.
			UpdateHealth();
		}
	}
}
