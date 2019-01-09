using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour {

    private Vector3 startScale;

	// Use this for initialization
	void Start () {
        startScale = transform.localScale;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("the current cube is already fat now");
            transform.localScale = new Vector3(2,2,2);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("the current cube is already small now");
            transform.localScale = startScale;
        }

    }
}
