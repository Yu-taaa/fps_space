using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GunController Bullet;
    private float coolTime = 0.0f;


    // Use this for initialization
    void Start()
    {
        Bullet = gameObject.GetComponent<GunController>();
    }

    // Update is called once per frame
    void Update()
    {
        coolTime += Time.deltaTime;


        if (Input.GetButtonDown("Fire1") && coolTime > 0.5f)
        {
            Bullet.shoot();

        }
        if (Input.GetKey(KeyCode.R))
        {
            Bullet.BulletsAmount();
        }
    }
}