using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

    //Makes the door a variable
    public GameObject door;
    public GameObject door2;
    public GameObject View;

    void OnCollisionEnter2D() {

		JuiceBox.Rattle(door);
        Destroy(door, 0.6f);
        JuiceBox.Rattle(door2);
        Destroy(door2, 0.6f);
        JuiceBox.Wobble(View, 0.5f);
        Destroy(gameObject);

    }
}