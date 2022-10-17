using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const string TAG_ENEMY = "Enemy";
    private const string TAG_GROUND = "Ground";
   private Rigidbody _rigidbody;
    public Rigidbody Rigidbody => _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(TAG_ENEMY)||collision.collider.CompareTag(TAG_GROUND))
        {
            
            Destroy(gameObject);
        }
    }
}
