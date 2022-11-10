using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DefaultExecutionOrder(-5)]
public class GameEvents : MonoBehaviour
{
    public static GameEvents Instance;

    public Action OnShoot;// создал Event
    public Action <bool>OnEmptyAmmo;
    public Action<int> OnEnemyInit;
    public Action OnUpdateEnemyUI;
    public Action<int> OnRechargeWeapon;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }
        DontDestroyOnLoad(this);
    }
}
