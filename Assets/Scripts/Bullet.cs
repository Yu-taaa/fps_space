using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int Bullets = 30;
    public int BulletsBox = 150;
    private int _addbullets;

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