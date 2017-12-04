using UnityEngine;

public class UseShield : MonoBehaviour {

	public GameObject sheild;
	public float rotationSpeed = 5f;
	public float joystickDeadzone = 0.2f;
    //private SpriteRenderer spriteRenderer;
    //public Sprite sheildDown;
    //public Sprite sheildOut;
    
    float xAxis;
	float yAxis;

    //void Start()
    //{
        //spriteRenderer = GetComponent<SpriteRenderer>();
    //}

    void Update () {
        
        if (Input.GetButton("Fire2"))
		{
            //spriteRenderer.sprite = sheildOut;
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(sheild.transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            sheild.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            sheild.SetActive(true);
        } else
        {
            //spriteRenderer.sprite = sheildDown;
            sheild.SetActive(false);
        }
		if (Mathf.Abs (Input.GetAxis ("Horizontal2")) >= joystickDeadzone || Mathf.Abs (Input.GetAxis ("Vertical2")) >= joystickDeadzone)
		{
            //spriteRenderer.sprite = sheildOut;
            sheild.SetActive(true);
			xAxis = Input.GetAxis("Horizontal2");
			yAxis = Input.GetAxis("Vertical2");
			float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
			sheild.transform.rotation = Quaternion.Slerp(sheild.transform.rotation, Quaternion.Euler(0,0,(-joystickAngle)+ 90), 1);
		}
    }
}