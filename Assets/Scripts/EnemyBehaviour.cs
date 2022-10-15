using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private GameObject _enemy;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Bullet>())
        {
            Destroy(gameObject);
        }
    }
}