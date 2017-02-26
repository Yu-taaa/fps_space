using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{

    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            audioSource.Play();
        }
    }
}