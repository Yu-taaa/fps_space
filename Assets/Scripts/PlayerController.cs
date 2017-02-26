using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private Bullet Bullet;
    private int _useBullets;
    private AudioSource _audioSource;


    private float coolTime = 0.0f;

    private GameObject _Spark;

    // Use this for initialization
    void Start()
    {
        _audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        coolTime += Time.deltaTime;
        Bullet = gameObject.GetComponent<Bullet>();
        _useBullets = Bullet.Bullets;

        if (Input.GetButtonDown("Fire1") && coolTime > 0.5f && _useBullets != 0)
        {
            Bullet.BulletsReduction();
            _audioSource.Play();
            fire();
        }
        if (Input.GetKey(KeyCode.R))
        {
            Bullet.BulletsAmount();
        }
    }

    void fire()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit))
        {
            return;
        }

        _Spark = (GameObject) Instantiate(_target);
        _Spark.transform.position = hit.point;
        Destroy(_Spark, 0.3f);
        coolTime = 0.0f;
    }
}