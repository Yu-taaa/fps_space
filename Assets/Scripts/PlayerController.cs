using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float coolTime = 0.0f;
    private bool _isSnipe;
    [SerializeField] private GunController Bullet;
    [SerializeField] private float _cameraPosition;
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _snipe;

    // Use this for initialization
    void Start()
    {
        Bullet = gameObject.GetComponent<GunController>();
        _cameraPosition = _camera.fieldOfView;
        _isSnipe = false;
        _snipe.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        coolTime += Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && coolTime > 0.5f)
        {
            Bullet.shoot();
            coolTime = 0.0f;
        }
        if (Input.GetKey(KeyCode.R))
        {
            Bullet.BulletsAmount();
        }

        if (!Input.GetMouseButton(1))
        {
            return;
        }
        if (_isSnipe == false)
        {
            _isSnipe = true;
            _snipe.SetActive(true);
            _camera.fieldOfView = 20.0f;
        }
        else
        {
            _isSnipe = false;
            _snipe.SetActive(false);
            _camera.fieldOfView = 40.0f;
        }
    }
}