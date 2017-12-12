using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 2;
    [HideInInspector]
    public float moveX;
    [HideInInspector]
    public float moveY;

    void Update(){
        // Creates new Vector3 called moveDir with values of 0.
        Vector3 moveDir = Vector3.zero;
        // Applies the Horizontal input axis to the x axis of moveDir.
        moveDir.x = Input.GetAxis("Horizontal");
        // Applies the Vertical input axis to the y axis of moveDir.
        moveDir.y = Input.GetAxis("Vertical"); 
        // Applies moveDir to the players transform.
        transform.position += moveDir * speed * Time.deltaTime;
        
        //Apllies x and y values to corresponding floats for other scripts to use.
        moveX = moveDir.x;
        moveY = moveDir.y;
    }
}