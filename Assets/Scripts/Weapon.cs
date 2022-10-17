using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _bulletVelocity=20f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.Rigidbody.velocity = transform.forward * _bulletVelocity;

        }
    }
}
