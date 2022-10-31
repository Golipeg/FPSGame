using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _bulletVelocity=20f;
    private bool _isEmptyAmmo = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !_isEmptyAmmo)
        {
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.Rigidbody.velocity = transform.forward * _bulletVelocity;
            GameEvents.Instance.OnShoot?.Invoke();
        }
        



    }

    private void OnEnable()
    {
        GameEvents.Instance.OnEmptyAmmo += EmptyAmmoTracker;
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnEmptyAmmo -= EmptyAmmoTracker;
    }

    private void EmptyAmmoTracker(bool b)
    {
        _isEmptyAmmo = b;
    }
}
