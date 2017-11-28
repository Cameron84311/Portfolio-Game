using UnityEngine;
using System.Collections;

public class UseShield : MonoBehaviour {

    public GameObject Sheild;
	
	void Update () {
		if (Input.GetButton("Fire2"))
		{
            Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(Sheild.transform.position);
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            Sheild.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            Sheild.SetActive(true);
        } else
        {
            Sheild.SetActive(false);
        }

	}
}
