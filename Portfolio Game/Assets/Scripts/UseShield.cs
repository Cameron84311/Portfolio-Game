using UnityEngine;
using UnityEngine.UI;

public class UseShield : MonoBehaviour {
 
    private GameObject shield;
    private GameObject fade;

    public float regenSpeed = 3f;
    public float useSpeed = 5f;
    public float fillArea;
    [Tooltip("Currently unused.")]
    public float rotationSpeed = 5f;
    [Tooltip("The amount that the joystick moves before the shield appears")]
    public float joystickDeadzone = 0.2f;
    
    float xAxis;
	float yAxis;

    void Start()
    {
        // Finds Shield GameObject and applies it to shield.
        shield = GameObject.Find("Shield");
        // Finds the CooldownFade gameObject in the GUI.
        fade = GameObject.Find("Shield CooldownFade");
    }

    void Update()
    {
        fade.GetComponent<Image>().fillAmount = fillArea/1000;
        if (Input.GetButton("Fire2") && fillArea != 1000)
		{
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(shield.transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            shield.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            shield.SetActive(true);
            if (fillArea < 1000)
            {
            fillArea = fillArea + useSpeed;
            }
        } else
        {
            shield.SetActive(false);
            if (fillArea > 0)
            {
                fillArea = fillArea - regenSpeed;
            }   
        }
        if (Mathf.Abs(Input.GetAxis("Horizontal2")) >= joystickDeadzone || Mathf.Abs(Input.GetAxis("Vertical2")) >= joystickDeadzone && fillArea != 1000)
		{
            shield.SetActive(true);
			xAxis = Input.GetAxis("Horizontal2");
			yAxis = Input.GetAxis("Vertical2");
			float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
            shield.transform.rotation = Quaternion.Slerp(shield.transform.rotation, Quaternion.Euler(0,0,(-joystickAngle)+ 90), 1);
            if (fillArea < 1000)
            {
                fillArea = fillArea + useSpeed;
            }
		}   
    }
}