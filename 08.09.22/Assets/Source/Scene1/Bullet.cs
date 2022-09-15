using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;
    
    [SerializeField] Rigidbody _rb;
    
    private float _lifeTime = 5000;

    private void Start()
    {
        _rb.AddForce(transform.forward * _bulletSpeed, ForceMode.Impulse);
    }

    private void Update()
    {
        _lifeTime--;
        if (_lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
