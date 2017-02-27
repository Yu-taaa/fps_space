using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public int Bullets = 30;
    public int BulletsBox = 150;
    private int _addbullets;
    private GameObject _spark;
    private AudioSource _audioSource;
    [SerializeField] private GameObject _target;


    public void shoot()
    {
        if (Bullets <= 0)
        {
            return;
        }
        _audioSource = gameObject.GetComponent<AudioSource>();
        BulletsReduction();
        _audioSource.Play();
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit))
        {
            return;
        }

        _spark = (GameObject) Instantiate(_target);
        _spark.transform.position = hit.point;
        Destroy(_spark, 0.3f);
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