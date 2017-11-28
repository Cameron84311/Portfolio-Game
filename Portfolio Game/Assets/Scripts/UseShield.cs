using UnityEngine;
using System.Collections;

public class UseShield : MonoBehaviour {

    public GameObject Sheild;
	
	void Update () {
		if (Input.GetButton("Fire2"))
		{
            Sheild.SetActive(true);
        } else
        {
            Sheild.SetActive(false);
        }

	}
}
