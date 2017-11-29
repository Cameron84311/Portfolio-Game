using UnityEngine;

public class UseShield : MonoBehaviour {

	public GameObject sheild;
	public float rotationSpeed = 5f;
	public float joystickDeadzone = 0.2f;

	float xAxis;
	float yAxis;
	
	void Update () {
		this.transform.position = sheild.transform.position;
		if (Input.GetButton("Fire2"))
		{
			Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(sheild.transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            sheild.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            sheild.SetActive(true);
        } else
        {
            sheild.SetActive(false);
        }
		if (Mathf.Abs (Input.GetAxis ("Horizontal2")) >= joystickDeadzone || Mathf.Abs (Input.GetAxis ("Vertical2")) >= joystickDeadzone)
		{
			sheild.SetActive(true);
			xAxis = Input.GetAxis("Horizontal2");
			yAxis = Input.GetAxis("Vertical2");
			float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
			sheild.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0,0,(-joystickAngle)+ 90), 1);
		}
	}
}
