using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private const string TAG_ENEMY = "Enemy";
    [SerializeField] private Rigidbody _rigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(TAG_ENEMY))
        {
            Debug.Log("Enemy");
            Destroy(gameObject);
        }
    }
}
