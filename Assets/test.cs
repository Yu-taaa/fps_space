using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


	// Update is called once per frame
	void Update () {

	    if (Input.GetKey(KeyCode.C))
	    {
	        transform.position = new Vector3(transform.position.x, 30f, transform.position.z);
	    }
		
	}
}
