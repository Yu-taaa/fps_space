using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int _bullets = 30;
    public int _bulletsBox = 150;
    private int _addbullets;

    public void BulletsReduction()
    {
        _bullets -= 1;
    }

    public void BulletsAmount()
    {
        _addbullets = 30 - _bullets;
        if (_bullets >= 30)
        {
            return;
        }

        if ( _bulletsBox > _addbullets)
        {
            _bullets += _addbullets;
            _bulletsBox -= _addbullets;
        }
        else
        {
            _bullets += _bulletsBox;
            _bulletsBox = 0;
        }
    }
}

