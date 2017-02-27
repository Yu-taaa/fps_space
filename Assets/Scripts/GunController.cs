﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public int Bullets = 30;
    public int BulletsBox = 150;
    private int _addbullets;
    private GameObject _spark;
    private GameObject _sparkMuzzle;
    private AudioSource _audioSource;
    [SerializeField] AudioClip impact;
    [SerializeField] private GameObject _target;
    [SerializeField] private GameObject _gun;
    [SerializeField] private GameObject _muzzle;


    public void shoot()
    {
        if (Bullets <= 0)
        {
            return;
        }
        _audioSource = gameObject.GetComponent<AudioSource>();
        BulletsReduction();
        _audioSource.PlayOneShot(impact);
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit))
        {
            return;
        }

        _spark = (GameObject) Instantiate(_target);
        _sparkMuzzle = (GameObject) Instantiate(_gun);


        _spark.transform.position = hit.point;
        _sparkMuzzle.transform.position = _muzzle.transform.position;


        Destroy(_spark, 0.3f);
        Destroy(_sparkMuzzle, 0.2f);
    }

    public void BulletsReduction()
    {
        Bullets -= 1;
    }

    public void BulletsAmount()
    {
        _addbullets = 30 - Bullets;
        if (Bullets >= 30)
        {
            return;
        }

        if (BulletsBox > _addbullets)
        {
            Bullets += _addbullets;
            BulletsBox -= _addbullets;
        }
        else
        {
            Bullets += BulletsBox;
            BulletsBox = 0;
        }
    }
}