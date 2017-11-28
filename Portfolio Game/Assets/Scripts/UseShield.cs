using UnityEngine;

public class UseShield : MonoBehaviour {

    public GameObject sheild;
	
	void Update () {
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

	}
}
