using UnityEngine;
using System.Collections;

public class Animatior : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private PlayerMovement movement;
    public Sprite idle;
    public Sprite walk0;
    public Sprite walk1;
    public Sprite walk2;
    public Sprite walk3;
    public Sprite walk4;
    public Sprite walk5;
    public Sprite downIdle;
    public Sprite walkDown0;
    public Sprite walkDown1;
    public Sprite walkDown2;
    public Sprite walkDown3;
    public Sprite upIdle;
    public Sprite walkUp0;
    public Sprite walkUp1;
    public Sprite walkUp2;
    public Sprite walkUp3;
    public float animSpeed = 0.08f;
    public float moveX;
    public float moveY;
    public float waitTimeX;
    public float waitTimeY;
    public float acceleration = 0.5f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        movement = GetComponent<PlayerMovement>();
        StartCoroutine(WalkAnim());
        StartCoroutine(WalkDownAnim());
        StartCoroutine(WalkUpAnim());
    }

    void Update()
    {
        moveX = Mathf.Abs(movement.moveX);
        moveY = Mathf.Abs(movement.moveY);
        if (moveX >= moveY)
        {
            if (movement.moveX < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (movement.moveX > 0)
            {
                spriteRenderer.flipX = false;
            }
            if (moveX == 0 && moveY == 0)
            {
                spriteRenderer.sprite = idle;
            }
        }

        waitTimeX = (animSpeed * (1 / acceleration + 1) / (1 / acceleration)) * (1 / (moveX + acceleration));
        waitTimeY = (animSpeed * (1 / acceleration + 1) / (1 / acceleration)) * (1 / (moveY + acceleration));
    }

    IEnumerator WalkAnim()
    {
        while (true)
        {
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk0;
            }
            yield return new WaitForSeconds(waitTimeX);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk1;
            }
            yield return new WaitForSeconds(waitTimeX);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk2;
            }
            yield return new WaitForSeconds(waitTimeX);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk3;
            }
            yield return new WaitForSeconds(waitTimeX);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk4;
            }
            yield return new WaitForSeconds(waitTimeX);
            if (moveX >= moveY && moveX != 0)
            {
                spriteRenderer.sprite = walk5;
            }
            yield return new WaitForSeconds(waitTimeX);
        }
    }
    IEnumerator WalkDownAnim()
    {
        while (true)
        {
            if (movement.moveY < -moveX)
            {
                spriteRenderer.sprite = walkDown0;
            }
            yield return new WaitForSeconds(waitTimeY);
            if (movement.moveY < -moveX)
            {
                spriteRenderer.sprite = walkDown1;
            }
            yield return new WaitForSeconds(waitTimeY);
            if (movement.moveY < -moveX)
            {
                spriteRenderer.sprite = walkDown2;
            }
            yield return new WaitForSeconds(waitTimeY);
            if (movement.moveY < -moveX)
            {
                spriteRenderer.sprite = walkDown3;
            }
            yield return new WaitForSeconds(waitTimeY);
        }
    }
    IEnumerator WalkUpAnim()
    {
        while (true)
        {
            if (movement.moveY > moveX)
            {
                spriteRenderer.sprite = walkUp0;
            }
            yield return new WaitForSeconds(waitTimeY);
            if (movement.moveY > moveX)
            {
                spriteRenderer.sprite = walkUp1;
            }
            yield return new WaitForSeconds(waitTimeY);
            if (movement.moveY > moveX)
            {
                spriteRenderer.sprite = walkUp2;
            }
            yield return new WaitForSeconds(waitTimeY);
            if (movement.moveY > moveX)
            {
                spriteRenderer.sprite = walkUp3;
            }
            yield return new WaitForSeconds(waitTimeY);
        }
    }
}
