using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private Rigidbody2D rb;

    public float speed = 2;
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

	void Update(){
		Vector3 moveDir = Vector3.zero;
		moveDir.x = Input.GetAxis("Horizontal");
		moveDir.y = Input.GetAxis("Vertical");
		transform.position += moveDir * speed * Time.deltaTime;
        Debug.Log(rb.velocity.x);
        // if (rb.velocity.x <= 0)
        //{
        //     spriteRenderer.flipX = true;
        // } else
        //{
        //    spriteRenderer.flipX = false;
        //}
    }
}
