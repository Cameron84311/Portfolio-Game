using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public Sprite health0;
    public Sprite health1;
    public Sprite health2;
    public Sprite health3;
    public int health = 3;

    void OnMouseDown()
    {
        //temp
        JuiceBox.Wobble(gameObject, 0.05f, 0.2f);
        DamagePlayer();
    }

    void Start()
    {
        health = 3;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void DamagePlayer()
    {
        health--;
        if (health == 3) { spriteRenderer.sprite = health3; }
        if (health == 2) { spriteRenderer.sprite = health2; }
        if (health == 1) { spriteRenderer.sprite = health1; }
        if (health == 0) { spriteRenderer.sprite = health0; }
    }
}
