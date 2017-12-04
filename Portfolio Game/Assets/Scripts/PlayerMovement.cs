using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2;
    private SpriteRenderer spriteRenderer;
	public Sprite idle;
	public Sprite walk0;
    public Sprite walk1;
    public Sprite walk2;
    public Sprite walk3;
    public Sprite walk4;
    public Sprite walk5;
    public float animSpeed = 10f;
	public float moveX;
	public float moveY;
	public float waitTime;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
		StartCoroutine (waiter ());
    }

    void Update(){
        
        Vector3 moveDir = Vector3.zero;
		moveDir.x = Input.GetAxis("Horizontal");
		moveDir.y = Input.GetAxis("Vertical");
        transform.position += moveDir * speed * Time.deltaTime;
        
        if (moveDir.x < 0)
        {
            spriteRenderer.flipX = true;
		} else if (moveDir.x > 0)
        {
            spriteRenderer.flipX = false;
        }
		if (moveX == 0) {
			spriteRenderer.sprite = idle;
		}
		moveX = Mathf.Abs (moveDir.x);
		moveY = Mathf.Abs (moveDir.y);
	}



	IEnumerator waiter()
    {
		while (true){
			
			if (moveX > moveY) {
				spriteRenderer.sprite = walk0;
			}
			yield return new WaitForSeconds (animSpeed);
			if (moveX > moveY) {
				spriteRenderer.sprite = walk1;
			}
			yield return new WaitForSeconds (animSpeed);
			if (moveX > moveY) {
				spriteRenderer.sprite = walk2;
			}
			yield return new WaitForSeconds (animSpeed);
			if (moveX > moveY) {
				spriteRenderer.sprite = walk3;
			}
			yield return new WaitForSeconds (animSpeed);
			if (moveX > moveY) {
				spriteRenderer.sprite = walk4;
			}
			yield return new WaitForSeconds (animSpeed);
			if (moveX > moveY) {
				spriteRenderer.sprite = walk5;
			}
			yield return new WaitForSeconds (animSpeed);
        }
    }
}

