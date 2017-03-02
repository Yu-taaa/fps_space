using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;
using UnityEditor;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    private float _distance;
    private Vector3 _headMarkerPosition;
    [SerializeField] private GameObject _headMarker;


    public void ScoreCount(Vector3 bulletHitPoint) //rayのあたった位置
    {
        _headMarkerPosition = _headMarker.transform.position;
        _distance = Vector3.Distance(bulletHitPoint, _headMarkerPosition);
        Count(_distance);
        score += Count(_distance);
        print(score);
    }

     private int Count(float distance)
    {
        if (distance < 0.1f)
        {
            return 100;
        }
        else if (distance < 0.2)
        {
            return 50;
        }
        else
        {
            return 20;
        }
    }
}