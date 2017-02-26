using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject targetObj;
    AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            //fire();
            if (Input.GetButtonDown("Fire1")) {
                audioSource.Play();
            }
        }
    }

    void fire()
    {
        // 画面中央の座標を取得。
        Vector3 point = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        Ray ray = Camera.main.ScreenPointToRay(point);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            targetObj = hit.collider.gameObject;
        }
        else
        {
            targetObj = null;
        }
    }
}