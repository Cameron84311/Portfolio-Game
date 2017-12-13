using UnityEngine;
using UnityEngine.UI;

public class DaggerThrow : MonoBehaviour {

    private Vector3 mousePos;
    private Vector2 mouseDir;
    private GameObject fade;
    private float delay;

    [Tooltip("The prefab of the dagger that will be thrown by the player.")]
    public GameObject daggerPrefab;
    [Tooltip("How many frames pass before the player can throw another dagger.")]
    public float reloadTime = 200f;
    [Tooltip("The speed at which the dagger is thrown with.")]
    public float throwPower = 10f;

    void Start ()
	{
		// Finds the CooldownFade gameObject in the GUI.
        fade = GameObject.Find("Dagger CooldownFade");
    }

	void Update ()
    {
		// Gets the position of the mouse on the screen in world coordinates.
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		// Sets the z axis to 0 on the mousePos vector.
        mousePos.z = 0;
		// Gets the relative position of the mouse to the gameObject.
        mouseDir = mousePos - gameObject.transform.position;
		// Removes distance from the mouseDir vector so that it is only a direction.
		mouseDir = mouseDir.normalized;

		// Checks if the Fire1 button is being pressed and delay <= 0.
        if (Input.GetButton("Fire1") && delay <= 0)
        {
			// Spawns the dagger prefab at the same position as the game object.
            GameObject dagger = (GameObject)Instantiate(daggerPrefab, gameObject.transform.position, gameObject.transform.rotation);
			// Gives the dagger velocity towards the mouse.
            dagger.GetComponent<Rigidbody2D>().velocity = mouseDir * throwPower;
			// Sets the delay float to equal the reload time.
            delay = reloadTime;
        }
		// Sets the fill amount of the cooldown fade in the GUI the perecent of reload time that has passed.
        fade.GetComponent<Image>().fillAmount = delay/reloadTime;
		// Takes 1 away from delay every frame.
		delay--;
	}
}
