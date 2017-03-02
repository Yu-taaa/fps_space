using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    [SerializeField] int _hp = 5;



    // Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
	}


    public void HitTarget()
    {
        print(_hp);
        _hp--;
    }
}
