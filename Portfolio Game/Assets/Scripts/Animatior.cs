using UnityEngine;
using System.Collections;

public class Animatior : MonoBehaviour {

    private SpriteRenderer spriteRenderer;
    private PlayerMovement movement;
    public Sprite idle;
    public Sprite walk0;
    public Sprite walk1;
    public Sprite walk2;
    public Sprite walk3;
    public Sprite walk4;
    public Sprite walk5;
    public float animSpeed = 0.08f;
    public float moveX;
    public float moveY;
    public float waitTime;
    public float acceleration = 0.5f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponent<PlayerMovement>();
        StartCoroutine(waiter());
    }

	void Update () {
        if (movement.moveX < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (movement.moveX > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (moveX == 0)
        {
            spriteRenderer.sprite = idle;
        }
        moveX = Mathf.Abs(movement.moveX);
        moveY = Mathf.Abs(movement.moveY);
        waitTime =  (animSpeed * (1/acceleration + 1)/(1/acceleration)) * (1 / (moveX + acceleration));
	}
    
    IEnumerator waiter()
    {
        while (true)
        {
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk0;
            }
            yield return new WaitForSeconds(waitTime);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk1;
            }
            yield return new WaitForSeconds(waitTime);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk2;
            }
            yield return new WaitForSeconds(waitTime);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk3;
            }
            yield return new WaitForSeconds(waitTime);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk4;
            }
            yield return new WaitForSeconds(waitTime);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk5;
            }
            yield return new WaitForSeconds(waitTime);
        }
    }
}
