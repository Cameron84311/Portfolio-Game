using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    private PlayerMovement movement;

    [Header("Properties")]
    [Tooltip("The delay between each frame of animation.")]
    public float animSpeed = 0.08f;
    [Tooltip("How much the delay between animation fames is increased at slower speeds")]
    public float acceleration = 0.5f;
    [Header("Sprites")]
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

    [HideInInspector]
    public float moveX;
    [HideInInspector]
    public float moveY;
    [HideInInspector]
    public float waitTimeX;
    [HideInInspector]
    public float waitTimeY;


    void Start()
    {
        // Fetches the SpriteRenderer component.
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Fetches the PlayerMovement script.
        movement = GetComponent<PlayerMovement>();
        // Starts Coroutines, allowing time delays in the code.
        StartCoroutine(WalkAnim());
        StartCoroutine(WalkDownAnim());
        StartCoroutine(WalkUpAnim());
    }

    void Update()
    {
        // Creates only positive values for the speed of the gameObject.
        moveX = Mathf.Abs(movement.moveX);
        moveY = Mathf.Abs(movement.moveY);
        // If the gameObject is moving more horizontaly than verticaly or is going diaganoly.
        if (moveX >= moveY)
        {
            // If the gameObject is moving to the Left then flip the sprite horizontaly.
            if (movement.moveX < 0)
            {
                spriteRenderer.flipX = true;
            }
            // If the gameObject is moving to the Right then flip the sprite horizontaly.
            else if (movement.moveX > 0)
            {
                spriteRenderer.flipX = false;
            }
            // If the gameObject is not moving then apply the idle sprite.
            if (moveX == 0 && moveY == 0)
            {
                spriteRenderer.sprite = idle;
            }
        }
        // Changes the wait time so that it is proportional to the speed of the player meaning that the animation playes 
        waitTimeX = (animSpeed * (1 / acceleration + 1) / (1 / acceleration)) * (1 / (moveX + acceleration));
        waitTimeY = (animSpeed * (1 / acceleration + 1) / (1 / acceleration)) * (1 / (moveY + acceleration));
    }

    // Cycles through the horizontal walk animations if the player is moving more horizontaly than verticaly or is going diaganoly.
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
    // Cycles through the downwards walk animations if the player is moving more downwards than horizontaly.
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
    // Cycles through the upwards walk animations if the player is moving more upwards than horizontaly
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
