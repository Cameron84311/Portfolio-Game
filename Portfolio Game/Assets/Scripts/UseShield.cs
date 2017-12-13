using UnityEngine;
using UnityEngine.UI;

public class UseShield : MonoBehaviour
{

    private GameObject shield;
    private GameObject fade;
    private float delay;
    private bool delayed = false;
    private float fillArea;
    float xAxis;
    float yAxis;

    [Header("Properties")]
    [Tooltip("The speed that the shield regenerates.")]
    [Range(0,10)]
    public float regenSpeed = 3f;
    [Tooltip("The speed that the shield is used when active.")]
    [Range(0,10)]
    public float useSpeed = 5f;
    [Tooltip("The delay before the shield can be used again.")]
    [Range(0,100)]
    public float useDelay = 50f;
    [Header("Controller")]
    [Tooltip("Currently unused.")]
    public float rotationSpeed = 5f;
    [Tooltip("The amount that the joystick moves before the shield appears.")]
    public float joystickDeadzone = 0.2f;

    void Start()
    {
        // Finds Shield GameObject and applies it to shield.
        shield = GameObject.Find("Shield");
        // Finds the CooldownFade gameObject in the GUI.
        fade = GameObject.Find("Shield CooldownFade");
    }

    void Update()
    {
        // Applies the fillArea to the Shield GUI.
        fade.GetComponent<Image>().fillAmount = fillArea / 1000;

        // Checks if the delay is more than 0
        if (delay > 0)
        {
            // Checks if the player is not trying to use the shield and removes 1 from delay every frame.
            if (!(Input.GetButton("Fire2") || Mathf.Abs(Input.GetAxis("Horizontal2")) >= joystickDeadzone || Mathf.Abs(Input.GetAxis("Vertical2")) >= joystickDeadzone)) { delay--; }
            // Checks if the delay is more than 1 and removes 1 from delay every frame.
            else if (delay > 1) { delay--; }
        // Sets the delayed bool to false.
        } else { delayed = false; }

        // Checks if the fillArea is more than or equal to 1000 and sets the delayed bool to true.
        if (fillArea >= 1000) { delayed = true; }

        // Checks if the Fire2 button is being pressed and if the fillArea is not equal to 1000 and the delayed bool is false.
        if (Input.GetButton("Fire2") && fillArea != 1000 & !delayed)
        {
            // Creates a new Vector3 called dir and gets the mouse position in the world..
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(shield.transform.position);
            // Gets the angle from the player to the mouse.
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            // Makes the Shield rotate towards the mouse.
            shield.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            // Activates the Shield so it appears on the player.
            shield.SetActive(true);
            // Sets the delay to be equal to the useDelay.
            delay = useDelay;
            // Checks if the fillArea is less than 1000 and adds the useSpeed to it.
            if (fillArea < 1000) { fillArea = fillArea + useSpeed; }
        } else {
            // Deactivates the Shield.
            shield.SetActive(false);
            // Sets the delayed bool to true.
            delayed = true;
            // Checks if the fillArea is more than 0 and the delay is 0 then minuses the regenSpeed from the fillArea.
            if (fillArea > 0 && delay == 0) {fillArea = fillArea - regenSpeed; }
        }

        // Checks if the right analog stick is more than the joystickDeadzone in either x or y axis and if the fillArea does not equal 1000 and if the delayed bool is false.
        if (Mathf.Abs(Input.GetAxis("Horizontal2")) >= joystickDeadzone || Mathf.Abs(Input.GetAxis("Vertical2")) >= joystickDeadzone && fillArea != 1000 & !delayed)
        {
            // Actiaves the Shield.
            shield.SetActive(true);
            // Applies the horizontal axis of the right analog stick to the x axis.
            xAxis = Input.GetAxis("Horizontal2");
            // Applies the vertical axis of the right analog stick to the y axis.
            yAxis = Input.GetAxis("Vertical2");
            // Gets the angle of the joystick.
            float joystickAngle = Mathf.Atan2(xAxis, yAxis) * Mathf.Rad2Deg;
            // Applies the angle of the joystick to the rotation of the Shield.
            shield.transform.rotation = Quaternion.Slerp(shield.transform.rotation, Quaternion.Euler(0, 0, (-joystickAngle) + 90), 1);
            // Sets delay to be equal to useDelay.
            delay = useDelay;
            // Checks if the fillArea is less than 1000 and adds the useSpeed to it.
            if (fillArea < 1000) { fillArea = fillArea + useSpeed; }
        }
    }
}