using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {


    public Material blueMaterial;
    public Material redMaterial;
    public MeshRenderer mR;

	// Use this for initialization
	void Start () {
        mR = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeMaterial(redMaterial);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ChangeMaterial(blueMaterial);
        }

    }

    void ChangeMaterial(Material materialTarget)
    {
        mR.material = materialTarget;
    }
}
