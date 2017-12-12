using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DaggerThrow : MonoBehaviour {

    public GameObject daggerPrefab;
    public GameObject delaySlider;
    public float  reloadTime = 200f;
    private float delay;
    public float horizontalVelocity = 5f;
    public float verticalVelocity = 5f;

	void Update () {

        if (Input.GetButton("Fire1") && delay <= 0)
        {           
            GameObject dagger = (GameObject)Instantiate(daggerPrefab, gameObject.transform.position, gameObject.transform.rotation);
            dagger.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalVelocity, verticalVelocity);
            delay = reloadTime;
        }
        delaySlider.GetComponent<Image>().fillAmount = delay/reloadTime;
        delay--;
	}
}
