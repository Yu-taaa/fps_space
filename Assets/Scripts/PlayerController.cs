using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    [SerializeField] private GameObject _target;
    [SerializeField] private int _bullets = 30;
    [SerializeField] private int _bulletsBox = 150;
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

        if (Input.GetButtonDown("Fire1") && coolTime > 0.5f)
        {
            _audioSource.Play();
            fire();
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