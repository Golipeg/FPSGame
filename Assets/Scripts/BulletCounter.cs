using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletCounter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bulletQuantity;
    [SerializeField] private int _startBulletCount;
    [SerializeField] private int _rechargeBulletQuantity;
    private int _currentBulletCount;


    private void Start()
    {
        _bulletQuantity.text = _startBulletCount.ToString();
        _currentBulletCount = _startBulletCount;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameEvents.Instance.OnRechargeWeapon?.Invoke(_startBulletCount);
        }
    }

    private void OnEnable()
    {
        GameEvents.Instance.OnShoot += DecreaseBulletCount;
        GameEvents.Instance.OnRechargeWeapon += RechargeWeapon;
    }

    private void DecreaseBulletCount()
    {
        if (_currentBulletCount > 0)
        {
            _currentBulletCount--;
            _bulletQuantity.text = _currentBulletCount.ToString();
            if (_currentBulletCount <= 0)
            {
                GameEvents.Instance.OnEmptyAmmo?.Invoke(true);
            }
        }
    }

    private void RechargeWeapon(int rechargeQuantity)
    {
        _bulletQuantity.text = _startBulletCount.ToString();
            _currentBulletCount = _startBulletCount;
            GameEvents.Instance.OnEmptyAmmo?.Invoke(false);
    }

    private void OnDisable()
    {
        GameEvents.Instance.OnShoot -= DecreaseBulletCount;
        GameEvents.Instance.OnRechargeWeapon -= RechargeWeapon;
    }
}