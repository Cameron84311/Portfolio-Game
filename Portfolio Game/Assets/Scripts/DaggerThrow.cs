using UnityEngine;
using UnityEngine.UI;

public class DaggerThrow : MonoBehaviour {

    private Vector3 mousePos;
    private Vector2 mouseDir;
    public GameObject daggerPrefab;
    private GameObject fade;
    public float reloadTime = 200f;
    public float throwPower = 10f;
    private float delay;

    void Start ()
    {
        fade = GameObject.Find("CooldownFade");
    }

	void Update ()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        mouseDir = mousePos - gameObject.transform.position;
        mouseDir = mouseDir.normalized;

        if (Input.GetButton("Fire1") && delay <= 0)
        {           
            GameObject dagger = (GameObject)Instantiate(daggerPrefab, gameObject.transform.position, gameObject.transform.rotation);
            dagger.GetComponent<Rigidbody2D>().velocity = mouseDir * throwPower;
            delay = reloadTime;
        }
        fade.GetComponent<Image>().fillAmount = delay/reloadTime;
        delay--;
	}
}
