using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Animator _anim;
    [SerializeField] int _hp = 5;


    // Use this for initialization
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void HitTarget()
    {
        if (_hp > 0)
        {
            print(_hp);
            _hp--;
        }
        else if (_hp == 0)
        {
            _anim.SetBool("IsFall", true);
            Invoke("UpTarget", 1.0f);
        }
    }


    void UpTarget()
    {
        _anim.SetBool("IsFall", false);
        _hp = 5;
    }
}