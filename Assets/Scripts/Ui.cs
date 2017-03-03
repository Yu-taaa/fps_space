using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{
    private float _time;
    [SerializeField] private GunController GunController;
    [SerializeField] private Text _timeText;
    [SerializeField] private Text _ptText;
    [SerializeField] private Text _bulletboxText;
    [SerializeField] private Text _bulletText;
    [SerializeField] private Score _score;


    // Use this for initialization
    void Start()
    {
        _time = 90.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        _timeText.text = "Time : " + _time.ToString("N1") + "s";
        _ptText.text = "Pt : " + _score._scorePoint;
        _bulletboxText.text = "BulletsBox : " + GunController.BulletsBox;
        _bulletText.text = "Bullets : " + GunController.Bullets;
    }
}