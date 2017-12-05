using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2;
	public float moveX;
	public float moveY;

    void Update(){
        
        Vector3 moveDir = Vector3.zero;
		moveDir.x = Input.GetAxis("Horizontal");
		moveDir.y = Input.GetAxis("Vertical");
        transform.position += moveDir * speed * Time.deltaTime;
        moveX = moveDir.x;
        moveY = moveDir.y;
	}
}

