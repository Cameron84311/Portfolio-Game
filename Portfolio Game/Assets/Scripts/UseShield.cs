using UnityEngine;

public class UseShield : MonoBehaviour {
 
    private GameObject shield;

    public float rotationSpeed = 5f;
	public float joystickDeadzone = 0.2f;
    
    float xAxis;
	float yAxis;

    void Start()
    {
        // Finds Shield GameObject and applies it to shield.
        shield = GameObject.Find("Shield");
    }

    void Update()
    {
        if (Input.GetButton("Fire2"))
		{
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(shield.transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            shield.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            shield.SetActive(true);
        } else
        {
            shield.SetActive(false);
        }
		if (Mathf.Abs (Input.GetAxis ("Horizontal2")) >= joystickDeadzone || Mathf.Abs (Input.GetAxis ("Vertical2")) >= joystickDeadzone)
		{
            shield.SetActive(true);
			xAxis = Input.GetAxis("Horizontal2");
			yAxis = Input.GetAxis("Vertical2");
			float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
            shield.transform.rotation = Quaternion.Slerp(shield.transform.rotation, Quaternion.Euler(0,0,(-joystickAngle)+ 90), 1);
		}
    }
}