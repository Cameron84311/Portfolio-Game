using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb;
    public float speed = 2;
    private SpriteRenderer spriteRenderer;
    public Sprite walk0;
    public Sprite walk1;
    public Sprite walk2;
    public Sprite walk3;
    public Sprite walk4;
    public Sprite walk5;
    public float animSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update(){
        
        Vector3 moveDir = Vector3.zero;
		moveDir.x = Input.GetAxis("Horizontal");
		moveDir.y = Input.GetAxis("Vertical");
        transform.position += moveDir * speed * Time.deltaTime;
        
        if (moveDir.x <= 0)
        {
            spriteRenderer.flipX = true;
        } else
        {
            spriteRenderer.flipX = false;
        }
        if (Mathf.Abs(moveDir.x) > Mathf.Abs(moveDir.y))
        {
            speed = Mathf.Abs(moveDir.x);
            StartCoroutine(waiter(speed));
        }
    }
IEnumerator waiter(float speed)
    {
        while (true) {
            spriteRenderer.sprite = walk0;
            yield return new WaitForSeconds(animSpeed);
            spriteRenderer.sprite = walk1;
            yield return new WaitForSeconds(animSpeed);
            spriteRenderer.sprite = walk2;
            yield return new WaitForSeconds(animSpeed);
            spriteRenderer.sprite = walk3;
            yield return new WaitForSeconds(animSpeed);
            spriteRenderer.sprite = walk4;
            yield return new WaitForSeconds(animSpeed);
            spriteRenderer.sprite = walk5;
            yield return new WaitForSeconds(animSpeed);
        }
    }
}

