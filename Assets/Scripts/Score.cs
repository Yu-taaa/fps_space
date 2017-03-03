using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int _scorePoint;
    private float _distance;
    private Vector3 _headMarkerPosition;
    [SerializeField] private GameObject _headMarker;


    public void ScoreCount(Vector3 bulletHitPoint) //rayのあたった位置
    {
        _headMarkerPosition = _headMarker.transform.position;
        _distance = Vector2.Distance(bulletHitPoint, _headMarkerPosition);
        // Count(_distance);
        _scorePoint = _scorePoint + Count(_distance);
        //print(_scorePoint);
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