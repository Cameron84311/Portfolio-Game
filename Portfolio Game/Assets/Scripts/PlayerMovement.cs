using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2;
    public float acceleration = 1;
	public float moveX;
	public float moveY;

    void Update(){
        
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal"); moveX = moveDir.x;
        moveDir.y = Input.GetAxis("Vertical"); moveY = moveDir.y;
        transform.position += moveDir * speed * Time.deltaTime;
	}
}